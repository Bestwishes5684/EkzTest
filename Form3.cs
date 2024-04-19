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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Dostup();
        }

        private void Dostup()
        {
            NameLBL.Text = $"{Form1.USERS.Fullname}";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
        }

        
    }
}
