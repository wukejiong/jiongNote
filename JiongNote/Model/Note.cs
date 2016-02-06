﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiongNote.Model
{

    /// <summary>
    /// 笔记类型
    /// </summary>
    public class NoteType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<NoteModel> Notes { get; set; }
    }

    /// <summary>
    /// 笔记
    /// </summary>
    public class NoteModel
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 内容（可以是url，也可以是内容）
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 是否阅读
        /// </summary>
        public bool IsRead { get; set; }
    }
}
