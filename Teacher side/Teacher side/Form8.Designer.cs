namespace Teacher_side
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实习地点DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第一志愿DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第二志愿DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第三志愿DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.综合评分DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.四级DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.database11DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database11DataSet = new Teacher_side.Database11DataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.实习地点DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.第一志愿DataGridViewTextBoxColumn,
            this.第二志愿DataGridViewTextBoxColumn,
            this.第三志愿DataGridViewTextBoxColumn,
            this.综合评分DataGridViewTextBoxColumn,
            this.四级DataGridViewCheckBoxColumn});
            this.dataGridView1.DataMember = "表2";
            this.dataGridView1.DataSource = this.database11DataSetBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.Location = new System.Drawing.Point(11, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(618, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 综合评分DataGridViewTextBoxColumn
            // 
            this.综合评分DataGridViewTextBoxColumn.DataPropertyName = "综合评分";
            this.综合评分DataGridViewTextBoxColumn.HeaderText = "综合评分";
            this.综合评分DataGridViewTextBoxColumn.Name = "综合评分DataGridViewTextBoxColumn";
            this.综合评分DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 四级DataGridViewCheckBoxColumn
            // 
            this.四级DataGridViewCheckBoxColumn.DataPropertyName = "四级";
            this.四级DataGridViewCheckBoxColumn.HeaderText = "四级";
            this.四级DataGridViewCheckBoxColumn.Name = "四级DataGridViewCheckBoxColumn";
            this.四级DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // database11DataSetBindingSource
            // 
            this.database11DataSetBindingSource.DataSource = this.database11DataSet;
            this.database11DataSetBindingSource.Position = 0;
            // 
            // database11DataSet
            // 
            this.database11DataSet.DataSetName = "Database11DataSet";
            this.database11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("腾祥凌黑简", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(280, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "学生姓名";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("腾祥凌黑简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(533, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("腾祥凌黑简", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "学生信息查询";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(641, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "学生信息查询";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实习地点DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第一志愿DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第二志愿DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第三志愿DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 综合评分DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 四级DataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource database11DataSetBindingSource;
        private Database11DataSet database11DataSet;
    }
}