using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void data_show()
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            string stm = "SELECT oID, oDate, oFirstName, oLastName, oAddress, proID FROM ORDERS";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5));
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home prod = new Home();
            prod.Show();
            this.Hide();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            data_show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO ORDERS(oID, oDate, oFirstName, oLastName, oAddress, proID) VALUES (@oID, @oDate, @oFirstName, @oLastName, @oAddress, @proID)";

            string ORID = textBox1.Text;
            string ODAT = textBox2.Text;
            string OFIR = textBox3.Text;
            string OLAS = textBox4.Text;
            string OADD = textBox5.Text;
            string PID = textBox6.Text;

            cmd.Parameters.AddWithValue("@oID", ORID);
            cmd.Parameters.AddWithValue("@oDate", ODAT);
            cmd.Parameters.AddWithValue("@oFirstName", OFIR);
            cmd.Parameters.AddWithValue("@oLastName", OLAS);
            cmd.Parameters.AddWithValue("@oAddress", OADD);
            cmd.Parameters.AddWithValue("@proID", PID);

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "OrderID";
            dataGridView1.Columns[1].Name = "OrderDate";
            dataGridView1.Columns[2].Name = "OrderFirstName";
            dataGridView1.Columns[3].Name = "OrderLastName";
            dataGridView1.Columns[3].Name = "OrderAddress";
            dataGridView1.Columns[3].Name = "ProductID";

            string[] row = new string[] { ORID, ODAT, OFIR, OLAS, OADD, PID };
            dataGridView1.Rows.Add(row);

            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "UPDATE ORDERS Set oDate=@OrderDate, oFirstName=@OrderFirstName, oLastName=@OrderLastName, oAddress=@OrderAddress, proID=@ProductID WHERE oID=@OrderID";
            cmd.Parameters.AddWithValue("@OrderID", textBox1.Text);
            cmd.Parameters.AddWithValue("@OrderDate", textBox2.Text);
            cmd.Parameters.AddWithValue("@OrderFirstName", textBox3.Text);
            cmd.Parameters.AddWithValue("@OrderLastName", textBox4.Text);
            cmd.Parameters.AddWithValue("@OrderAddress", textBox5.Text);
            cmd.Parameters.AddWithValue("@ProductID", textBox6.Text);

            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            data_show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM ORDERS WHERE oID=@OrderID";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@OrderID", textBox1.Text);

            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            data_show();

        }
    }
}
