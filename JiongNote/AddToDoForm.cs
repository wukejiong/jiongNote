using JiongNote.Model;
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
    public partial class AddToDoForm : Form
    {
        public AddToDoForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if( dateTimePicker.Text=="" || txtContent.Text==""){
                MessageBox.Show("请输入时间和内容");
                return;
            }
            var model  =new ToDoModel() { 
                Content=txtContent.Text,
                Deadline = dateTimePicker.Value,
            };
            if (TodoDao.Add(model))
            {
              MessageBox.Show("添加成功");
              this.DialogResult = DialogResult.OK;
              this.Close();
          }  
        }
    }
}
