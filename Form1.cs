namespace EkzTest
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new HackatonContext())
            {
                USERS = db.Users.FirstOrDefault(x => x.Id == Convert.ToInt32(textBox1.Text) && x.Password == textBox2.Text);

                if (USERS != null)
                {
                    if (USERS.RoleId != 4)
                    {
                        return;
                        
                    }
                    MessageBox.Show($"{USERS.Fullname} Добро пожловать");
                    Form3 form2 = new Form3();  
                    form2.ShowDialog();
                    
                }
                else
                {
                    return;
                }
            }


        }


        public static Users USERS { get; set; }
    }
}
