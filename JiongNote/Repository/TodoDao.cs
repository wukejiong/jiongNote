using JiongNote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using JiongNote.Utility;

namespace JiongNote.Repository
{
    public static class TodoDao
    {
        private static string treePath = Tool.GetResoucePath("/Resources/Data/todo.xml");
        private static string timeTemp = "yyyy-MM-dd HH:mm:ss";

        #region  获取所有待办
        /// <summary>
        /// 获取所有待办
        /// </summary>
        /// <returns></returns>
        public static List<ToDoModel> GetAllTodos()
        {
            var result = new List<ToDoModel>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(treePath);
            XmlNodeList todoList = xmlDoc.SelectNodes("/Todos/Todo");
            foreach (XmlNode node in todoList)
            {
                result.Add(parseNoteNode(node));
            }
            return result;
        }

        /// <summary>
        /// 获取所有待办
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllTodos2()
        {
            var result = new List<string>();
           var data = GetAllTodos();
           foreach (var item in data)
            {
               var isdo = item.IsDo?"delete-":"";
               var title =item.Content.Length>50?item.Content.Substring(0,50):item.Content;
               var time =item.Deadline.ToString("MM-dd HH:mm");
               result.Add(string.Concat(isdo, time," - " ,title));
            }
            return result;
        }
        
        /// <summary>
        /// 解析 XmlNode 为 model
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private static ToDoModel parseNoteNode(XmlNode node)
        {
            return new ToDoModel()
            {
                Deadline = DateTime.Parse(node.SelectSingleNode("deadline").GetInnerText()),
                Content = node.SelectSingleNode("content").GetInnerText(),
                IsDo = node.GetAttribute("isdo", "0") == "1"
            };
        }
        #endregion

        #region  获取未处理的待办
        /// <summary>
        /// 获取未处理的待办
        /// </summary>
        /// <returns></returns>
        public static List<ToDoModel> GetTodos()
        {
            var result = new List<ToDoModel>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(treePath);
            XmlNodeList todoList = xmlDoc.SelectNodes("/Todos/Todo[@isdo=0]");
            foreach (XmlNode node in todoList)
            {
                result.Add(parseNoteNode(node));
            }
            return result;
        }

        /// <summary>
        /// 获取未处理的待办
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTodos2()
        {
            var result = new List<string>();
            var data = GetTodos().OrderBy(p=>p.Deadline).ToList();
            int i = 1;
            foreach (var item in data)
            {
                var time = item.Deadline.ToString(timeTemp);
                var title = item.Content.Length > 30 ? item.Content.Substring(0, 50) : item.Content.PadRight(30,' ');
                //var key = CryptHelper.Md5Encrypt(item.Content);
                result.Add(string.Concat("[" + i + "] ", title, " ₪(", time, ")"));
                i++;
            }
            return result;
        }
        #endregion

        #region 添加待办

        /// <summary>
        /// 添加待办
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Add(ToDoModel model) {
            try
            {
                var xPath ="/Todos" ;
                var nodeName = "Todo";
                var innerXml = @"<deadline>" + model.Deadline.ToString(timeTemp) + "</deadline>" +
                                         "<content><![CDATA["+model.Content+"]]> </content>";
                var attrName ="isdo";
                var attrValue="0";
               return XMLHelper.CreateXmlNodeByXPath(treePath,xPath,nodeName,innerXml,attrName,attrValue);
            }
            catch (Exception ex) {
                return false;
            }
        }
        #endregion

        #region 完成待办
        /// <summary>
        /// 完成待办
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Complete(DateTime deadline)
        {
            try
            {
                var xmlPath = "/Todos/Todo[@isdo=0][deadline='" + deadline.ToString(timeTemp) + "']";
                var xmlAttributeName = "isdo";
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
