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
    public partial class CezaEkle : Form
    {
       private  SqlConnection con;
       private SqlCommand komut;
         private int adresID;
         SqlDataReader oku;
      
         private int markaID, renkID, cinsID, ilID,ilceID,kisiID,aracID;
         private bool ode;
        public CezaEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut.CommandText = "select aracMarkaID from AracMarka where  aracMarkaAd ='"+ comboBox2.Text+"'";
            
            markaID = Convert.ToInt32(komut.ExecuteScalar().ToString());
       
            komut.CommandText = "select aracCinsiID from AracCinsi where aracCinsiAd ='" + comboBox4.Text + "'";
            cinsID = Convert.ToInt32(komut.ExecuteScalar().ToString());
            
            komut.CommandText = "select aracRenkID from AracRenk where  aracRenkAd ='" + comboBox3.Text + "'";
            renkID = Convert.ToInt32(komut.ExecuteScalar().ToString());
         

            komut.CommandText = "select ilID from IL where  ilAd='" + comboBox1.Text + "'";
           ilID = Convert.ToInt32(komut.ExecuteScalar().ToString());
          

           //komut.CommandText = "select ilceID from Ice where  ilceAd='" + comboBox5.Text + "'";
           //ilceID = Convert.ToInt32(komut.ExecuteScalar().ToString());
           //MessageBox.Show(Convert.ToString(ilceID));

           komut.CommandText = "insert into AdresBilgileri (cadde,sokak,evNo,mahalleAd ,ilID) values ('"+ textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox6.Text + "','" + Convert.ToInt32(ilID) + "')";

          komut.ExecuteNonQuery();
          

          komut.CommandText = "select adresID from AdresBilgileri where sokak ='" + textBox8.Text + "' ";

          adresID = Convert.ToInt32(komut.ExecuteScalar().ToString());
          
          komut.CommandText = "insert into Kisiler (kisiAd, kisiSoyad, kisiTC, kisiTel, kisiDogumYili, adresID, kisiTip) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker2.Value + "', '" + Convert.ToInt32(adresID) + "', 0)";

          komut.ExecuteNonQuery();
         
          komut.CommandText = " insert into AracBilgileri (aracCinsiID,aracMarkaID,aracYıl ,aracRenkID, aracPlakaNo) values ('" + Convert.ToInt32(cinsID) + "','" + Convert.ToInt32(markaID) + "','" + textBox12.Text + "','" + Convert.ToInt32(renkID) + "','" + textBox5.Text + "')";
           komut.ExecuteNonQuery();
           
            if(radioButton1.Checked==true)
            {
                ode = true;
            }
            else
            {
                ode = false;
            }
            komut.CommandText = "select kisiID from Kisiler where  kisiTC ='" + textBox3.Text + "'";
            kisiID = Convert.ToInt32(komut.ExecuteScalar().ToString());

            komut.CommandText = "insert into Cezali (kisiID,ehliyetNo,ehliyetVerildigiYil) values ('"+Convert.ToInt32(kisiID)+"','"+textBox10.Text+"','"+textBox11.Text+"') ";
            komut.ExecuteNonQuery();

            //komut.CommandType = CommandType.StoredProcedure;
            //komut.CommandText = "sp_CezaEkle";
            ////komut.Parameters["@cezaTutar"].Value = textBox13.Text;
            ////komut.Parameters["@cezaTarih"].Value = dateTimePicker1.Value;
            ////komut.Parameters["@cezaOdeme"].Value = öde;
            ////komut.Parameters["@cezaKisiID"].Value = kisiID;
            ////komut.Parameters["@aracID"].Value = kisiID;
            //komut.Parameters.AddWithValue("@cezaTutar", textBox13.Text);
            komut.CommandText = "insert into Ceza (cezaTutar,cezaTarih,cezaOdeme,cezaKisiID,aracID) values ('" + textBox13.Text + "','" + dateTimePicker1.Value + "', '"+ode+"','" + Convert.ToInt32(kisiID) + "','" + Convert.ToInt32(aracID) + "' ,0)";
            komut.ExecuteNonQuery();
            MessageBox.Show("tamamlandiSonSon");
             
            }



        private void CezaEkle_Load(object sender, EventArgs e)
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

            komut.CommandText = "select aracMarkaAd from AracMarka";

            oku = komut.ExecuteReader();
            while(oku.Read())
            {
                comboBox2.Items.Add(oku[0].ToString());
            }
            oku.Close();
            
            komut.CommandText = "select aracRenkAd from AracRenk";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox3.Items.Add(oku[0].ToString());
            }
            oku.Close();
            komut.CommandText = "select aracCinsiAd from AracCinsi";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox4.Items.Add(oku[0].ToString());
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
                comboBox5.Items.Add(oku[0].ToString());
            }
            oku.Close();
        }
    }
}
