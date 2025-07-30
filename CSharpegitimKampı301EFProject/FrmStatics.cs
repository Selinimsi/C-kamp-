using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpegitimKampı301EFProject
{
    public partial class FrmStatics : Form
    {
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        public FrmStatics()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatics_Load(object sender, EventArgs e)
        {
            //toplam lokasyon sayısı
           lblLocationCount.Text = db.Lokation.Count().ToString();
            //toplam kaasite için
            lblSumCapacitiy.Text = db.Lokation.Sum(x=>x.LokationCapacitiy).ToString();
            //rehber sayısı için
            lblGuideCount.Text = db.TblGuide.Count().ToString();
            //ortalama kapasite hesaplamak için
            lblAvgCapacitiy.Text = db.Lokation.Average(x => x.LokationCapacitiy).ToString();
            var avg = db.Lokation.Average(x => (decimal?)x.LokationPrice);
            //ortalama fiyat hesaplamak için
            lblAvgLocationPrice.Text = avg.HasValue
                ? avg.Value.ToString("F2")
                : "0.00";
            //eklenen son ülkeyi bulmak için

            int lostCountryId = db.Lokation.Max(x => x.LokationId);
            lblLostCountryName.Text = db.Lokation.Where(x => x.LokationId == lostCountryId).Select(y => y.LokationCountry).FirstOrDefault();
            //berlin kapasitesini bulmak için
            lblCapadociaLokationCapacitiy.Text = db.Lokation.Where(x => x.LokationCity == "Berlin").Select(y => y.LokationCapacitiy).FirstOrDefault().ToString();
            //türkiyenin kapasite ortalaması
            lblTurkeyLocationAvarage.Text = db.Lokation.Where(x => x.LokationCountry == "Türkiye").Average(y => y.LokationCapacitiy).ToString();
            //milano rehberi adını bulmak için
            var milanoguideId = db.Lokation.Where(x => x.LokationCity == "Milano").Select(y => y.GuideId).FirstOrDefault();
            lblMilanoguideName.Text = db.TblGuide.Where(x => x.GuideId == milanoguideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            //en yksek kapasiteye sahip lokasyon
            var MaxCapacitiy = db.Lokation.Max(x=>x.LokationCapacitiy);
            lblMaxCapacitiyLocation.Text = db.Lokation.Where(x => x.LokationCapacitiy == MaxCapacitiy).Select(y => y.LokationCity).FirstOrDefault().ToString();
            //en pahalı tur
            var MaxPrice = db.Lokation.Max(x => x.LokationPrice);
            lblMaxPriceLocation.Text = db.Lokation.Where(x => x.LokationPrice == MaxPrice).Select(y => y.LokationCity).FirstOrDefault().ToString();
            //Selin yıldırımtur sayısı
            var guideIdByNameSelinyildirim = db.TblGuide.Where(x => x.GuideName == "Selin" && x.GuideSurname == "Yıldırım").Select(y => y.GuideId).FirstOrDefault();
            lblSelinYildirimLocationCount.Text = db.Lokation.Where(x => x.GuideId == guideIdByNameSelinyildirim).Count().ToString();



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
