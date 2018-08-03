using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TrafikPolisi
{
    public partial class CezaSorgula : Form
    {
        private SqlConnection con;
        private SqlCommand komut;

        private SqlDataReader oku;
        public CezaSorgula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut.CommandText = "select kisiAd,kisiSoyad,kisiDogumYili,cezaTarih,cezaTutar from Kisiler inner join Ceza on Kisiler.kisiID=Ceza.cezaKisiID";
            SqlDataReader oku = komut.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(oku);
            dataGridView1.DataSource = table;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CezaSorgula_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=ASUS;Integrated Security=SSPI;Initial Catalog=TrafikPolisi");
            komut = new SqlCommand();
            komut.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

                MessageBox.Show("Bağlandı");
            }
            else
            {
                MessageBox.Show("Bağlanamadı");
            }
        }
    }
}
