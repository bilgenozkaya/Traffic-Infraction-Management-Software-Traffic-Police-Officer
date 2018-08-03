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
    public partial class PolisEkle : Form
    {
        private SqlConnection con;
        private SqlCommand komut;
      
       private SqlDataReader oku;
        private int adresID,kisiID,rutbeID,ilID;
        public PolisEkle()
        {
            InitializeComponent();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut.CommandText = "select ilID from IL where  ilAd ='" + comboBox1.Text + "'";

            ilID = Convert.ToInt32(komut.ExecuteScalar().ToString());  // adres bilgieri tablosundaki fk alanı doldurmak için
            

            komut.CommandText = "insert into AdresBilgileri (cadde,sokak,evNo,mahalleAd,ilID) values('" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox6.Text + "','" + Convert.ToInt32(ilID) + "')";
          komut.ExecuteNonQuery();

          

          komut.CommandText = "select adresID from AdresBilgileri where sokak ='" + textBox8.Text + "'";

          adresID = Convert.ToInt32(komut.ExecuteScalar().ToString());
      

            komut.CommandText = "insert into Kisiler (kisiAd,kisiSoyad,kisiTC,kisiTel,kisiDogumYili,adresID,kisiTip) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker2.Value + "', '" + Convert.ToInt32(adresID) + "', 1)";
           komut.ExecuteNonQuery();
         
            komut.CommandText = "select kisiID from Kisiler where  kisiTC ='" + textBox3.Text + "'";
            kisiID = Convert.ToInt32(komut.ExecuteScalar().ToString());
            

            komut.CommandText = "select rutbeID from TrafikPolisiRutbe where  polisRutbeAd ='" + comboBox2.Text + "'";
            rutbeID = Convert.ToInt32(komut.ExecuteScalar().ToString());
            

            komut.CommandText = "insert into TrafikPolisi (kisiID,rutbeID,polisDeneyimSuresi) values ('" + Convert.ToInt32(kisiID) + "','" + Convert.ToInt32(rutbeID) + "','"+textBox5.Text+"')";
            komut.ExecuteNonQuery();
            MessageBox.Show(Convert.ToString("Kayıt Tamamlandı"));
            
            
        }

        private void PolisEkle_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=ASUS;Integrated Security=SSPI;Initial Catalog=TrafikPolisi");
            komut = new SqlCommand();
       
            komut.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

                MessageBox.Show("Veritabanına Bağlandı");
            }
            else
            {
                MessageBox.Show("Veritabanına Bağlanamadı");
            }


            komut.CommandText = "select polisRutbeAd from TrafikPolisiRutbe"; // veritabanından polisrütbe adları çekiliyor
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku[0].ToString());
            }
            oku.Close();
            komut.CommandText = "select ilAd from IL";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0].ToString());
            }
            oku.Close();

            komut.CommandText = "select ilceAd from Ilce";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox3.Items.Add(oku[0].ToString());
            }
            oku.Close();
          
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
