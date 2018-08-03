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
    public partial class CezaSil : Form
    {
        private SqlConnection con;
        private SqlCommand komut;

      
        private int kisiId,aracID;
        public CezaSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut.CommandText = "select kisiID from Cezali where ehliyetNo='"+textBox1.Text+"' ";
            
            kisiId = Convert.ToInt32(komut.ExecuteScalar().ToString());
           

            komut.CommandText = "select aracID from Ceza where cezaKisiID='" + kisiId + "' ";
            
            aracID = Convert.ToInt32(komut.ExecuteScalar().ToString());
            MessageBox.Show(Convert.ToString(aracID));
            komut.CommandText = "delete from Ceza where cezaKisiID='"+kisiId+"' ";
            komut.ExecuteNonQuery();
            komut.CommandText = "delete from Ceza where aracID='" + aracID + "' ";
            komut.ExecuteNonQuery();
            MessageBox.Show("tamam");

        }

        private void CezaSil_Load(object sender, EventArgs e)
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
