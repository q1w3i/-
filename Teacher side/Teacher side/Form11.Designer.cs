namespace Teacher_side
{
    partial class Form11
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
            this.医院DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.招收人数总DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.招收人数男DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.招收人数女DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database11DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database11DataSet1 = new Teacher_side.Database11DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.医院DataGridViewTextBoxColumn,
            this.招收人数总DataGridViewTextBoxColumn,
            this.招收人数男DataGridViewTextBoxColumn,
            this.招收人数女DataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "表4";
            this.dataGridView1.DataSource = this.database11DataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(681, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // 医院DataGridViewTextBoxColumn
            // 
            this.医院DataGridViewTextBoxColumn.DataPropertyName = "医院";
            this.医院DataGridViewTextBoxColumn.HeaderText = "医院";
            this.医院DataGridViewTextBoxColumn.Name = "医院DataGridViewTextBoxColumn";
            this.医院DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 招收人数总DataGridViewTextBoxColumn
            // 
            this.招收人数总DataGridViewTextBoxColumn.DataPropertyName = "招收人数（总）";
            this.招收人数总DataGridViewTextBoxColumn.HeaderText = "招收人数（总）";
            this.招收人数总DataGridViewTextBoxColumn.Name = "招收人数总DataGridViewTextBoxColumn";
            this.招收人数总DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 招收人数男DataGridViewTextBoxColumn
            // 
            this.招收人数男DataGridViewTextBoxColumn.DataPropertyName = "招收人数（男）";
            this.招收人数男DataGridViewTextBoxColumn.HeaderText = "招收人数（男）";
            this.招收人数男DataGridViewTextBoxColumn.Name = "招收人数男DataGridViewTextBoxColumn";
            this.招收人数男DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 招收人数女DataGridViewTextBoxColumn
            // 
            this.招收人数女DataGridViewTextBoxColumn.DataPropertyName = "招收人数（女）";
            this.招收人数女DataGridViewTextBoxColumn.HeaderText = "招收人数（女）";
            this.招收人数女DataGridViewTextBoxColumn.Name = "招收人数女DataGridViewTextBoxColumn";
            this.招收人数女DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // database11DataSet1BindingSource
            // 
            this.database11DataSet1BindingSource.DataSource = this.database11DataSet1;
            this.database11DataSet1BindingSource.Position = 0;
            // 
            // database11DataSet1
            // 
            this.database11DataSet1.DataSetName = "Database11DataSet1";
            this.database11DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("腾祥凌黑简", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "医院分配情况";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(564, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "更新数据";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form11";
            this.Text = "医院分配情况";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 医院DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 招收人数总DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 招收人数男DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 招收人数女DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource database11DataSet1BindingSource;
        private Database11DataSet1 database11DataSet1;
    }
}