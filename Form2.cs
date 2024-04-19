using Microsoft.EntityFrameworkCore;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Dostup();
        }

        private void Dostup()
        {






        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (var db = new HackatonContext())
            {
                var events = db.Events.ToList();

                foreach (var item in events)
                {
                    var eventsview = new UserControl1(item);
                    eventsview.Parent = flowLayoutPanel1;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.ShowDialog();
        }
    }
}
