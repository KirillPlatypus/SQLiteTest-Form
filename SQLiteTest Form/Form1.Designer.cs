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
            this.button1 = new System.Windows.Forms.Button();
            this.column1 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.app = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.coordinate = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SELECT
            // 
            this.SELECT.Location = new System.Drawing.Point(12, 370);
            this.SELECT.Name = "SELECT";
            this.SELECT.Size = new System.Drawing.Size(144, 79);
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
            this.INSERT.Location = new System.Drawing.Point(183, 370);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(144, 80);
            this.INSERT.TabIndex = 3;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // column1
            // 
            this.column1.Location = new System.Drawing.Point(616, 32);
            this.column1.Name = "column1";
            this.column1.Size = new System.Drawing.Size(100, 22);
            this.column1.TabIndex = 5;
            this.column1.TextChanged += new System.EventHandler(this.column1_TextChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(616, 82);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 6;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(616, 111);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 7;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // app
            // 
            this.app.Location = new System.Drawing.Point(616, 140);
            this.app.Name = "app";
            this.app.Size = new System.Drawing.Size(100, 22);
            this.app.TabIndex = 8;
            this.app.TextChanged += new System.EventHandler(this.app_TextChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(616, 168);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 22);
            this.date.TabIndex = 9;
            this.date.TextChanged += new System.EventHandler(this.date_TextChanged);
            // 
            // coordinate
            // 
            this.coordinate.Location = new System.Drawing.Point(616, 197);
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(754, 464);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.coordinate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.app);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.column1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox column1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox app;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox coordinate;
        private System.Windows.Forms.Button Clear;
    }
}

