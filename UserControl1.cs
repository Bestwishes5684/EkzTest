using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkzTest
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(Events events)
        {
            InitializeComponent();
            initEvent(events);
        }

        private void initEvent(Events events )
        {
            using (var db = new HackatonContext())
            {

                LBLName.Text = events.Title;
                DateLVL.Text = events.StartDate.ToString();
                DaysLBL.Text = events.DayLasting.ToString();

                var citys = db.Cities.FirstOrDefault(x => x.Id == events.Id);
                  City.Text = citys.Name.ToString();


                var winner = db.Users.FirstOrDefault(x => x.Id == events.Id);
                WiinerLBL.Text=$"Победитель  {winner.Fullname}";
            }
        }

    }
}
