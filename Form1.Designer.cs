namespace editor.ru
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.query = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queryPanel1 = new System.Windows.Forms.Panel();
            this.filter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.queryPanel2 = new System.Windows.Forms.Panel();
            this.field = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.queryPanel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.queryPanel1.SuspendLayout();
            this.queryPanel2.SuspendLayout();
            this.queryPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // query
            // 
            this.query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.query.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.query.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.query.FormattingEnabled = true;
            this.query.Items.AddRange(new object[] {
            "Сведения о программах по компиллируемости",
            "Количество программ, использущихся в определенной области",
            "Сведенияо самой новой версии программы"});
            this.query.Location = new System.Drawing.Point(94, 49);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(694, 31);
            this.query.TabIndex = 0;
            this.query.SelectionChangeCommitted += new System.EventHandler(this.query_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подборка программ редакторов кода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Запрос:";
            // 
            // queryPanel1
            // 
            this.queryPanel1.Controls.Add(this.filter);
            this.queryPanel1.Controls.Add(this.label3);
            this.queryPanel1.Location = new System.Drawing.Point(12, 356);
            this.queryPanel1.Name = "queryPanel1";
            this.queryPanel1.Size = new System.Drawing.Size(620, 43);
            this.queryPanel1.TabIndex = 3;
            // 
            // filter
            // 
            this.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filter.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "Компилируемые",
            "Некомпилируемые"});
            this.filter.Location = new System.Drawing.Point(90, 6);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(209, 31);
            this.filter.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фильтр:";
            // 
            // queryPanel2
            // 
            this.queryPanel2.Controls.Add(this.field);
            this.queryPanel2.Controls.Add(this.label4);
            this.queryPanel2.Location = new System.Drawing.Point(4, 86);
            this.queryPanel2.Name = "queryPanel2";
            this.queryPanel2.Size = new System.Drawing.Size(628, 43);
            this.queryPanel2.TabIndex = 4;
            this.queryPanel2.Visible = false;
            // 
            // field
            // 
            this.field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.field.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.field.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.field.FormattingEnabled = true;
            this.field.Items.AddRange(new object[] {
            "Компилируемые",
            "Некомпилируемые"});
            this.field.Location = new System.Drawing.Point(94, 6);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(327, 31);
            this.field.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Область:";
            // 
            // queryPanel3
            // 
            this.queryPanel3.Controls.Add(this.dateTimePicker1);
            this.queryPanel3.Controls.Add(this.label5);
            this.queryPanel3.Location = new System.Drawing.Point(4, 135);
            this.queryPanel3.Name = "queryPanel3";
            this.queryPanel3.Size = new System.Drawing.Size(628, 43);
            this.queryPanel3.TabIndex = 5;
            this.queryPanel3.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 10);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дата:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryPanel3);
            this.Controls.Add(this.queryPanel2);
            this.Controls.Add(this.queryPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.query);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.queryPanel1.ResumeLayout(false);
            this.queryPanel1.PerformLayout();
            this.queryPanel2.ResumeLayout(false);
            this.queryPanel2.PerformLayout();
            this.queryPanel3.ResumeLayout(false);
            this.queryPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox query;
        private Label label1;
        private Label label2;
        private Panel queryPanel1;
        private ComboBox filter;
        private Label label3;
        private Panel queryPanel2;
        private ComboBox field;
        private Label label4;
        private Panel queryPanel3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}