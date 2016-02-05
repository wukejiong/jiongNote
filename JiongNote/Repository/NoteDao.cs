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

        /// <summary>
        /// get note-tree
        /// </summary>
        /// <returns></returns>
       public static List<NoteType> GetNoteTree()
        {
            var result = new List<NoteType>();
            XmlDocument xmlDoc = new XmlDocument() ;
            xmlDoc.Load(treePath);
            XmlNodeList notesList = xmlDoc.SelectNodes("/Notes/Type");
            foreach (XmlNode typeNode in notesList)
            {
                //create note-list
                var xmlNoteList =typeNode.SelectNodes("Note") ;
                var noteList = new List<Note>();
                if (xmlNoteList != null)
                {
                    foreach (XmlNode noteNode in xmlNoteList)
                    {
                        noteList.Add(new Note()
                        {
                            Keywords = noteNode.SelectSingleNode("keyword").GetInnerText(),
                            Title =noteNode.SelectSingleNode("title").GetInnerText(),
                            Content =noteNode.SelectSingleNode("content").GetInnerText()
                        });
                    }
                }
                
                //add note-type
                result.Add(new NoteType()
                {
                      Id= typeNode.GetAttribute("id",0),
                      Name=typeNode.GetAttribute("name",""),
                      Notes = noteList
                });
            }
            return result;
        }
    }
}
