namespace SQLiteTest_Form
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SELECT = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.INSERT = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.column1 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.app = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.coordinate = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Place = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Gander = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SELECT
            // 
            this.SELECT.Location = new System.Drawing.Point(12, 370);
            this.SELECT.Name = "SELECT";
            this.SELECT.Size = new System.Drawing.Size(108, 78);
            this.SELECT.TabIndex = 0;
            this.SELECT.Text = "SELECT";
            this.SELECT.UseVisualStyleBackColor = true;
            this.SELECT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(526, 352);
            this.textBox2.TabIndex = 2;
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(136, 370);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(108, 78);
            this.INSERT.TabIndex = 3;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.button2_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(263, 370);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(108, 78);
            this.UPDATE.TabIndex = 4;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.button1_Click);
            // 
            // column1
            // 
            this.column1.Location = new System.Drawing.Point(642, 33);
            this.column1.Name = "column1";
            this.column1.Size = new System.Drawing.Size(100, 22);
            this.column1.TabIndex = 5;
            this.column1.TextChanged += new System.EventHandler(this.column1_TextChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(642, 87);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 6;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(642, 115);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 7;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // app
            // 
            this.app.Location = new System.Drawing.Point(642, 143);
            this.app.Name = "app";
            this.app.Size = new System.Drawing.Size(100, 22);
            this.app.TabIndex = 8;
            this.app.TextChanged += new System.EventHandler(this.app_TextChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(642, 171);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 22);
            this.date.TabIndex = 9;
            this.date.TextChanged += new System.EventHandler(this.date_TextChanged);
            // 
            // coordinate
            // 
            this.coordinate.Location = new System.Drawing.Point(642, 199);
            this.coordinate.Name = "coordinate";
            this.coordinate.Size = new System.Drawing.Size(100, 22);
            this.coordinate.TabIndex = 10;
            this.coordinate.TextChanged += new System.EventHandler(this.coordinate_TextChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(616, 370);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(126, 82);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(394, 370);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(108, 78);
            this.DELETE.TabIndex = 12;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "App";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date";
            // 
            // Place
            // 
            this.Place.Location = new System.Drawing.Point(642, 228);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(100, 22);
            this.Place.TabIndex = 19;
            this.Place.TextChanged += new System.EventHandler(this.Place_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Place";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Coordinate";
            // 
            // Gander
            // 
            this.Gander.Location = new System.Drawing.Point(642, 256);
            this.Gander.Name = "Gander";
            this.Gander.Size = new System.Drawing.Size(100, 22);
            this.Gander.TabIndex = 22;
            this.Gander.TextChanged += new System.EventHandler(this.Gander_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Column";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(754, 464);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Gander);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.coordinate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.app);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.column1);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SELECT);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SELECT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.TextBox column1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox app;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox coordinate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Place;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Gander;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

