using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CodeGenerator.Generator;

namespace CodeGenerator
{
    public partial class FormMain : Form
    {
        private SQLiteGenerator _generator;
        public FormMain()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "表名";
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "是否生成" });
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFileName.Text) || !File.Exists(textBoxFileName.Text))
                return;

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
                return;
            var directory = dialog.SelectedPath;

            for (var i = 0; i < _generator.DbNames.Length; i++)
            {
                var name = _generator.DbNames[i];
                if(!(dataGridView1.Rows[i].Cells[1] is DataGridViewCheckBoxCell checkBox) || !checkBox.Selected) continue;
                if (checkBoxModel.Checked)
                    _generator.CreateModel(name, directory, textBoxNamespace.Text);
                if (checkBoxDAL.Checked)
                    _generator.CreateDAL(name, directory, textBoxNamespace.Text);
                if (checkBoxBLL.Checked)
                    _generator.CreateBLL(name, directory, textBoxNamespace.Text);
            }

            MessageBox.Show($@"代码生成成功, 已经保存到{directory}文件夹中");
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            textBoxFileName.Text = openFileDialog.FileName;
            _generator = new SQLiteGenerator(textBoxFileName.Text);
            
            foreach (var name in _generator.DbNames)
            {
                var index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = name;
            }
        }
    }
}
