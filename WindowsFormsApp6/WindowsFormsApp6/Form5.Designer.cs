
namespace WindowsFormsApp6
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDУгодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОбєктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСпівробітникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлієнтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типНерухомістьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типУгодиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаОбєктуБезКомісіїDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаКомісіїАгентстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаУгодиОбщDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.угодаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_Недвижимость_2022DataSet = new WindowsFormsApp6.БД_Недвижимость_2022DataSet();
            this.угодаTableAdapter = new WindowsFormsApp6.БД_Недвижимость_2022DataSetTableAdapters.УгодаTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.угодаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Недвижимость_2022DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(910, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Перейти до головного меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDУгодаDataGridViewTextBoxColumn,
            this.iDОбєктаDataGridViewTextBoxColumn,
            this.iDСпівробітникаDataGridViewTextBoxColumn,
            this.iDКлієнтаDataGridViewTextBoxColumn,
            this.типНерухомістьDataGridViewTextBoxColumn,
            this.типУгодиDataGridViewTextBoxColumn,
            this.цінаОбєктуБезКомісіїDataGridViewTextBoxColumn,
            this.цінаКомісіїАгентстваDataGridViewTextBoxColumn,
            this.цінаУгодиОбщDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.угодаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // iDУгодаDataGridViewTextBoxColumn
            // 
            this.iDУгодаDataGridViewTextBoxColumn.DataPropertyName = "ID угода";
            this.iDУгодаDataGridViewTextBoxColumn.HeaderText = "ID угода";
            this.iDУгодаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDУгодаDataGridViewTextBoxColumn.Name = "iDУгодаDataGridViewTextBoxColumn";
            this.iDУгодаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDОбєктаDataGridViewTextBoxColumn
            // 
            this.iDОбєктаDataGridViewTextBoxColumn.DataPropertyName = "ID об\'єкта";
            this.iDОбєктаDataGridViewTextBoxColumn.HeaderText = "ID об\'єкта";
            this.iDОбєктаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDОбєктаDataGridViewTextBoxColumn.Name = "iDОбєктаDataGridViewTextBoxColumn";
            this.iDОбєктаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDСпівробітникаDataGridViewTextBoxColumn
            // 
            this.iDСпівробітникаDataGridViewTextBoxColumn.DataPropertyName = "ID співробітника";
            this.iDСпівробітникаDataGridViewTextBoxColumn.HeaderText = "ID співробітника";
            this.iDСпівробітникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDСпівробітникаDataGridViewTextBoxColumn.Name = "iDСпівробітникаDataGridViewTextBoxColumn";
            this.iDСпівробітникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDКлієнтаDataGridViewTextBoxColumn
            // 
            this.iDКлієнтаDataGridViewTextBoxColumn.DataPropertyName = "ID клієнта";
            this.iDКлієнтаDataGridViewTextBoxColumn.HeaderText = "ID клієнта";
            this.iDКлієнтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDКлієнтаDataGridViewTextBoxColumn.Name = "iDКлієнтаDataGridViewTextBoxColumn";
            this.iDКлієнтаDataGridViewTextBoxColumn.Width = 125;
            // 
            // типНерухомістьDataGridViewTextBoxColumn
            // 
            this.типНерухомістьDataGridViewTextBoxColumn.DataPropertyName = "Тип нерухомість";
            this.типНерухомістьDataGridViewTextBoxColumn.HeaderText = "Тип нерухомість";
            this.типНерухомістьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типНерухомістьDataGridViewTextBoxColumn.Name = "типНерухомістьDataGridViewTextBoxColumn";
            this.типНерухомістьDataGridViewTextBoxColumn.Width = 125;
            // 
            // типУгодиDataGridViewTextBoxColumn
            // 
            this.типУгодиDataGridViewTextBoxColumn.DataPropertyName = "Тип угоди";
            this.типУгодиDataGridViewTextBoxColumn.HeaderText = "Тип угоди";
            this.типУгодиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типУгодиDataGridViewTextBoxColumn.Name = "типУгодиDataGridViewTextBoxColumn";
            this.типУгодиDataGridViewTextBoxColumn.Width = 125;
            // 
            // цінаОбєктуБезКомісіїDataGridViewTextBoxColumn
            // 
            this.цінаОбєктуБезКомісіїDataGridViewTextBoxColumn.DataPropertyName = "Ціна об\'єкту без комісії $";
            this.цінаОбєктуБезКомісіїDataGridViewTextBoxColumn.HeaderText = "Ціна об\'єкту без комісії $";
            this.цінаОбєктуБезКомісіїDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.цінаОбєктуБезКомісіїDataGridViewTextBoxColumn.Name = "цінаОбєктуБезКомісіїDataGridViewTextBoxColumn";
            this.цінаОбєктуБезКомісіїDataGridViewTextBoxColumn.Width = 125;
            // 
            // цінаКомісіїАгентстваDataGridViewTextBoxColumn
            // 
            this.цінаКомісіїАгентстваDataGridViewTextBoxColumn.DataPropertyName = "Ціна комісії агентства $";
            this.цінаКомісіїАгентстваDataGridViewTextBoxColumn.HeaderText = "Ціна комісії агентства $";
            this.цінаКомісіїАгентстваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.цінаКомісіїАгентстваDataGridViewTextBoxColumn.Name = "цінаКомісіїАгентстваDataGridViewTextBoxColumn";
            this.цінаКомісіїАгентстваDataGridViewTextBoxColumn.Width = 125;
            // 
            // цінаУгодиОбщDataGridViewTextBoxColumn
            // 
            this.цінаУгодиОбщDataGridViewTextBoxColumn.DataPropertyName = "Ціна угоди общ $";
            this.цінаУгодиОбщDataGridViewTextBoxColumn.HeaderText = "Ціна угоди общ $";
            this.цінаУгодиОбщDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.цінаУгодиОбщDataGridViewTextBoxColumn.Name = "цінаУгодиОбщDataGridViewTextBoxColumn";
            this.цінаУгодиОбщDataGridViewTextBoxColumn.Width = 125;
            // 
            // угодаBindingSource
            // 
            this.угодаBindingSource.DataMember = "Угода";
            this.угодаBindingSource.DataSource = this.бД_Недвижимость_2022DataSet;
            // 
            // бД_Недвижимость_2022DataSet
            // 
            this.бД_Недвижимость_2022DataSet.DataSetName = "БД_Недвижимость_2022DataSet";
            this.бД_Недвижимость_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // угодаTableAdapter
            // 
            this.угодаTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введіть ID угоди";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(105, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Виконати запит";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(484, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Видалити угоду ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(484, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 22);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(480, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Введіть ID угоди";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(781, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(448, 37);
            this.button4.TabIndex = 13;
            this.button4.Text = "AVG Середню вартість угоди кожно співробітника ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(789, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(448, 37);
            this.button5.TabIndex = 14;
            this.button5.Text = "Отримати інформацію про угоду та ПІБ клієнта ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(431, 327);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(422, 37);
            this.button8.TabIndex = 30;
            this.button8.Text = "  Зменшити на…% комісію для обраного клієнта";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(226, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(508, 37);
            this.button6.TabIndex = 31;
            this.button6.Text = "Видалити угоду певного співробітника";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(27, 327);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(398, 37);
            this.button7.TabIndex = 32;
            this.button7.Text = " Зменшити на…% комісію для обраного клієнта";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1277, 376);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Угоди";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.угодаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Недвижимость_2022DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД_Недвижимость_2022DataSet бД_Недвижимость_2022DataSet;
        private System.Windows.Forms.BindingSource угодаBindingSource;
        private БД_Недвижимость_2022DataSetTableAdapters.УгодаTableAdapter угодаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУгодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОбєктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСпівробітникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлієнтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типНерухомістьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типУгодиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаОбєктуБезКомісіїDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаКомісіїАгентстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаУгодиОбщDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}