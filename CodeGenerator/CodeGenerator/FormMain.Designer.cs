namespace CodeGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.checkBoxModel = new System.Windows.Forms.CheckBox();
            this.checkBoxDAL = new System.Windows.Forms.CheckBox();
            this.checkBoxBLL = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNamespace = new System.Windows.Forms.TextBox();
            this.labelNamespace = new System.Windows.Forms.Label();
            this.comboBoxDbType = new System.Windows.Forms.ComboBox();
            this.labelDbType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("宋体", 9F);
            this.buttonConnect.Location = new System.Drawing.Point(119, 311);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "生成";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(220, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "浏览";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(33, 12);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(181, 21);
            this.textBoxFileName.TabIndex = 2;
            // 
            // checkBoxModel
            // 
            this.checkBoxModel.AutoSize = true;
            this.checkBoxModel.Checked = true;
            this.checkBoxModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxModel.Location = new System.Drawing.Point(65, 99);
            this.checkBoxModel.Name = "checkBoxModel";
            this.checkBoxModel.Size = new System.Drawing.Size(54, 16);
            this.checkBoxModel.TabIndex = 3;
            this.checkBoxModel.Text = "Model";
            this.checkBoxModel.UseVisualStyleBackColor = true;
            // 
            // checkBoxDAL
            // 
            this.checkBoxDAL.AutoSize = true;
            this.checkBoxDAL.Checked = true;
            this.checkBoxDAL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDAL.Location = new System.Drawing.Point(143, 99);
            this.checkBoxDAL.Name = "checkBoxDAL";
            this.checkBoxDAL.Size = new System.Drawing.Size(42, 16);
            this.checkBoxDAL.TabIndex = 4;
            this.checkBoxDAL.Text = "DAL";
            this.checkBoxDAL.UseVisualStyleBackColor = true;
            // 
            // checkBoxBLL
            // 
            this.checkBoxBLL.AutoSize = true;
            this.checkBoxBLL.Checked = true;
            this.checkBoxBLL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBLL.Location = new System.Drawing.Point(212, 99);
            this.checkBoxBLL.Name = "checkBoxBLL";
            this.checkBoxBLL.Size = new System.Drawing.Size(42, 16);
            this.checkBoxBLL.TabIndex = 4;
            this.checkBoxBLL.Text = "BLL";
            this.checkBoxBLL.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(290, 144);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBoxNamespace
            // 
            this.textBoxNamespace.Location = new System.Drawing.Point(109, 133);
            this.textBoxNamespace.Name = "textBoxNamespace";
            this.textBoxNamespace.Size = new System.Drawing.Size(164, 21);
            this.textBoxNamespace.TabIndex = 6;
            this.textBoxNamespace.Text = "VA.Common";
            // 
            // labelNamespace
            // 
            this.labelNamespace.AutoSize = true;
            this.labelNamespace.Location = new System.Drawing.Point(50, 136);
            this.labelNamespace.Name = "labelNamespace";
            this.labelNamespace.Size = new System.Drawing.Size(53, 12);
            this.labelNamespace.TabIndex = 7;
            this.labelNamespace.Text = "命名空间";
            // 
            // comboBoxDbType
            // 
            this.comboBoxDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDbType.FormattingEnabled = true;
            this.comboBoxDbType.Items.AddRange(new object[] {
            "MySQL",
            "SQLite"});
            this.comboBoxDbType.Location = new System.Drawing.Point(138, 58);
            this.comboBoxDbType.Name = "comboBoxDbType";
            this.comboBoxDbType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDbType.TabIndex = 8;
            // 
            // labelDbType
            // 
            this.labelDbType.AutoSize = true;
            this.labelDbType.Location = new System.Drawing.Point(67, 62);
            this.labelDbType.Name = "labelDbType";
            this.labelDbType.Size = new System.Drawing.Size(65, 12);
            this.labelDbType.TabIndex = 9;
            this.labelDbType.Text = "数据库类型";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 343);
            this.Controls.Add(this.labelDbType);
            this.Controls.Add(this.comboBoxDbType);
            this.Controls.Add(this.labelNamespace);
            this.Controls.Add(this.textBoxNamespace);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxBLL);
            this.Controls.Add(this.checkBoxDAL);
            this.Controls.Add(this.checkBoxModel);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "SQLite代码生成器";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.CheckBox checkBoxModel;
        private System.Windows.Forms.CheckBox checkBoxDAL;
        private System.Windows.Forms.CheckBox checkBoxBLL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNamespace;
        private System.Windows.Forms.Label labelNamespace;
        private System.Windows.Forms.ComboBox comboBoxDbType;
        private System.Windows.Forms.Label labelDbType;
    }
}

