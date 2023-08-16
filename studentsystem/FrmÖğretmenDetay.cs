using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentsystem
{
    public partial class FrmÖğretmenDetay : Form
    {
        public FrmÖğretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=SAADET\SQLEXPRESS01;Initial Catalog=DbNoteRecord;Integrated Security=True");

        private void FrmÖğretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNoteRecordDataSet.TblLesson' table. You can move, or remove it, as needed.
            this.tblLessonTableAdapter.Fill(this.dbNoteRecordDataSet.TblLesson);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblLesson(Number,Name,Surname) values(@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1", MskNumara.Text);
            command.Parameters.AddWithValue("@p2", TxtAd.Text);
            command.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tblLessonTableAdapter.Fill(this.dbNoteRecordDataSet.TblLesson);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtS1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtS2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtS3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(TxtS1.Text);
            s2 = Convert.ToDouble(TxtS2.Text);
            s3 = Convert.ToDouble(TxtS3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            LblOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            connection.Open();
            SqlCommand command = new SqlCommand("update TblLesson set Exam1=@p1,Exam2=@p2,Exam3=@p3,Average=@p4,Status=@p5 where Number=@p6", connection);
            command.Parameters.AddWithValue("@p1", TxtS1.Text);
            command.Parameters.AddWithValue("@p2", TxtS2.Text);
            command.Parameters.AddWithValue("@p3", TxtS3.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(LblOrtalama.Text));
            command.Parameters.AddWithValue("@p5", durum);
            command.Parameters.AddWithValue("@p6", MskNumara.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            this.tblLessonTableAdapter.Fill(this.dbNoteRecordDataSet.TblLesson);

            connection.Open();
            SqlCommand command1 = new SqlCommand("Select count (*) from TblLesson where status='True'", connection);
            SqlDataReader dataReader = command1.ExecuteReader();
            while (dataReader.Read())
            {
                LblGecenSayısı.Text = dataReader[0].ToString();
            }
            connection.Close();


            connection.Open();
            SqlCommand command2 = new SqlCommand("select count (*) from TblLesson where status='False'", connection);
            SqlDataReader dataReader1= command2.ExecuteReader();
            while (dataReader1.Read()) 
            {
                LblKalanSayısı.Text = dataReader1[0].ToString();
            }
            connection.Close();
        }
    }
}
