using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace InventoryApp
{
    public partial class Payments : Form
    {
        //List<Payments> pays = new List<Payments>();

        //string path = "database.db";
        //string cs = @"URI=file"+Application.StartupPath+"\\database.db";

        SQLiteDataReader dr;
        SQLiteCommand cmd;
        SQLiteConnection con;
        public Payments()
        {
            InitializeComponent();
        }

        private void data_show()
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            string stm = "SELECT * FROM PAYMENT";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0,dr.GetString(0),dr.GetString(1),dr.GetString(2),dr.GetString(3));
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home prod = new Home();
            prod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO PAYMENT(payCardHolder, payCardNo, payCardCVV, ordID) VALUES (@payCardHolder, @payCardNo, @payCardCVV, @ordID)";

            string HOLDER = textBox1.Text;
            string NUM = textBox2.Text;
            string CVV = textBox3.Text;
            string ORD = textBox4.Text;

            cmd.Parameters.AddWithValue("@payCardHolder", HOLDER);
            cmd.Parameters.AddWithValue("@payCardNo", NUM);
            cmd.Parameters.AddWithValue("@payCardCVV", CVV);
            cmd.Parameters.AddWithValue("@ordID", ORD);

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Card Holder";
            dataGridView1.Columns[1].Name = "Card Number";
            dataGridView1.Columns[2].Name = "CVV";
            dataGridView1.Columns[3].Name = "Order ID";

            string[] row = new string[] { HOLDER, NUM, CVV, ORD };
            dataGridView1.Rows.Add(row);

            cmd.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            data_show();
        }
    }
}
