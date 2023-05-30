
namespace WindowsFormsApp6
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.власникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_Недвижимость_2022DataSet = new WindowsFormsApp6.БД_Недвижимость_2022DataSet();
            this.співробітникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.власникTableAdapter = new WindowsFormsApp6.БД_Недвижимость_2022DataSetTableAdapters.ВласникTableAdapter();
            this.співробітникиTableAdapter = new WindowsFormsApp6.БД_Недвижимость_2022DataSetTableAdapters.СпівробітникиTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.обєктBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.об_єктTableAdapter = new WindowsFormsApp6.БД_Недвижимость_2022DataSetTableAdapters.Об_єктTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new WindowsFormsApp6.БД_Недвижимость_2022DataSetTableAdapters.TableAdapterManager();
            this.iD_власникаComboBox = new System.Windows.Forms.ComboBox();
            this.iD_співробітникаComboBox = new System.Windows.Forms.ComboBox();
            this.обєктBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.обєктBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.власникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Недвижимость_2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.співробітникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обєктBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обєктBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обєктBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(530, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Перейти до головного меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(520, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Повернутися до об\'єктів";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID об\'єкта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Город";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Кол-во комнат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Площадь";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Этаж";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Этажность ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(289, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Описание";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(289, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID власника";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(289, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Цена $";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(289, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Статус об\'єкта";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 22);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 22);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 22);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(162, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 22);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(113, 173);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(64, 22);
            this.textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(84, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(72, 22);
            this.textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(121, 238);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(72, 22);
            this.textBox7.TabIndex = 26;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(410, 7);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(222, 46);
            this.textBox8.TabIndex = 27;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(400, 173);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(110, 22);
            this.textBox11.TabIndex = 30;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // власникBindingSource
            // 
            this.власникBindingSource.DataMember = "Власник";
            this.власникBindingSource.DataSource = this.бД_Недвижимость_2022DataSet;
            // 
            // бД_Недвижимость_2022DataSet
            // 
            this.бД_Недвижимость_2022DataSet.DataSetName = "БД_Недвижимость_2022DataSet";
            this.бД_Недвижимость_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // співробітникиBindingSource
            // 
            this.співробітникиBindingSource.DataMember = "Співробітники";
            this.співробітникиBindingSource.DataSource = this.бД_Недвижимость_2022DataSet;
            // 
            // власникTableAdapter
            // 
            this.власникTableAdapter.ClearBeforeFill = true;
            // 
            // співробітникиTableAdapter
            // 
            this.співробітникиTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.обєктBindingSource, "Статус об\'єкта", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Активний",
            "Проданий"});
            this.comboBox3.Location = new System.Drawing.Point(293, 231);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(182, 24);
            this.comboBox3.TabIndex = 33;
            // 
            // обєктBindingSource
            // 
            this.обєктBindingSource.DataMember = "Об\'єкт";
            this.обєктBindingSource.DataSource = this.бД_Недвижимость_2022DataSet;
            // 
            // об_єктTableAdapter
            // 
            this.об_єктTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(222, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 37);
            this.button3.TabIndex = 34;
            this.button3.Text = "Додати цей об\'єкт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(539, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Тип нерухомості";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(624, 196);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(144, 22);
            this.textBox9.TabIndex = 36;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp6.БД_Недвижимость_2022DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВласникTableAdapter = this.власникTableAdapter;
            this.tableAdapterManager.КлієнтTableAdapter = null;
            this.tableAdapterManager.Об_єктTableAdapter = this.об_єктTableAdapter;
            this.tableAdapterManager.СпівробітникиTableAdapter = this.співробітникиTableAdapter;
            this.tableAdapterManager.УгодаTableAdapter = null;
            // 
            // iD_власникаComboBox
            // 
            this.iD_власникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обєктBindingSource, "ID власника", true));
            this.iD_власникаComboBox.FormattingEnabled = true;
            this.iD_власникаComboBox.Items.AddRange(new object[] {
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110"});
            this.iD_власникаComboBox.Location = new System.Drawing.Point(428, 70);
            this.iD_власникаComboBox.Name = "iD_власникаComboBox";
            this.iD_власникаComboBox.Size = new System.Drawing.Size(204, 24);
            this.iD_власникаComboBox.TabIndex = 37;
            // 
            // iD_співробітникаComboBox
            // 
            this.iD_співробітникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обєктBindingSource, "ID співробітника", true));
            this.iD_співробітникаComboBox.DataSource = this.обєктBindingSource1;
            this.iD_співробітникаComboBox.DisplayMember = "ID співробітника";
            this.iD_співробітникаComboBox.FormattingEnabled = true;
            this.iD_співробітникаComboBox.Location = new System.Drawing.Point(467, 117);
            this.iD_співробітникаComboBox.Name = "iD_співробітникаComboBox";
            this.iD_співробітникаComboBox.Size = new System.Drawing.Size(178, 24);
            this.iD_співробітникаComboBox.TabIndex = 38;
            // 
            // обєктBindingSource1
            // 
            this.обєктBindingSource1.DataMember = "Об\'єкт";
            this.обєктBindingSource1.DataSource = this.бД_Недвижимость_2022DataSet;
            // 
            // обєктBindingSource2
            // 
            this.обєктBindingSource2.DataMember = "Об\'єкт";
            this.обєктBindingSource2.DataSource = this.бД_Недвижимость_2022DataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(289, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "ID співробітника";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(904, 336);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iD_співробітникаComboBox);
            this.Controls.Add(this.iD_власникаComboBox);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Додати об\'єкт";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.власникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Недвижимость_2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.співробітникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обєктBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обєктBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обєктBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox11;
        private БД_Недвижимость_2022DataSet бД_Недвижимость_2022DataSet;
        private System.Windows.Forms.BindingSource власникBindingSource;
        private БД_Недвижимость_2022DataSetTableAdapters.ВласникTableAdapter власникTableAdapter;
        private System.Windows.Forms.BindingSource співробітникиBindingSource;
        private БД_Недвижимость_2022DataSetTableAdapters.СпівробітникиTableAdapter співробітникиTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource обєктBindingSource;
        private БД_Недвижимость_2022DataSetTableAdapters.Об_єктTableAdapter об_єктTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox9;
        private БД_Недвижимость_2022DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox iD_власникаComboBox;
        private System.Windows.Forms.ComboBox iD_співробітникаComboBox;
        private System.Windows.Forms.BindingSource обєктBindingSource1;
        private System.Windows.Forms.BindingSource обєктBindingSource2;
        private System.Windows.Forms.Label label10;
    }
}