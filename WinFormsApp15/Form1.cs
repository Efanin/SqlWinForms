using System.Data.SqlClient;
namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private List<Item> items;
        public Form1()
        {
            InitializeComponent();
            connection = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\WinFormsApp15\\WinFormsApp15\\Database1.mdf;Integrated Security=True");
            items = new();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
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
                textBox1.Text += $"{item.id.ToString()} {item.name} {item.price.ToString()} \n";
                comboBox1.Items.Add(item.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = int.Parse(comboBox2.Text) * items[comboBox1.SelectedIndex].price;
            label1.Text = items[comboBox1.SelectedIndex].name +
                " " + total.ToString()+"póá.";
            MessageBox.Show(monthCalendar1.SelectionStart.Date.ToString());
        }
    }
    public class Item(int id,string name, int price)
    {
        public int id=id;
        public string name=name;
        public int price=price;
    }
}
