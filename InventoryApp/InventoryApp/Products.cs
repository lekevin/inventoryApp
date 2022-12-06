using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        private void data_show()
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            string stm = "SELECT prodID, prodType, prodModel, prodPrice, manID FROM PRODUCTS";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home prod = new Home();
            prod.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM PRODUCTS WHERE prodID=@ProductID";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@ProductID", textBox1.Text);

            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            data_show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO PRODUCTS(prodID, prodType, prodModel, prodPrice, manID) VALUES (@prodID, @prodType, @prodModel, @prodPrice, @manID)";

            string PROID = textBox1.Text;
            string PROTYPE = textBox2.Text;
            string PROMOD = textBox3.Text;
            string PROPRI = textBox4.Text;
            string MANUID = textBox5.Text;

            cmd.Parameters.AddWithValue("@prodID", PROID);
            cmd.Parameters.AddWithValue("@prodType", PROTYPE);
            cmd.Parameters.AddWithValue("@prodModel", PROMOD);
            cmd.Parameters.AddWithValue("@prodPrice", PROPRI);
            cmd.Parameters.AddWithValue("@manID", MANUID);

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ProductID";
            dataGridView1.Columns[1].Name = "ProductType";
            dataGridView1.Columns[2].Name = "ProductModel";
            dataGridView1.Columns[3].Name = "ProductPrice";
            dataGridView1.Columns[4].Name = "ManufacturerID";

            string[] row = new string[] { PROID, PROTYPE, PROMOD, PROPRI, MANUID };
            dataGridView1.Rows.Add(row);

            cmd.ExecuteNonQuery();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "UPDATE PRODUCTS Set prodType=@ProductType, prodModel=@ProductModel, prodPrice=@ProductPrice, manID=@ManufacturerID WHERE prodID=@ProductID";
            cmd.Parameters.AddWithValue("@ProductID", textBox1.Text);
            cmd.Parameters.AddWithValue("@ProductType", textBox2.Text);
            cmd.Parameters.AddWithValue("@ProductModel", textBox3.Text);
            cmd.Parameters.AddWithValue("@ProductType", textBox4.Text);
            cmd.Parameters.AddWithValue("@ManufacturerID", textBox5.Text);

            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            data_show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            data_show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
