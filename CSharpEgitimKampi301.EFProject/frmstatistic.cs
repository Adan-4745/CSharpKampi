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
    public partial class frmstatistic : Form
    {
        public frmstatistic()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db=new EgitimKampiEfTravelDbEntities();
        private void frmstatistic_Load(object sender, EventArgs e)
        {
            lbllocationcount.Text = db.tbllocation.Count().ToString();
           lblsumcapacity.Text=db.tbllocation.Sum(x => x.capacity).ToString();
            lblguide.Text=db.tblguide.Count().ToString();
            lblaveragecapacity.Text=db.tbllocation.Average(x =>(double?) x.capacity)?.ToString("f2")??"00.00";
            lblaverageturprice.Text = db.tbllocation.Average(x => (double?)x.price)?.ToString("f2")+ "₺"?? "00.00";

            int lastcountryid = db.tbllocation.Max(x => x.locationid);
            lblsonulke.Text = db.tbllocation.Where(x => x.locationid == lastcountryid).Select(y => y.country).FirstOrDefault();
            lblkapadokyaturcapacity.Text=db.tbllocation.Where(x=> x.city=="Kapadokya").Select(y=>y.capacity).FirstOrDefault().ToString();
            lblturkeyaverageturcapacity.Text=db.tbllocation.Where(x=>x.country=="Türkiye").Average(y=>y.capacity).ToString();
            var romeguiedid = db.tbllocation.Where(x => x.city == "Roma Turistik").Select(y => y.guideid).FirstOrDefault();
            lblromaguide.Text=db.tblguide.Where(x=>x.guideid==romeguiedid).Select(y=>y.guidename+ " " + y.guidesurname).FirstOrDefault();
            var maxcapacity = db.tbllocation.Max(x => x.capacity).Value;
            lblmaxcapacitytur.Text=db.tbllocation.Where(x=>x.capacity==maxcapacity).Select(y=>y.city).FirstOrDefault().ToString();  
            var maxprice=db.tbllocation.Max(y=>y.price).Value;
            lblpahalıtur.Text = db.tbllocation.Where(x => x.price == maxprice).Select(y => y.city).FirstOrDefault().ToString();
            var aysegulcınartur=db.tblguide.Where(x=>x.guidename=="Ayşegül" && x.guidesurname=="Çınar").Select(y=>y.guideid).FirstOrDefault();
            lblaysetursayı.Text=db.tbllocation.Where(x=>x.guideid==aysegulcınartur).Count().ToString();



        }
    }
}
