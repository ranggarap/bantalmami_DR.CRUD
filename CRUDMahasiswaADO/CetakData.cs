using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMahasiswaADO
{
    internal class CetakData
    {
        static string connectionString = "Data Source=LAPTOP-M7PL4IES\\RANGGAFADHILAH;Initial Catalog=DBAkademikADO;User ID=sa;Password=123";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable dtMahasiswa;
        DAL dbLogic = new DAL();

        ListMahasiswa listMahasiswa = new ListMahasiswa();

        string prodi { get; set; }

        DateTime tglmasuk { get; set; }
    
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public string Alamat { get; set; }
        public string NamaProdi { get; set; }
        public DateTime TanggalDaftar { get; set; }
    }
}

