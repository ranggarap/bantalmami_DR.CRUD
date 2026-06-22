using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Form3 : Form

    {
        static string connectionString = "Data Source=LAPTOP-M7PL4IES\\RANGGAFADHILAH;Initial Catalog=DBAkademikADO;User ID=sa ;Password=123";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable dtMahasiswa;
        DAL dbLogic = new DAL();

        ListMahasiswa listMahasiswa = new ListMahasiswa();

        string prodi { get; set; }

        DateTime tglmasuk { get; set; }

        public Form3(string Prodi, DateTime TglMasuk)
        {
            InitializeComponent();
            prodi = Prodi;
            tglmasuk = TglMasuk;

            try
            {


                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                DataTable dtMahasiswa = dbLogic.getDataRekap(prodi, tglmasuk);

                listMahasiswa.SetDataSource(dtMahasiswa);
                crystalReportViewer1.ReportSource = listMahasiswa;
                crystalReportViewer1.Refresh();
            }

            catch (Exception ex)
            {
                //simpanLog(ex.Message);
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
        }
    }
}
