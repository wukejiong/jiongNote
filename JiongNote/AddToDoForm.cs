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
            init();
        }
        
        public AddToDoForm(ToDoModel model)
        {
            InitializeComponent();
            init();
            //show detial
            txtContent.Text = model.Content;
            dateTimePicker.Text=model.Deadline.ToString("yyyy-MM-dd");
            txtTime.Text = model.Deadline.ToString("HH:mm");
            this.Text = "查看内容";
            btnSave.Visible = false;

        }

        private void init() {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if( dateTimePicker.Text=="" || txtContent.Text==""){
                MessageBox.Show("请输入时间和内容");
                return;
            }
            var model  =new ToDoModel() { 
                Content=txtContent.Text,
                Deadline =DateTime.Parse(dateTimePicker.Value.ToString("yyyy-MM-dd ")+txtTime.Text+":00"),
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
