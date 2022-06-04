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
            field.SelectedIndex = 0;
            filter.SelectedIndex = 0;
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
    }
}