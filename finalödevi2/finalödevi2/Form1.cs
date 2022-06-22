using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace formuygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=eczanestok;Integrated Security=True;");


        public void verilerigoster()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from ilac", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }

        private void btngoruntule_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboxsirket.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttur.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtadet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into ilac values (@ilacad,@ilacsirketi,@ilacturu,@ilackutuadeti)";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@ilacad", txtad.Text);
            komut.Parameters.AddWithValue("@ilacsirketi", comboxsirket.Text);
            komut.Parameters.AddWithValue("@ilacturu", txttur.Text);
            komut.Parameters.AddWithValue("@ilackutuadeti", txtadet.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi.");
            baglan.Close();
            verilerigoster();

            txtıd.Clear(); txtad.Clear(); comboxsirket.ResetText();  txttur.Clear(); txtadet.Clear();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from ilac where Id=@id";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtıd.Text));
            baglan.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi.");
            baglan.Close();
            verilerigoster();

            txtıd.Clear(); txtad.Clear(); comboxsirket.ResetText(); txttur.Clear(); txtadet.Clear();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update ilac set ilacad=@ilacad,ilacsirketi=@ilacsirketi,ilacturu=@ilacturu,ilackutuadeti=@ilackutuadeti where Id=@id";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtıd.Text));
            komut.Parameters.AddWithValue("@ilacad", txtad.Text);
            komut.Parameters.AddWithValue("@ilacsirketi", comboxsirket.Text);
            komut.Parameters.AddWithValue("@ilacturu", txttur.Text);
            komut.Parameters.AddWithValue("@ilackutuadeti", txtadet.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi.");
            baglan.Close();
            verilerigoster();

            txtıd.Clear(); txtad.Clear(); comboxsirket.ResetText(); txttur.Clear(); txtadet.Clear();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtıd.Text = string.Empty;
            txtad.Text = string.Empty;
            comboxsirket.Text = string.Empty;
            txttur.Text = string.Empty;
            txtadet.Text = string.Empty;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            tablo.Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ilac where ilacad like '" + txtAra.Text + "'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
    }
}
