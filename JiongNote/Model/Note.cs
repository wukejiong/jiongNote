using System;
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
        public List<Note> Notes { get; set; }
    }

    /// <summary>
    /// 笔记
    /// </summary>
    public class Note
    {
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string Content { get; set; }
    }
}
