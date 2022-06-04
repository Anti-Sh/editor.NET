namespace editor.ru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            query.SelectedIndex = 0;
            queryPanel1.Location = new Point(4, 86);
            queryPanel2.Location = new Point(4, 86);
            queryPanel3.Location = new Point(4, 86);
            table.Location = new Point(4, 137);
            result2.Location = new Point(4, 130);
            result3.Location = new Point(313, 86);
            table.Visible = false;
            SQL.OpenConnection();

            var items = SQL.ExecuteQuery($"SELECT * FROM `fields`", 2);
            foreach(var item in items)
            {
                field.Items.Add(item[1]);
            }

            SQL.CloseConnection();
            field.SelectedIndex = 0;
            filter.SelectedIndex = 0;
            date.Format = DateTimePickerFormat.Short;
        }

        private void query_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (query.SelectedIndex)
            {
                case 0:
                    queryPanel1.Visible = true;
                    queryPanel2.Visible = false;
                    queryPanel3.Visible = false;
                    break;
                case 1:
                    queryPanel1.Visible = false;
                    queryPanel2.Visible = true;
                    queryPanel3.Visible = false;
                    break;
                case 2:
                    queryPanel1.Visible = false;
                    queryPanel2.Visible = false;
                    queryPanel3.Visible = true;
                    break;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            switch (query.SelectedIndex)
            {
                case 0:
                    result2.Visible = false;
                    result3.Visible = false;
                    SQL.OpenConnection();

                    var result = SQL.ExecuteQuery($"SELECT e.`editor_name`, m.`maker_name`, f.`field_name`, e.`our_mark`, e.`user_rating`, e.`release_year`, e.`version` FROM `editors` e INNER JOIN `fields` f ON f.`field_id`=e.`field_id` INNER JOIN `makers` m ON m.`maker_id`=e.`maker_id` WHERE e.`is_compiler`={filter.SelectedIndex}", 7);
                    table.Rows.Clear();
                    foreach (var item in result)
                        table.Rows.Add(item);

                    SQL.CloseConnection();

                    table.Visible = true;
                    break;
                case 1:
                    table.Visible = false;
                    result2.Visible = true;
                    result3.Visible = false;

                    SQL.OpenConnection();
                    int id = field.SelectedIndex + 1;
                    var query2 = SQL.ExecuteQuery($"SELECT COUNT(*) FROM `editors` WHERE `field_id`={id}");


                    resultOutput2.Text = query2;
                    SQL.CloseConnection();
                    break;
                case 2:
                    result2.Visible = false;
                    result3.Visible = true;
                    SQL.OpenConnection();
                    var inputDate = date.Value.ToString("yyyy-MM-dd");
                    var queryResult = SQL.ExecuteQuery($"SELECT e.`editor_name`, m.`maker_name`, f.`field_name`, e.`our_mark`, e.`user_rating`, e.`release_year`, e.`version` FROM `editors` e INNER JOIN `fields` f ON f.`field_id`=e.`field_id` INNER JOIN `makers` m ON m.`maker_id`=e.`maker_id` WHERE e.`version_date`<='{inputDate}' ORDER BY `version_date` DESC LIMIT 1", 7);
                    string dateFromDB = SQL.ExecuteQuery($"SELECT `version_date` FROM `editors` WHERE `version_date`<='{inputDate}' ORDER BY `version_date` DESC LIMIT 1");
                    dateOut.Text = dateFromDB.Substring(0, 10);
                    
                    table.Rows.Clear();
                    table.Rows.Add(queryResult[0]);

                    SQL.CloseConnection();
                    table.Visible = true;
                    break;
            }
        }
    }
}