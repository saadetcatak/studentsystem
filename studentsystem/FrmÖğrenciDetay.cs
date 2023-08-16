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

namespace studentsystem
{
    public partial class FrmÖğrenciDetay : Form
    {
        public FrmÖğrenciDetay()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection connection = new SqlConnection(@"Data Source=SAADET\SQLEXPRESS01;Initial Catalog=DbNoteRecord;Integrated Security=True");
        private void FrmÖğrenciDetay_Load(object sender, EventArgs e)
        {
            connection.Open();
            LblNumara.Text = numara;
            SqlCommand command = new SqlCommand("Select * From TblLesson where number=@p1", connection);
            command.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = command.ExecuteReader();

            while(dr.Read()) 
            {
                LblAdSoyad.Text = dr[2].ToString()+ " " + dr[3].ToString();
                LblS1.Text = dr[4].ToString();
                LblS2.Text = dr[5].ToString();
                LblS3.Text = dr[6].ToString();
                LblOrtalama.Text = dr[7].ToString();
                LblDurum.Text = dr[8].ToString();
            }
            connection.Close();
        }
    }
}
