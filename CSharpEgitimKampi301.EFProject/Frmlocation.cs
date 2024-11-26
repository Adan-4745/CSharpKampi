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
    public partial class Frmlocation : Form
    {
        public Frmlocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db=new EgitimKampiEfTravelDbEntities();
        private void btnlist_Click(object sender, EventArgs e)
        {
            var values = db.tbllocation.ToList();
            dataGridView1.DataSource = values;

        }

        private void Frmlocation_Load(object sender, EventArgs e)
        {
            var values=db.tblguide.Select(x=>new
            {
                FullName=x.guidename + " " + x.guidesurname,
                x.guideid
            }).ToList();
            cmbrehber.DisplayMember = "FullName";
            cmbrehber.ValueMember = "guideid";
            cmbrehber.DataSource = values;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbllocation location = new tbllocation();
            location.capacity=byte.Parse(numcapacity.Value.ToString());
            location.city=txtcity.Text;
            location.country=txtcountry.Text;
            location.price=decimal.Parse(txtprice.Text.ToString());
            location.daynight = txtdaynıght.Text;
            location.guideid=int.Parse(cmbrehber.SelectedValue.ToString()); 
            db.tbllocation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı.");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtid.Text);
            var deletedValue = db.tbllocation.Find(id);
            db.tbllocation.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı.");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtid.Text);
            var updatedValue = db.tbllocation.Find(id);
            updatedValue.daynight = txtdaynıght.Text;
            updatedValue.price = decimal.Parse(txtprice.Text);
            updatedValue.capacity=byte.Parse(numcapacity.Value.ToString());
            updatedValue.city=txtcity.Text;
            updatedValue.country=txtcountry.Text;
            updatedValue.guideid = int.Parse(cmbrehber.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı.");
        }
    }
}
