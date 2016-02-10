namespace JiongNote
{
    partial class DashBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.todoList = new System.Windows.Forms.ListBox();
            this.toReadList = new System.Windows.Forms.ListBox();
            this.btnTodoComplete = new System.Windows.Forms.Button();
            this.btnCompleteRead = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddRead = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoList
            // 
            this.todoList.BackColor = System.Drawing.Color.PapayaWhip;
            this.todoList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todoList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.todoList.ForeColor = System.Drawing.Color.Coral;
            this.todoList.FormattingEnabled = true;
            this.todoList.ItemHeight = 23;
            this.todoList.Location = new System.Drawing.Point(13, 74);
            this.todoList.Margin = new System.Windows.Forms.Padding(4);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(613, 255);
            this.todoList.TabIndex = 0;
            this.todoList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.todoList_MouseDoubleClick);
            // 
            // toReadList
            // 
            this.toReadList.BackColor = System.Drawing.Color.PapayaWhip;
            this.toReadList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toReadList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toReadList.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.toReadList.FormattingEnabled = true;
            this.toReadList.ItemHeight = 23;
            this.toReadList.Location = new System.Drawing.Point(16, 74);
            this.toReadList.Margin = new System.Windows.Forms.Padding(4);
            this.toReadList.Name = "toReadList";
            this.toReadList.Size = new System.Drawing.Size(693, 255);
            this.toReadList.TabIndex = 3;
            this.toReadList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.toReadList_MouseDoubleClick);
            // 
            // btnTodoComplete
            // 
            this.btnTodoComplete.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.btnTodoComplete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTodoComplete.ForeColor = System.Drawing.Color.Green;
            this.btnTodoComplete.Location = new System.Drawing.Point(488, 18);
            this.btnTodoComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnTodoComplete.Name = "btnTodoComplete";
            this.btnTodoComplete.Size = new System.Drawing.Size(51, 48);
            this.btnTodoComplete.TabIndex = 4;
            this.btnTodoComplete.Text = "✔";
            this.btnTodoComplete.UseVisualStyleBackColor = true;
            this.btnTodoComplete.Click += new System.EventHandler(this.btnTodoComplete_Click);
            // 
            // btnCompleteRead
            // 
            this.btnCompleteRead.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.btnCompleteRead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompleteRead.ForeColor = System.Drawing.Color.Green;
            this.btnCompleteRead.Location = new System.Drawing.Point(564, 18);
            this.btnCompleteRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompleteRead.Name = "btnCompleteRead";
            this.btnCompleteRead.Size = new System.Drawing.Size(51, 48);
            this.btnCompleteRead.TabIndex = 6;
            this.btnCompleteRead.Text = "✔";
            this.btnCompleteRead.UseVisualStyleBackColor = true;
            this.btnCompleteRead.Click += new System.EventHandler(this.btnCompleteRead_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.groupBox1.Controls.Add(this.btnAddTodo);
            this.groupBox1.Controls.Add(this.todoList);
            this.groupBox1.Controls.Add(this.btnTodoComplete);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(637, 365);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待办";
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.btnAddTodo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddTodo.Location = new System.Drawing.Point(575, 18);
            this.btnAddTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(51, 48);
            this.btnAddTodo.TabIndex = 11;
            this.btnAddTodo.Text = "✚";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.groupBox2.Controls.Add(this.btnAddRead);
            this.groupBox2.Controls.Add(this.toReadList);
            this.groupBox2.Controls.Add(this.btnCompleteRead);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Location = new System.Drawing.Point(673, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(733, 365);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待读";
            // 
            // btnAddRead
            // 
            this.btnAddRead.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.btnAddRead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddRead.Location = new System.Drawing.Point(657, 18);
            this.btnAddRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRead.Name = "btnAddRead";
            this.btnAddRead.Size = new System.Drawing.Size(51, 48);
            this.btnAddRead.TabIndex = 13;
            this.btnAddRead.Text = "✚";
            this.btnAddRead.UseVisualStyleBackColor = true;
            this.btnAddRead.Click += new System.EventHandler(this.btnAddRead_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1398, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下载文件ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 下载文件ToolStripMenuItem
            // 
            this.下载文件ToolStripMenuItem.Name = "下载文件ToolStripMenuItem";
            this.下载文件ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.下载文件ToolStripMenuItem.Text = "下载网络文件";
            this.下载文件ToolStripMenuItem.Click += new System.EventHandler(this.下载文件ToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "啊啊啊";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1398, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的工作台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoardForm_FormClosing);
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.SizeChanged += new System.EventHandler(this.DashBoardForm_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox todoList;
        private System.Windows.Forms.ListBox toReadList;
        private System.Windows.Forms.Button btnTodoComplete;
        private System.Windows.Forms.Button btnCompleteRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载文件ToolStripMenuItem;
        private System.Windows.Forms.Button btnAddRead;
        private System.Windows.Forms.NotifyIcon notifyIcon;


    }
}