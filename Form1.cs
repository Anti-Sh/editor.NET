namespace editor.ru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Обработчик события "Форма загружена"
        {
            query.SelectedIndex = 0; // Начальное значение выпадающего списка
            queryPanel1.Location = new Point(4, 86); // Изменение координат параметров первого запроса
            queryPanel2.Location = new Point(4, 86); // Изменение координат параметров второго запроса
            queryPanel3.Location = new Point(4, 86); // Изменение координат параметров третьего запроса
            table.Location = new Point(4, 137); // Изменение координат таблицы вывода
            result2.Location = new Point(4, 130); // Изменение координат вывода результатов второго запроса
            result3.Location = new Point(313, 86); // Изменение координат вывода результатов третьего запроса
            
            SQL.OpenConnection(); // Открытие соединения с БД
            var items = SQL.ExecuteQuery($"SELECT * FROM `fields`", 2); // Запрос на изъятия 
            foreach(var item in items)
            {
                field.Items.Add(item[1]); // Добавление опции в выпадающий список
            }

            SQL.CloseConnection(); // Закрытие соединения с БД

            field.SelectedIndex = 0; // Начальное значение выпадающего списка
            filter.SelectedIndex = 0; // Начальное значение выпадающего списка
            date.Format = DateTimePickerFormat.Short; // Изменение формата 
        }

        private void query_SelectionChangeCommitted(object sender, EventArgs e) // Обработчик события "Принятие изменений выбранного значения выпадающего списка"
        {
            switch (query.SelectedIndex) // Конструкция SWITCH по индексу выпадающего списка
            {
                case 0: // Если индекс 0
                    queryPanel1.Visible = true; // Панель ввода параметров первого запроса -> ВКЛЮЧИТЬ
                    queryPanel2.Visible = false; // Панель ввода параметров второго запроса -> ВЫКЛЮЧИТЬ
                    queryPanel3.Visible = false; // Панель ввода параметров третьего запроса -> ВЫКЛЮЧИТЬ
                    break;
                case 1: // Если индекс 1
                    queryPanel1.Visible = false; // Панель ввода параметров первого запроса -> ВЫКЛЮЧИТЬ
                    queryPanel2.Visible = true; // Панель ввода параметров второго запроса -> ВКЛЮЧИТЬ
                    queryPanel3.Visible = false; // Панель ввода параметров третьего запроса -> ВЫКЛЮЧИТЬ
                    break;
                case 2: // Если индекс 2
                    queryPanel1.Visible = false; // Панель ввода параметров первого запроса -> ВЫКЛЮЧИТЬ
                    queryPanel2.Visible = false; // Панель ввода параметров второго запроса -> ВЫКЛЮЧИТЬ
                    queryPanel3.Visible = true; // Панель ввода параметров третьего запроса -> ВКЛЮЧИТЬ
                    break;
            }
        }

        private void submit_Click(object sender, EventArgs e) // Обработчик события "Нажатие на кнопку"
        {
            switch (query.SelectedIndex) // Конструкция SWITCH по индексу выпадающего списка
            {
                case 0: // Если индекс 0
                    result2.Visible = false; // Изменение видимости поле вывода результатов второго запроса -> ВЫКЛЮЧИТЬ
                    result3.Visible = false; // Изменение видимости поле вывода результатов третьего запроса -> ВЫКЛЮЧИТЬ

                    SQL.OpenConnection(); // Открытие соединения с БД
                    var result = SQL.ExecuteQuery($"SELECT e.`editor_name`, m.`maker_name`, f.`field_name`, e.`our_mark`, e.`user_rating`, e.`release_year`, e.`version` FROM `editors` e INNER JOIN `fields` f ON f.`field_id`=e.`field_id` INNER JOIN `makers` m ON m.`maker_id`=e.`maker_id` WHERE e.`is_compiler`={filter.SelectedIndex}", 7);
                    table.Rows.Clear(); // Удаление существующих значений в таблице для вывода
                    foreach (var item in result) // Добавление каждого найденного элемента в таблицу вывода
                        table.Rows.Add(item);
                    SQL.CloseConnection(); // Закрытие соединения с БД

                    table.Visible = true; // Изменение видимости таблицы вывода -> ВКЛЮЧИТЬ
                    break;
                case 1: // Если индекс 1
                    table.Visible = false; // Изменение видимости таблицы вывода -> ВЫКЛЮЧИТЬ
                    result2.Visible = true; // Изменение видимости поле вывода результатов второго запроса -> ВКЛЮЧИТЬ
                    result3.Visible = false; // Изменение видимости поле вывода результатов второго запроса -> ВКЛЮЧИТЬ

                    SQL.OpenConnection(); // Открытие соединения с БД
                    int id = field.SelectedIndex + 1; // Индекс выбранного значения выпадающего списка "Области" переводится в ID из SQL
                    var query2 = SQL.ExecuteQuery($"SELECT COUNT(*) FROM `editors` WHERE `field_id`={id}"); // Запрос в БД

                    resultOutput2.Text = query2; // Вывод текста
                    SQL.CloseConnection(); // Закрытие соединения с БД
                    break;
                case 2: // Если индекс 2
                    result2.Visible = false; // Изменение видимости поле вывода результатов второго запроса -> ВЫКЛЮЧИТЬ
                    result3.Visible = true; // Изменение видимости поле вывода результатов третьего запроса -> ВКЛЮЧИТЬ
                    SQL.OpenConnection(); // Открытие соединения с БД
                    var inputDate = date.Value.ToString("yyyy-MM-dd"); // Нормализация введенной пользователем даты
                    var queryResult = SQL.ExecuteQuery($"SELECT e.`editor_name`, m.`maker_name`, f.`field_name`, e.`our_mark`, e.`user_rating`, e.`release_year`, e.`version` FROM `editors` e INNER JOIN `fields` f ON f.`field_id`=e.`field_id` INNER JOIN `makers` m ON m.`maker_id`=e.`maker_id` WHERE e.`version_date`<='{inputDate}' ORDER BY `version_date` DESC LIMIT 1", 7);
                    string dateFromDB = SQL.ExecuteQuery($"SELECT `version_date` FROM `editors` WHERE `version_date`<='{inputDate}' ORDER BY `version_date` DESC LIMIT 1");
                    dateOut.Text = dateFromDB.Substring(0, 10); // Нормализация полученного из базы значения Даты
                    
                    table.Rows.Clear(); // Удаление существующих значений в таблице для вывода
                    table.Rows.Add(queryResult[0]); // Добавление единственной строки в таблицу вывода

                    SQL.CloseConnection(); // Закрытие соединения с БД
                    table.Visible = true; // Изменение видимости таблицы вывода -> ВКЛЮЧИТЬ
                    break;
            }
        }
    }
}