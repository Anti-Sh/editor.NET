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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.query = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queryPanel1 = new System.Windows.Forms.Panel();
            this.filter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.queryPanel2 = new System.Windows.Forms.Panel();
            this.field = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.result3 = new System.Windows.Forms.Panel();
            this.dateOut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.queryPanel3 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.release = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result2 = new System.Windows.Forms.Panel();
            this.resultOutput2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.queryPanel1.SuspendLayout();
            this.queryPanel2.SuspendLayout();
            this.result3.SuspendLayout();
            this.queryPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.result2.SuspendLayout();
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
            "Сведения о самой новой версии программы"});
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
            this.queryPanel1.Location = new System.Drawing.Point(773, 181);
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
            "Некомпилируемые",
            "Компилируемые"});
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
            this.queryPanel2.Size = new System.Drawing.Size(437, 43);
            this.queryPanel2.TabIndex = 4;
            this.queryPanel2.Visible = false;
            // 
            // field
            // 
            this.field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.field.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.field.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.field.FormattingEnabled = true;
            this.field.Location = new System.Drawing.Point(100, 6);
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
            // result3
            // 
            this.result3.Controls.Add(this.dateOut);
            this.result3.Controls.Add(this.label7);
            this.result3.Location = new System.Drawing.Point(313, 139);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(266, 43);
            this.result3.TabIndex = 8;
            this.result3.Visible = false;
            // 
            // dateOut
            // 
            this.dateOut.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOut.Location = new System.Drawing.Point(160, 5);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(103, 31);
            this.dateOut.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(-1, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Самая новая от:";
            // 
            // queryPanel3
            // 
            this.queryPanel3.Controls.Add(this.date);
            this.queryPanel3.Controls.Add(this.label5);
            this.queryPanel3.Location = new System.Drawing.Point(773, 132);
            this.queryPanel3.Name = "queryPanel3";
            this.queryPanel3.Size = new System.Drawing.Size(628, 43);
            this.queryPanel3.TabIndex = 5;
            this.queryPanel3.Visible = false;
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(93, 5);
            this.date.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(195, 31);
            this.date.TabIndex = 1;
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
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submit.Location = new System.Drawing.Point(660, 90);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(128, 36);
            this.submit.TabIndex = 6;
            this.submit.Text = "Найти";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // table
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.maker,
            this.dataGridViewTextBoxColumn1,
            this.mark,
            this.rating,
            this.release,
            this.version});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle2;
            this.table.Location = new System.Drawing.Point(773, 260);
            this.table.Name = "table";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table.RowTemplate.Height = 25;
            this.table.Size = new System.Drawing.Size(766, 309);
            this.table.TabIndex = 7;
            this.table.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.Width = 103;
            // 
            // maker
            // 
            this.maker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maker.HeaderText = "Издатель";
            this.maker.Name = "maker";
            this.maker.Width = 102;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Область";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 94;
            // 
            // mark
            // 
            this.mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mark.HeaderText = "Наша оценка";
            this.mark.Name = "mark";
            this.mark.Width = 61;
            // 
            // rating
            // 
            this.rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rating.HeaderText = "Рейтинг";
            this.rating.Name = "rating";
            this.rating.Width = 74;
            // 
            // release
            // 
            this.release.HeaderText = "Год выпуска";
            this.release.Name = "release";
            this.release.Width = 124;
            // 
            // version
            // 
            this.version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.version.HeaderText = "Версия";
            this.version.Name = "version";
            this.version.Width = 85;
            // 
            // result2
            // 
            this.result2.Controls.Add(this.resultOutput2);
            this.result2.Controls.Add(this.label6);
            this.result2.Location = new System.Drawing.Point(5, 130);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(247, 43);
            this.result2.TabIndex = 5;
            this.result2.Visible = false;
            // 
            // resultOutput2
            // 
            this.resultOutput2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultOutput2.Location = new System.Drawing.Point(136, 6);
            this.resultOutput2.Name = "resultOutput2";
            this.resultOutput2.Size = new System.Drawing.Size(91, 31);
            this.resultOutput2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Количество:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.table);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.queryPanel3);
            this.Controls.Add(this.queryPanel2);
            this.Controls.Add(this.queryPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.query);
            this.Name = "Form1";
            this.Text = "Редактор.РУ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.queryPanel1.ResumeLayout(false);
            this.queryPanel1.PerformLayout();
            this.queryPanel2.ResumeLayout(false);
            this.queryPanel2.PerformLayout();
            this.result3.ResumeLayout(false);
            this.result3.PerformLayout();
            this.queryPanel3.ResumeLayout(false);
            this.queryPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.result2.ResumeLayout(false);
            this.result2.PerformLayout();
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
        private DateTimePicker date;
        private Label label5;
        private Button submit;
        private DataGridView table;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn maker;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn mark;
        private DataGridViewTextBoxColumn rating;
        private DataGridViewTextBoxColumn release;
        private DataGridViewTextBoxColumn version;
        private Panel result2;
        private Label label6;
        private TextBox resultOutput2;
        private Panel result3;
        private Label label7;
        private TextBox dateOut;
    }
}