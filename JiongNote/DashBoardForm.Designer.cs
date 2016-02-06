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
            this.btnRead = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshTodo = new System.Windows.Forms.Button();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddToRead = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDownload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoList
            // 
            this.todoList.BackColor = System.Drawing.SystemColors.Info;
            this.todoList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.todoList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.todoList.FormattingEnabled = true;
            this.todoList.ItemHeight = 20;
            this.todoList.Location = new System.Drawing.Point(8, 43);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(519, 224);
            this.todoList.TabIndex = 0;
            this.todoList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.todoList_DrawItem);
            // 
            // toReadList
            // 
            this.toReadList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.toReadList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toReadList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.toReadList.FormattingEnabled = true;
            this.toReadList.ItemHeight = 20;
            this.toReadList.Location = new System.Drawing.Point(12, 44);
            this.toReadList.Name = "toReadList";
            this.toReadList.Size = new System.Drawing.Size(520, 224);
            this.toReadList.TabIndex = 3;
            this.toReadList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.toReadList_DrawItem);
            // 
            // btnTodoComplete
            // 
            this.btnTodoComplete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTodoComplete.Location = new System.Drawing.Point(374, 15);
            this.btnTodoComplete.Name = "btnTodoComplete";
            this.btnTodoComplete.Size = new System.Drawing.Size(30, 23);
            this.btnTodoComplete.TabIndex = 4;
            this.btnTodoComplete.Text = "✔";
            this.btnTodoComplete.UseVisualStyleBackColor = true;
            this.btnTodoComplete.Click += new System.EventHandler(this.btnTodoComplete_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead.Location = new System.Drawing.Point(460, 15);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(30, 23);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "✔";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshTodo);
            this.groupBox1.Controls.Add(this.btnAddTodo);
            this.groupBox1.Controls.Add(this.todoList);
            this.groupBox1.Controls.Add(this.btnTodoComplete);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 276);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待办";
            // 
            // btnRefreshTodo
            // 
            this.btnRefreshTodo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefreshTodo.Location = new System.Drawing.Point(497, 14);
            this.btnRefreshTodo.Name = "btnRefreshTodo";
            this.btnRefreshTodo.Size = new System.Drawing.Size(30, 23);
            this.btnRefreshTodo.TabIndex = 12;
            this.btnRefreshTodo.Text = "R";
            this.btnRefreshTodo.UseVisualStyleBackColor = true;
            this.btnRefreshTodo.Click += new System.EventHandler(this.btnRefreshTodo_Click);
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddTodo.Location = new System.Drawing.Point(461, 14);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(30, 23);
            this.btnAddTodo.TabIndex = 11;
            this.btnAddTodo.Text = "✚";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddToRead);
            this.groupBox2.Controls.Add(this.toReadList);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(587, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 276);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待读";
            // 
            // btnAddToRead
            // 
            this.btnAddToRead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddToRead.Location = new System.Drawing.Point(496, 15);
            this.btnAddToRead.Name = "btnAddToRead";
            this.btnAddToRead.Size = new System.Drawing.Size(30, 23);
            this.btnAddToRead.TabIndex = 12;
            this.btnAddToRead.Text = "✚";
            this.btnAddToRead.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 25);
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
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(456, 28);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(89, 23);
            this.btnDownload.TabIndex = 12;
            this.btnDownload.Text = "下载网络文件";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 637);
            this.Controls.Add(this.btnDownload);
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
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.Button btnAddToRead;
        private System.Windows.Forms.Button btnRefreshTodo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载文件ToolStripMenuItem;
        private System.Windows.Forms.Button btnDownload;


    }
}