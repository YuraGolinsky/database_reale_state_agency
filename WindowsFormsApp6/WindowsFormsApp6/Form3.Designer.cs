
namespace WindowsFormsApp6
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idСпівробітникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пІБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посадаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПрийомуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗвільненняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.співробітникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_Недвижимость_2022DataSet = new WindowsFormsApp6.БД_Недвижимость_2022DataSet();
            this.співробітникиTableAdapter = new WindowsFormsApp6.БД_Недвижимость_2022DataSetTableAdapters.СпівробітникиTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.співробітникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Недвижимость_2022DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(865, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Перейти до головного меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idСпівробітникаDataGridViewTextBoxColumn,
            this.пІБDataGridViewTextBoxColumn,
            this.посадаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.датаПрийомуDataGridViewTextBoxColumn,
            this.датаЗвільненняDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.співробітникиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idСпівробітникаDataGridViewTextBoxColumn
            // 
            this.idСпівробітникаDataGridViewTextBoxColumn.DataPropertyName = "id Співробітника";
            this.idСпівробітникаDataGridViewTextBoxColumn.HeaderText = "id Співробітника";
            this.idСпівробітникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idСпівробітникаDataGridViewTextBoxColumn.Name = "idСпівробітникаDataGridViewTextBoxColumn";
            this.idСпівробітникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // пІБDataGridViewTextBoxColumn
            // 
            this.пІБDataGridViewTextBoxColumn.DataPropertyName = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.пІБDataGridViewTextBoxColumn.Name = "пІБDataGridViewTextBoxColumn";
            this.пІБDataGridViewTextBoxColumn.Width = 125;
            // 
            // посадаDataGridViewTextBoxColumn
            // 
            this.посадаDataGridViewTextBoxColumn.DataPropertyName = "Посада";
            this.посадаDataGridViewTextBoxColumn.HeaderText = "Посада";
            this.посадаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.посадаDataGridViewTextBoxColumn.Name = "посадаDataGridViewTextBoxColumn";
            this.посадаDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаПрийомуDataGridViewTextBoxColumn
            // 
            this.датаПрийомуDataGridViewTextBoxColumn.DataPropertyName = "Дата прийому";
            this.датаПрийомуDataGridViewTextBoxColumn.HeaderText = "Дата прийому";
            this.датаПрийомуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПрийомуDataGridViewTextBoxColumn.Name = "датаПрийомуDataGridViewTextBoxColumn";
            this.датаПрийомуDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаЗвільненняDataGridViewTextBoxColumn
            // 
            this.датаЗвільненняDataGridViewTextBoxColumn.DataPropertyName = "Дата звільнення";
            this.датаЗвільненняDataGridViewTextBoxColumn.HeaderText = "Дата звільнення";
            this.датаЗвільненняDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЗвільненняDataGridViewTextBoxColumn.Name = "датаЗвільненняDataGridViewTextBoxColumn";
            this.датаЗвільненняDataGridViewTextBoxColumn.Width = 125;
            // 
            // співробітникиBindingSource
            // 
            this.співробітникиBindingSource.DataMember = "Співробітники";
            this.співробітникиBindingSource.DataSource = this.бД_Недвижимость_2022DataSet;
            // 
            // бД_Недвижимость_2022DataSet
            // 
            this.бД_Недвижимость_2022DataSet.DataSetName = "БД_Недвижимость_2022DataSet";
            this.бД_Недвижимость_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // співробітникиTableAdapter
            // 
            this.співробітникиTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(910, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(876, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введіть ID співробітника";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(865, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Видалити співробітника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1177, 231);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Співробітники";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.співробітникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Недвижимость_2022DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД_Недвижимость_2022DataSet бД_Недвижимость_2022DataSet;
        private System.Windows.Forms.BindingSource співробітникиBindingSource;
        private БД_Недвижимость_2022DataSetTableAdapters.СпівробітникиTableAdapter співробітникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСпівробітникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn посадаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПрийомуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗвільненняDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}