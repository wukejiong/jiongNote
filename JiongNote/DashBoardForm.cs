using JiongNote.Repository;
using JiongNote.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiongNote
{
    public partial class DashBoardForm : Form
    {

        private List<string> toDoDataList =new List<string>();
        private List<string> toReadDataList = new List<string>();

        public DashBoardForm()
        {
            InitializeComponent();
            initList();
        }

        private void DownloadFiles() {
            var fileDic =new Dictionary<string,string>();
            fileDic.Add("https://raw.githubusercontent.com/wukejiong/jiongNote/master/JiongNote/Resources/Data/note-tree.xml", Tool.GetResoucePath("/Resources/Data/note-tree.xml"));
            fileDic.Add("https://raw.githubusercontent.com/wukejiong/jiongNote/master/JiongNote/Resources/Data/todo.xml", Tool.GetResoucePath("/Resources/Data/todo.xml"));

            foreach(var item in fileDic){
                DownloadHelper.DownloadAsync(item.Key,item.Value);
            }
        }

        private void initList() {
            toReadDataList = NoteDao.GetToRead2();
            toDoDataList = TodoDao.GetTodos2();
            todoList.Items.AddRange(toDoDataList.ToArray());
            toReadList.Items.AddRange(toReadDataList.ToArray());
        }

        /// <summary>
        /// 刷新待阅读数据
        /// </summary>
        private void RefreshToReadList()
        {
            toReadList.Items.Clear();
            toReadDataList = NoteDao.GetToRead2();
            toReadList.Items.AddRange(toReadDataList.ToArray());
        }

        /// <summary>
        /// 刷新待办数据
        /// </summary>
        private void RefreshToDoList()
        {
            todoList.Items.Clear();
            toDoDataList = TodoDao.GetTodos2();
            todoList.Items.AddRange(toDoDataList.ToArray());
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTodo_Click(object sender, EventArgs e)
        {
            AddToDoForm form = new AddToDoForm();
            form.Owner = this;
            var result =form.ShowDialog();
            if (result == DialogResult.OK) {
                RefreshToDoList();
            }
        }

        /// <summary>
        /// 完成待办数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTodoComplete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定已完成吗?", "标记完成", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                var selectIndex = todoList.SelectedIndex;
                if (selectIndex < 0)
                {
                    MessageBox.Show("您还未选中任何项");
                    return;
                }
                var deadline = DateTime.Parse(toDoDataList[selectIndex].Split(new char[] { '₪' })[1].TrimStart('(').TrimEnd(')'));
                if (TodoDao.Complete(deadline))
                {
                    RefreshToDoList();
                }
                else
                {
                    MessageBox.Show("操作失败！");
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGoRead_Click(object sender, EventArgs e)
        {
            new NoteForm().Show();
        }

        private void btnCompleteRead_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定已完成吗?", "标记完成", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                var selectIndex = toReadList.SelectedIndex;
                if (selectIndex < 0)
                {
                    MessageBox.Show("您还未选中任何项");
                    return;
                }
                var createTime = DateTime.Parse(toReadDataList[selectIndex].Split(new char[] { '₪' })[1].TrimStart('(').TrimEnd(')'));
                if (NoteDao.Complete(createTime))
                {
                    RefreshToReadList();
                }
                else
                {
                    MessageBox.Show("操作失败！");
                }
            }
        }

        private void btnAddRead_Click(object sender, EventArgs e)
        {
            AddToReadForm form = new AddToReadForm();
            form.Owner = this;
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshToReadList();
            }
        }

        private void 下载文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownloadFiles();
        }
    }
}
