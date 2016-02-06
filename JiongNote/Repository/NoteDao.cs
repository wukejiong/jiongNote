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
        private static string typePath = Tool.GetResoucePath("/Resources/Data/note-type.xml");
        private static string treePath = Tool.GetResoucePath("/Resources/Data/note-tree.xml");
        private static string timeTemp = "yyyy-MM-dd HH:mm:ss";

        #region 获取笔记分类
        public static List<NoteTypeModel> GetTypes (){
            var result = new List<NoteTypeModel>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(typePath);
            XmlNodeList notesList = xmlDoc.SelectNodes("/Types/Item");
            foreach (XmlNode typeNode in notesList)
            {
                //add note-type
                result.Add(new NoteTypeModel()
                {
                    Id =int.Parse(typeNode.GetAttribute("id", 0)),
                    ParentId = int.Parse(typeNode.GetAttribute("parent", 0)),
                    Name = typeNode.GetInnerText()
                });
            }
            return result;
        }
        #endregion 

        #region 获取笔记的树结构
        /// <summary>
        /// 获取笔记的树结构
        /// </summary>
        /// <returns></returns>
        public static List<NoteModel> GetNoteTree()
        {
            var result = new List<NoteModel>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(treePath);
            XmlNodeList notesList = xmlDoc.SelectNodes("/Notes/Note");
            foreach (XmlNode node in notesList)
            {
                result.Add(parseNoteNode(node));
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
                    IsRead = noteNode.GetAttribute("isread", 0) == "1",
                    Type = int.Parse(noteNode.SelectSingleNode("type").GetInnerText()),
                    CreateTime =DateTime.Parse(noteNode.SelectSingleNode("createtime").GetInnerText())
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
                //var key =CryptHelper.Md5Encrypt(item.Content);
                 var maxLength =40;
                 var time = item.CreateTime.ToString(timeTemp);
                 var title = item.Title.Length > maxLength ? item.Title.Substring(0, maxLength) : item.Title.PadRight(maxLength, ' ');
                 result.Add(string.Concat("[" + i + "]  ", title, " ₪(", time, ")"));
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
            XmlNodeList notesList = xmlDoc.SelectNodes("/Notes/Note[@isread=0]");
            foreach (XmlNode noteNode in notesList)
            {
                result.Add(parseNoteNode(noteNode));
            }
            return result;
        } 
        #endregion

        #region 添加阅读
        public static bool Add(NoteModel model) {
            try
            {
                var xPath = "/Notes";
                var nodeName = "Note";
                var innerXml = string.Format(@"<type>{0}</type>
                                                        <title> {1}</title>
                                                        <keyword>{2}</keyword>
                                                        <content><![CDATA[{3}]]></content>
                                                        <createtime>{4}</createtime>",
                                                     model.Type,model.Title,model.Keywords,model.Content,model.CreateTime.ToString(timeTemp));
                var attrName = "isread";
                var attrValue = "0";
                return XMLHelper.CreateXmlNodeByXPath(treePath, xPath, nodeName, innerXml, attrName, attrValue);
            }
            catch (Exception ex)
            {
                return false;
            }
        } 
        #endregion

        #region 完成阅读
        /// <summary>
        /// 完成阅读
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Complete(DateTime createTime)
        {
            try
            {
                var xmlPath = "/Notes/Note[@isread=0][createtime='" + createTime.ToString(timeTemp) + "']";
                var xmlAttributeName = "isread";
                var xmlAttributeValue = "1";
                return XMLHelper.CreateOrUpdateXmlAttributeByXPath(treePath, xmlPath, xmlAttributeName, xmlAttributeValue);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
