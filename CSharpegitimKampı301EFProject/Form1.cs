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
    public partial class Form1 : Form
    {
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var values = db.TblGuide.ToList();//22 temmuz 2025
            dataGridView1.DataSource = values;

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            TblGuide guide = new TblGuide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.TblGuide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarı ile eklendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);//int bir değer aldık
            var removeValue = db.TblGuide.Find(id);//değerin gudie tablosundaki değerini bulduk
            db.TblGuide.Remove(removeValue);//değeri sildik
            db.SaveChanges();//değişiklikleri kaydettik
            MessageBox.Show("Silme işlemi tamamlandı");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.TblGuide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme başarı ile gerçekleşti","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }


        private void button5_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.TblGuide.Where(x=> x.GuideId==id).ToList();
            dataGridView1.DataSource = values;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
