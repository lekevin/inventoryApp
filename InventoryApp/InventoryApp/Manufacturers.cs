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
    public partial class Manufacturers : Form
    {
        public Manufacturers()
        {
            InitializeComponent();
        }
        private void data_show()
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            string stm = "SELECT mID, mName, mState, mCategory FROM MANUFACTURER";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home prod = new Home();
            prod.Show();
            this.Hide();
        }

        private void Manufacturers_Load(object sender, EventArgs e)
        {
            data_show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO MANUFACTURER(mID, mName, mState, mCategory) VALUES (@mID, @mName, @mState, @mCategory)";

            string MANID = textBox1.Text;
            string MANNAME = textBox2.Text;
            string MANSTATE = textBox3.Text;
            string MANCAT = textBox4.Text;

            cmd.Parameters.AddWithValue("@mID", MANID);
            cmd.Parameters.AddWithValue("@mName", MANNAME);
            cmd.Parameters.AddWithValue("@mState", MANSTATE);
            cmd.Parameters.AddWithValue("@mCategory", MANCAT);

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ManID";
            dataGridView1.Columns[1].Name = "ManName";
            dataGridView1.Columns[2].Name = "ManState";
            dataGridView1.Columns[3].Name = "ManCategory";

            string[] row = new string[] { MANID, MANNAME, MANSTATE, MANCAT };
            dataGridView1.Rows.Add(row);

            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "UPDATE MANUFACTURER Set mName=@ManName, mState=@ManState, mCategory=@ManCategory WHERE mID=@ManID";
            cmd.Parameters.AddWithValue("@ManID", textBox1.Text);
            cmd.Parameters.AddWithValue("@ManName", textBox2.Text);
            cmd.Parameters.AddWithValue("@ManState", textBox3.Text);
            cmd.Parameters.AddWithValue("@ManCategory", textBox4.Text);

            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            data_show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM MANUFACTURER WHERE mID=@ManID";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@ManID", textBox1.Text);

            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            data_show();
        }
    }
}
