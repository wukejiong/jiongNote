using JiongNote.Model;
using JiongNote.Repository;
using System;
using System.Collections;
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
    public partial class AddToReadForm : Form
    {
        public AddToReadForm()
        {
            InitializeComponent();
            initTypes();
        }

        public AddToReadForm(NoteModel model)
        {
            InitializeComponent();
            initTypes();

            //show detail
            this.Text = "查看内容";
            btnAdd.Visible = false;
            txtTitle.Text = model.Title;
            txtContent.Text = model.Content;
            txtKeyword.Text = model.Keywords;
            txtType.SelectedValue = model.Type;
        }

        List<NoteTypeModel> noteTypes;
        private void initTypes()
        {
            ArrayList data = new ArrayList();
            noteTypes = NoteDao.GetTypes().OrderBy(p => p.Id).ToList();
            foreach (var levelOne in noteTypes.Where(p => p.ParentId == 0).ToList())
            {
                data.Add(new DictionaryEntry(levelOne.Id, levelOne.Name));
                foreach (var levelTwo in noteTypes.Where(p => p.ParentId == levelOne.Id).ToList())
                {
                    data.Add(new DictionaryEntry(levelTwo.Id, "|--" + levelTwo.Name));
                }
            }
            txtType.DataSource = data;
            txtType.DisplayMember = "Value";
            txtType.ValueMember = "Key";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text;
            var keyword = txtKeyword.Text;
            var content = txtContent.Text;
            var type = txtType.SelectedValue;
            if (title == "" || keyword == "" || content == "" || txtType.SelectedIndex < 0)
            {
                MessageBox.Show("请填写完整，全部为必填项");
                return;
            }

            var model = new NoteModel()
            {
                Title = title,
                Keywords = keyword,
                Type = int.Parse(type.ToString()),
                Content = content,
                CreateTime = DateTime.Now
            };
            if (NoteDao.Add(model))
            {
                MessageBox.Show("添加成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
