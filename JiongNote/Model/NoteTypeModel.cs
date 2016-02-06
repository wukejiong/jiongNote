﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiongNote.Model
{
    /// <summary>
    /// 笔记分类model
    /// </summary>
    public class NoteTypeModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }
    }
}
