using ZH3_FNJOF9.Models;

namespace ZH3_FNJOF9
{
    public partial class Form1 : Form
    {
        TextbookSupportContext context = new TextbookSupportContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void u1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void u2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 userControl2 = new UserControl2();
            panel1.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }
    }
}