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

        public Payments()
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            string stm = "SELECT * FROM PAYMENT";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }

            InitializeComponent();
        }
        //private void data_show()
        //{
        //    var con = new SQLiteConnection(cs);
        //    con.Open();

        //    string stm = "SELECT * FROM PAYMENT";
        //    var cmd = new SQLiteCommand(stm, con);
        //    dr = cmd.ExecuteReader();

        //    while(dr.Read())
        //    {
        //        dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
        //    }
        //}

        //private void Create_db()
        //{
        //    if (!System.IO.File.Exists(path))
        //    {
        //        SQLiteConnection.CreateFile(path);
        //        using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
        //        {
        //            sqlite.Open();
        //            string sql = "CREATE TABLE Products(prodID INTEGER NOT NULL PRIMARY KEY, prodType TEXT NOT NULL, prodModel TEXT NOT NULL, prodPrice REAL NOT NULL, manID INTEGER NOT NULL, FOREIGN KEY (manID) REFERENCES MANUFACTURER(mID))";
        //            SQLiteCommand command = new SQLiteCommand(sql, sqlite);
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error");
        //        return;
        //    }
        //}

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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void Payments_Load(object sender, EventArgs e)
        {

        }
    }
}
