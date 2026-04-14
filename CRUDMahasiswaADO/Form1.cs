using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
              "Data Source=LAPTOP-M7PL4IES\\RANGGAFADHILAH;Initial Catalog=DBAkademikADO;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }
        private void ConnectDatabase()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                MessageBox.Show("Koneksi berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal:" + ex.Message);
            }
        }

       