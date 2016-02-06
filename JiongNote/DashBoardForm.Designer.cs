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
            this.todoList = new System.Windows.Forms.ListBox();
            this.toReadList = new System.Windows.Forms.ListBox();
            this.btnTodoComplete = new System.Windows.Forms.Button();
            this.btnCompleteRead = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshTodo = new System.Windows.Forms.Button();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddRead = new System.Windows.Forms.Button();
            this.btnGoRead = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.todoList.ItemHeight = 20;
            this.todoList.Location = new System.Drawing.Point(10, 59);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(519, 222);
            this.todoList.TabIndex = 0;
            // 
            // toReadList
            // 
            this.toReadList.BackColor = System.Drawing.Color.PapayaWhip;
            this.toReadList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toReadList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toReadList.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.toReadList.FormattingEnabled = true;
            this.toReadList.ItemHeight = 20;
            this.toReadList.Location = new System.Drawing.Point(12, 59);
            this.toReadList.Name = "toReadList";
            this.toReadList.Size = new System.Drawing.Size(520, 222);
            this.toReadList.TabIndex = 3;
            // 
            // btnTodoComplete
            // 
            this.btnTodoComplete.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.btnTodoComplete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTodoComplete.Location = new System.Drawing.Point(374, 15);
            this.btnTodoComplete.Name = "btnTodoComplete";
            this.btnTodoComplete.Size = new System.Drawing.Size(38, 38);
            this.btnTodoComplete.TabIndex = 4;
            this.btnTodoComplete.Text = "✔";
            this.btnTodoComplete.UseVisualStyleBackColor = true;
            this.btnTodoComplete.Click += new System.EventHandler(this.btnTodoComplete_Click);
            // 
            // btnCompleteRead
            // 
            this.btnCompleteRead.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.btnCompleteRead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompleteRead.Location = new System.Drawing.Point(361, 15);
            this.btnCompleteRead.Name = "btnCompleteRead";
            this.btnCompleteRead.Size = new System.Drawing.Size(38, 38);
            this.btnCompleteRead.TabIndex = 6;
            this.btnCompleteRead.Text = "✔";
            this.btnCompleteRead.UseVisualStyleBackColor = true;
            this.btnCompleteRead.Click += new System.EventHandler(this.btnCompleteRead_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.groupBox1.Controls.Add(this.btnRefreshTodo);
            this.groupBox1.Controls.Add(this.btnAddTodo);
            this.groupBox1.Controls.Add(this.todoList);
            this.groupBox1.Controls.Add(this.btnTodoComplete);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 292);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待办";
            // 
            // btnRefreshTodo
            // 
            this.btnRefreshTodo.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.btnRefreshTodo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefreshTodo.Location = new System.Drawing.Point(488, 14);
            this.btnRefreshTodo.Name = "btnRefreshTodo";
            this.btnRefreshTodo.Size = new System.Drawing.Size(38, 39);
            this.btnRefreshTodo.TabIndex = 12;
            this.btnRefreshTodo.Text = "R";
            this.btnRefreshTodo.UseVisualStyleBackColor = true;
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.btnAddTodo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddTodo.Location = new System.Drawing.Point(435, 15);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(38, 38);
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
            this.groupBox2.Controls.Add(this.btnGoRead);
            this.groupBox2.Controls.Add(this.toReadList);
            this.groupBox2.Controls.Add(this.btnCompleteRead);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Location = new System.Drawing.Point(587, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 292);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待读";
            // 
            // btnAddRead
            // 
            this.btnAddRead.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.btnAddRead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddRead.Location = new System.Drawing.Point(444, 15);
            this.btnAddRead.Name = "btnAddRead";
            this.btnAddRead.Size = new System.Drawing.Size(38, 38);
            this.btnAddRead.TabIndex = 13;
            this.btnAddRead.Text = "✚";
            this.btnAddRead.UseVisualStyleBackColor = true;
            this.btnAddRead.Click += new System.EventHandler(this.btnAddRead_Click);
            // 
            // btnGoRead
            // 
            this.btnGoRead.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.btnGoRead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoRead.Location = new System.Drawing.Point(493, 15);
            this.btnGoRead.Name = "btnGoRead";
            this.btnGoRead.Size = new System.Drawing.Size(38, 38);
            this.btnGoRead.TabIndex = 12;
            this.btnGoRead.Text = "▶";
            this.btnGoRead.UseVisualStyleBackColor = true;
            this.btnGoRead.Click += new System.EventHandler(this.btnGoRead_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下载文件ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 下载文件ToolStripMenuItem
            // 
            this.下载文件ToolStripMenuItem.Name = "下载文件ToolStripMenuItem";
            this.下载文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.下载文件ToolStripMenuItem.Text = "下载网络文件";
            this.下载文件ToolStripMenuItem.Click += new System.EventHandler(this.下载文件ToolStripMenuItem_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JiongNote.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 707);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的工作台";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
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
        private System.Windows.Forms.Button btnGoRead;
        private System.Windows.Forms.Button btnRefreshTodo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载文件ToolStripMenuItem;
        private System.Windows.Forms.Button btnAddRead;


    }
}