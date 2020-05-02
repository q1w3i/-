namespace CSharpHomework
{
    partial class Form8
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实习地点DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第一志愿DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第二志愿DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第三志愿DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database11DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database11DataSet3 = new CSharpHomework.Database11DataSet3();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(109, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(366, 40);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "分配结果";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.实习地点DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.第一志愿DataGridViewTextBoxColumn,
            this.第二志愿DataGridViewTextBoxColumn,
            this.第三志愿DataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "表1";
            this.dataGridView1.DataSource = this.database11DataSet3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(714, 299);
            this.dataGridView1.TabIndex = 9;
            // 
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
            this.学号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            this.姓名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 实习地点DataGridViewTextBoxColumn
            // 
            this.实习地点DataGridViewTextBoxColumn.DataPropertyName = "实习地点";
            this.实习地点DataGridViewTextBoxColumn.HeaderText = "实习地点";
            this.实习地点DataGridViewTextBoxColumn.Name = "实习地点DataGridViewTextBoxColumn";
            this.实习地点DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            this.性别DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 第一志愿DataGridViewTextBoxColumn
            // 
            this.第一志愿DataGridViewTextBoxColumn.DataPropertyName = "第一志愿";
            this.第一志愿DataGridViewTextBoxColumn.HeaderText = "第一志愿";
            this.第一志愿DataGridViewTextBoxColumn.Name = "第一志愿DataGridViewTextBoxColumn";
            this.第一志愿DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 第二志愿DataGridViewTextBoxColumn
            // 
            this.第二志愿DataGridViewTextBoxColumn.DataPropertyName = "第二志愿";
            this.第二志愿DataGridViewTextBoxColumn.HeaderText = "第二志愿";
            this.第二志愿DataGridViewTextBoxColumn.Name = "第二志愿DataGridViewTextBoxColumn";
            this.第二志愿DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 第三志愿DataGridViewTextBoxColumn
            // 
            this.第三志愿DataGridViewTextBoxColumn.DataPropertyName = "第三志愿";
            this.第三志愿DataGridViewTextBoxColumn.HeaderText = "第三志愿";
            this.第三志愿DataGridViewTextBoxColumn.Name = "第三志愿DataGridViewTextBoxColumn";
            this.第三志愿DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // database11DataSet3BindingSource
            // 
            this.database11DataSet3BindingSource.DataSource = this.database11DataSet3;
            this.database11DataSet3BindingSource.Position = 0;
            // 
            // database11DataSet3
            // 
            this.database11DataSet3.DataSetName = "Database11DataSet3";
            this.database11DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = global::CSharpHomework.Properties.Resources.bd21c4f678c4e03a46d47cbcaaf9e82;
            this.pictureBox1.Location = new System.Drawing.Point(-12, -22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(763, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form8";
            this.Text = "分配结果";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实习地点DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第一志愿DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第二志愿DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第三志愿DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource database11DataSet3BindingSource;
        private Database11DataSet3 database11DataSet3;
    }
}