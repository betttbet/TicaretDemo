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

namespace Musteri
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        void Listele()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-UI1B736;Initial Catalog=ticaretdemo;Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("select * from musteri", baglanti);

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // datagridview üzerinde gezinirken seçili kayıtlardaki verilerin ilgili textboxlara doldurulması işlemi;
            txt_MNo.Text      = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_MAd.Text      = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_MSoyad.Text   = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            date_MDTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_MTel.Text     = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into musteri(ad, soyad, dtarih, tel) values (@ad, @soyad, @dtarih, @tel)";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@ad" , txt_MAd.Text);
            komut.Parameters.AddWithValue("@soyad", txt_MSoyad.Text);
            komut.Parameters.AddWithValue("@dtarih", date_MDTarih.Value);
            komut.Parameters.AddWithValue("@tel", txt_MTel.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from musteri where mno = @mno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@mno" , Convert.ToInt32(txt_MNo.Text)); // veritabanında mno int türünde olduğu için convert gerekir.

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update musteri set ad = @ad, soyad = @soyad, dtarih = @dtarih, tel = @tel where mno = @mno";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@mno", Convert.ToInt32(txt_MNo.Text));
            komut.Parameters.AddWithValue("@ad", txt_MAd.Text);
            komut.Parameters.AddWithValue("@soyad", txt_MSoyad.Text);
            komut.Parameters.AddWithValue("@dtarih", date_MDTarih.Value);
            komut.Parameters.AddWithValue("@tel", txt_MTel.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }
    }
}
