namespace Teacher_side
{
    partial class Form10
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("腾祥凌黑简", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "自动分配";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(727, 243);
            this.dataGridView1.TabIndex = 1;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("腾祥凌黑简", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(229, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "一键分配";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("腾祥凌黑简", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(402, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "二次分配";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("腾祥凌黑简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(571, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "医院分配情况";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(45, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "输出为Excel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 402);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "自动分配";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}