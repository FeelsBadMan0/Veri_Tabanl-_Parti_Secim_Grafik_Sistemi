using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veri_Tabanlı_Parti_Secim_Grafik_Sistemi
{
    public partial class FrmOyGrirs : Form
    {
        public FrmOyGrirs()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PNOIT9G\\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void btnOyGiris_Click(object sender, System.EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", txtIlceAd.Text);
            komut.Parameters.AddWithValue("@p2", txtA.Text);
            komut.Parameters.AddWithValue("@p3", txtB.Text);
            komut.Parameters.AddWithValue("@p4", txtC.Text);
            komut.Parameters.AddWithValue("@p5", txtD.Text);
            komut.Parameters.AddWithValue("@p6", txtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti!");
        }

        private void btnGrafikler_Click(object sender, System.EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }

        private void btnCikisYap_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
