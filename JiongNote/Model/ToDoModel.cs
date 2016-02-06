using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiongNote.Model
{
    public class ToDoModel
    {
        /// <summary>
        /// 最后期限
        /// </summary>
        public DateTime Deadline { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否已处理
        /// </summary>
        public bool IsDo { get; set; }
    }
}
