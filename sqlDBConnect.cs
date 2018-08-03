using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace TrafikPolisi
{
    class sqlDBConnect
    {
        private SqlConnection _con;
        public SqlCommand Cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;

        public sqlDBConnect()
    {
            _con= new SqlConnection("Data Source=ASUS;Integrated Security=SSPI;Initial Catalog=TrafikPolisi");
            SqlCommand komut = new SqlCommand();
            komut.Connection = _con;
            _con.Open();
          

    }

        public void SqlQuery(string queryTest)
        {
            Cmd = new SqlCommand(queryTest, _con);
           

         }
        public DataTable QueryEx()  // bu fonksiyon select işlemleri için
        {
            _da = new SqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;

        }
        public void NonQueryEx()   //bu fonksiyon insert , update, delete işlemleri için
        {
            Cmd.ExecuteNonQuery();

        }



    }
}
