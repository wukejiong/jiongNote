using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using JiongNote.Model;
using JiongNote.Utility;
using System.Text.RegularExpressions;

namespace JiongNote.Repository
{
    public class NoteDao
    {
        private static string treePath = Tool.GetResoucePath("/Resources/Data/note-tree.xml");

        #region 获取笔记的树结构
        /// <summary>
        /// 获取笔记的树结构
        /// </summary>
        /// <returns></returns>
        public static List<NoteType> GetNoteTree()
        {
            var result = new List<NoteType>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(treePath);
            XmlNodeList notesList = xmlDoc.SelectNodes("/Notes/Type");
            foreach (XmlNode typeNode in notesList)
            {
                //create note-list
                var xmlNoteList = typeNode.SelectNodes("Note");
                var noteList = new List<NoteModel>();
                if (xmlNoteList != null)
                {
                    foreach (XmlNode noteNode in xmlNoteList)
                    {
                        noteList.Add(parseNoteNode(noteNode));
                    }
                }

                //add note-type
                result.Add(new NoteType()
                {
                    Id = typeNode.GetAttribute("id", 0),
                    Name = typeNode.GetAttribute("name", ""),
                    Notes = noteList
                });
            }
            return result;
        }

        private static NoteModel parseNoteNode(XmlNode noteNode)
        {
            return new NoteModel()
                {
                    Keywords = noteNode.SelectSingleNode("keyword").GetInnerText(),
                    Title = noteNode.SelectSingleNode("title").GetInnerText(),
                    Content = noteNode.SelectSingleNode("content").GetInnerText(),
                    IsRead = noteNode.GetAttribute("isread", 0) == "1"
                };
        }
        #endregion

        #region 获取待读数据
        /// <summary>
        /// 获取待读数据
        /// </summary>
        /// <returns></returns>
        public static List<string> GetToRead2() { 
            var data = GetToRead();
            var result = new List<string>();
            int i = 1;
            foreach(var item in data){
                var content = item.Content;
                if(!content.StartsWith("http") && content.Length>100){
                    content = content.Substring(0,100);
                }
                var key =CryptHelper.Md5Encrypt(content);
                result.Add(string.Concat("["+i+"]  ",item.Title));
                i++;
            }
            return result;
        }

        /// <summary>
        /// 获取待读数据
        /// </summary>
        /// <returns></returns>
        public static List<NoteModel> GetToRead()
        {
            var result = new List<NoteModel>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(treePath);
            XmlNodeList notesList = xmlDoc.SelectNodes("/Notes/Type/Note[@isread=0]");
            foreach (XmlNode noteNode in notesList)
            {
                result.Add(parseNoteNode(noteNode));
            }
            return result;
        } 
        #endregion
    }
}
