using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnlist_Click(object sender, EventArgs e)
        {
            var values =db.tblguide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tblguide guide=new tblguide();
            guide.guidename = txtname.Text;
            guide.guidesurname = txtsurname.Text;
            db.tblguide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarı ile eklendi.");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtid.Text);
            var removeValue=db.tblguide.Find(id);
            db.tblguide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi.");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtid.Text);
            var updateValue = db.tblguide.Find(id);
            updateValue.guidename = txtname.Text;
            updateValue.guidesurname= txtsurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btngetbyıd_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtid.Text);  
            var values=db.tblguide.Where(x=>x.guideid==id).ToList();
            dataGridView1.DataSource = values;

        }
    }
}
