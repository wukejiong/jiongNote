﻿using JiongNote.Model;
using JiongNote.Repository;
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
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            //init tree
            initTree();

            //show icon-browser
            iconBrowser.LoadAsync(Tool.GetResoucePath("\\Resources\\Images\\web-broswer.jpg"));
            this.webBrowser.ScriptErrorsSuppressed=true;
            this.webBrowser.Url = new Uri(Tool.GetResoucePath("\\Resources\\Data\\welcome.html"));
        }


        List<NoteTypeModel> noteTypes;
        List<NoteModel> noteTree;
        /// <summary>
        /// 初始化左侧的树
        /// </summary>
        private void initTree() {
             noteTypes=NoteDao.GetTypes().OrderBy(p=>p.Id).ToList();
             noteTree = NoteDao.GetNoteTree();
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "❤ " + "笔记";
            rootNode.Tag = 0;
            treeView.Nodes.Add(rootNode);
            loadTree(rootNode);
            treeView.ExpandAll();
        }

        private void loadTree(TreeNode parentNode)
        {
            var childTypes = noteTypes.Where(p => p.ParentId ==(int)parentNode.Tag).ToList();
            if (childTypes.Count>0)
            {
                foreach(var childType in childTypes){
                    TreeNode typeNode = new TreeNode();
                    typeNode.Text = "✪ " + childType.Name;
                    typeNode.Tag = childType.Id;
                    parentNode.Nodes.Add(typeNode);
                    loadTree(typeNode);
                }
            }
            else
            {
                foreach (var note in noteTree.Where(p => p.Type == (int)parentNode.Tag).ToList())
                {
                    TreeNode noteNode = new TreeNode();
                    noteNode.Text = "★  " + note.Title;
                    noteNode.Name = note.Keywords;
                    noteNode.Tag = note.Content;
                    parentNode.Nodes.Add(noteNode);
                }
            }
        }

       /// <summary>
       /// 刷新webbrowswer
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.webBrowser.Refresh();
        }

        /// <summary>
        /// 切分布局拖动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splitContainer1_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {
            logLabel.Text = splitContainer1.Panel1.Width.ToString();
            treeView.Width = splitContainer1.Panel1.Width;
        }

        /// <summary>
        /// 禁止创建新窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            var browser =(WebBrowser)sender;
            this.webBrowser.Url = new Uri(browser.StatusText);
            e.Cancel = true; 
        }

        /// <summary>
        /// 切分布局收缩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToogle_Click(object sender, EventArgs e)
        {
            webBrowser.Width = webBrowser.Width + splitContainer1.Panel1.Width * (splitContainer1.Panel1Collapsed ? -1 : 1);
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
            btnToogle.Text = splitContainer1.Panel1Collapsed ? "》" : "《";
        }

        /// <summary>
        /// 浏览器后退
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistoryBack_Click(object sender, EventArgs e)
        {
            this.webBrowser.GoBack();
        }

        /// <summary>
        /// 浏览器前进
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text!="")
            {
                var url = txtUrl.Text;
                if (!url.StartsWith("http")) { 
                url ="http://"+url;
                }
                this.webBrowser.Url = new Uri(url);
            }
        }

        /// <summary>
        /// 树的子项点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                string content = e.Node.Tag.ToString();
                if(content==null){
                    return;
                }
                if (content.StartsWith("http://") || content.StartsWith("https://"))
                {
                    txtUrl.Text = content;
                    this.webBrowser.Url = new Uri(content);
                }
                else
                {
                    txtUrl.Text = "";
                    this.webBrowser.DocumentText = content;
                }
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}