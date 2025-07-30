using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CSharpegitimKampı301EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Lokation.ToList();
            dataGridView1.DataSource = values;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Lokation.Find(id);
            updateValue.DayNighit = NightDay.Text;
            updateValue.LokationCapacitiy = byte.Parse(nudCapacitiy.Value.ToString());
            updateValue.LokationCity = txtCity.Text;
            updateValue.LokationCountry = txtCountry.Text;
            updateValue.GuideId = int.Parse(Guide.SelectedValue.ToString());
            updateValue.LokationPrice = decimal.Parse(Price.Text);
            db.SaveChanges();
            MessageBox.Show("güncelleme başarılı.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.Lokation.Find(id);
            db.Lokation.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("silme işlemi başarılı.");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lokation location=new Lokation();
            location.LokationCapacitiy = byte.Parse(nudCapacitiy.Value.ToString());
            location.LokationCity = txtCity.Text;
            location.LokationCountry = txtCountry.Text;
            location.LokationPrice = decimal.Parse(Price.Text);
            location.DayNighit = NightDay.Text;
            location.GuideId = int.Parse(Guide.SelectedValue.ToString());
            db.Lokation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı.");
        }

        private void btnGeyById_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuide.Select(x => new
            {
                FullName = x.GuideName + x.GuideSurname,
                x.GuideId
            }).ToList();
            Guide.DisplayMember = "FullName";
            Guide.ValueMember = "GuideId";
            Guide.DataSource = values;

        }
    }
}
