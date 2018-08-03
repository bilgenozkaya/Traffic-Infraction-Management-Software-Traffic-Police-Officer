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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnCezaEkle_Click(object sender, EventArgs e)
        {
            CezaEkle ce = new CezaEkle();
            ce.Show();
            this.Hide();
        }

        private void btnPolisEkle_Click(object sender, EventArgs e)
        {
            PolisEkle pe = new PolisEkle();
            pe.Show();
            this.Hide();
        }

        private void btnCezaSorgula_Click(object sender, EventArgs e)
        {
            CezaSorgula cs = new CezaSorgula();
            cs.Show();
            this.Hide();

        }

        private void btnCezaGuncel_Click(object sender, EventArgs e)
        {
            CezaSil cSi = new CezaSil();
            cSi.Show();
            this.Hide();
        }

        

        private void btnCezaOde_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
          
    }
}
