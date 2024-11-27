using System.Data.SqlClient;
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
            connection = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\WinFormsApp15\\WinFormsApp15\\Database1.mdf;Integrated Security=True");
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
            int price;
            string date;
            if (comboBox3.SelectedIndex == -1)
                namefio = newNameFio(comboBox3.Text);
            else
                namefio = itemscust[comboBox3.SelectedIndex].name;
            if (comboBox1.SelectedIndex == -1)
            {
                detail = newDetail(comboBox1.Text, out price);
                total = int.Parse(comboBox2.Text) * price;
            }
            else
            {
                detail = items[comboBox1.SelectedIndex].name;
                total = int.Parse(comboBox2.Text) * items[comboBox1.SelectedIndex].price;
            }    
            date = monthCalendar1.SelectionStart.ToShortDateString();
            label1.Text = namefio + " | " + detail +
                " " + total.ToString() + "póá.  " + date;
        }

        private string newNameFio(string name)
        {
            FormNewNameFio formNewNameFio = new(name,this);
            formNewNameFio.Show();
            return name;
        }
        private string newDetail(string name, out int price)
        {
            FormNewDetail formNewDetail = new(name,this);
            formNewDetail.Show();
            price = 0;
            return name;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void addNewNameFio(string nameFio)
        {
            SqlCommand command = new(
                $"insert into [customers] (name) values (N'{nameFio}')",
                connection
                );
            command.ExecuteNonQuery();
            itemscust.Clear();
            table2();
        }
        public void addNewDetail(string detail, int price)
        {
            SqlCommand command = new(
               $"insert into [detail] (name,price) values (N'{detail}','{price}')",
               connection
               );
            command.ExecuteNonQuery();
            items.Clear();
            table1();
        }
    }
    public class Item(int id,string name, int price = 0)
    {
        public int id=id;
        public string name=name;
        public int price=price;
    }
}
