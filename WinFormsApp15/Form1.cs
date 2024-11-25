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
            connection = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Source\\Repos\\SqlWinForms\\WinFormsApp15\\Database1.mdf;Integrated Security=True");
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
            string date = monthCalendar1.SelectionStart.ToShortDateString();
            int total = int.Parse(comboBox2.Text) * items[comboBox1.SelectedIndex].price;
            label1.Text = itemscust[comboBox3.SelectedIndex].name + " | " + items[comboBox1.SelectedIndex].name +
                " " + total.ToString() + "póá.  " + date;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    public class Item(int id,string name, int price = 0)
    {
        public int id=id;
        public string name=name;
        public int price=price;
    }
}
