using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private List<Item> items;
        private List<Item> itemscust;
        public Form1()
        {
            InitializeComponent();
            connection = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Source\\Repos\\SqlWinForms12\\WinFormsApp15\\Database1.mdf;Integrated Security=True");
            items = new();
            itemscust = new();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            table1();
            table2();
        }
        private void table1()
        {
            items.Clear();
            comboBox1.Items.Clear();
            SqlCommand command = new(
                "select * from details",
                connection
                );
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(
                    new Item(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]),
                            Convert.ToInt32(reader["price"])
                        )
                    );
            }
            reader.Close();
            foreach (var item in items)
            {
                comboBox1.Items.Add(item.name);
            }
        }

        private void table2()
        {
            itemscust.Clear();
            comboBox3.Items.Clear();
            SqlCommand command = new(
                "select * from customers",
                connection
                );
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                itemscust.Add(
                    new Item(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"])
                        )
                    );
            }
            reader.Close();
            foreach (var item in itemscust)
            {
                comboBox3.Items.Add(item.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namefio;
            string detail;
            int total;
            string date = monthCalendar1.SelectionStart.ToShortDateString();

            for (int i = itemscust.Count - 1; i >= 0; i--)
            {
                if (itemscust[i].name == comboBox3.Text)
                {
                    comboBox3.SelectedIndex = i;
                    break;
                }
            }
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (items[i].name == comboBox1.Text)
                {
                    comboBox1.SelectedIndex = i;
                    break;
                }
            }
            if (comboBox3.SelectedIndex == -1)
            {

                namefio = newNameFio(comboBox3.Text);
            }
            else
            {
                namefio = itemscust[comboBox3.SelectedIndex].name;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                detail = newDetail(namefio, comboBox1.Text, comboBox2.Text, date);
                return;
            }
            else
            {
                detail = items[comboBox1.SelectedIndex].name;
                total = int.Parse(comboBox2.Text) * items[comboBox1.SelectedIndex].price;
            }

            newSales(namefio, detail, total, date);
        }

        private void newSales(string namefio, string detail, int total, string date)
        {
            label1.Text = namefio + " | " + detail +
               " " + total.ToString() + "póá.  " + date;
            SqlCommand command = new(
                "insert into [Sales] (fio,detail,price,date) values (@fio,@detail,@price,@date)",
                connection
                );
            command.Parameters.AddWithValue("fio", namefio);
            command.Parameters.AddWithValue("detail", detail);
            command.Parameters.AddWithValue("price", total);
            command.Parameters.AddWithValue("date", date);
            command.ExecuteNonQuery();
        }

        private string newNameFio(string name)
        {
            FormNewNameFio formNewNameFio = new(name, this);
            formNewNameFio.Show();
            return name;
        }
        private string newDetail(string namefio, string name, string count, string date)
        {
            FormNewDetail formNewDetail = new(namefio, name, count, date, this);
            formNewDetail.Show();

            return name;
        }
        public void Sales(string namefio, string detail, int price, string count, string date)
        {
            int total = int.Parse(count) * price;
            newSales(namefio, detail, total, date);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void addNewNameFio(string nameFio)
        {
            try
            {
                SqlCommand command = new(
                    $"insert into [customers] (name) values (@name)",//{nameFio}
                    connection
                    );
                command.Parameters.AddWithValue("name", nameFio);
                command.ExecuteNonQuery();

                table2();
            }
            catch (Exception ex) { };
        }
        public void addNewDetail(string detail, int price)
        {
            try
            {
                SqlCommand command = new(
                   $"insert into [details] (name,price) values (@name,@price)",//{detail}','{price}'
                   connection
                   );
                command.Parameters.AddWithValue("name", detail);
                command.Parameters.AddWithValue("price", price);
                command.ExecuteNonQuery();

                table1();
            }
            catch (Exception ex) { };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSales formSales = new(connection);
            formSales.Show();
        }
    }
    public class Item(int id,string name, int price = 0)
    {
        public int id=id;
        public string name=name;
        public int price=price;
    }
}
