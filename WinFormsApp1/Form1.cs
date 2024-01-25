using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class madLibs : Form
    {
        public madLibs()
        {
            InitializeComponent();
        }
        bool flag = false;
        private void TXT1_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                RTXT1.Text = "fill me in";
            }
        }

        private void TXT2_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                RTXT1.Text = "fill me in";
            }
        }

        private void TXT3_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                RTXT1.Text = "fill me in";
            }
        }

        private void TXT4_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                RTXT1.Text = "fill me in";
            }
        }
        private void TXT5_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                RTXT1.Text = "fill me in";
            }
        }

        private void TXT6_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                RTXT1.Text = "fill me in";
            }
        }

        private void TXT7_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                RTXT1.Text = "fill me in";
            }
        }

        private void TXT8_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                RTXT1.Text = "fill me in";
            }
        }
        private void BTN1_Click(object sender, EventArgs e)
        {
            RTXT1.Text += "It was a ";
            RTXT1.Text += TXT1.Text;
            RTXT1.Text += " day at the ";
            RTXT1.Text += TXT2.Text;
            RTXT1.Text += " I couldn't wait to ";
            RTXT1.Text += TXT3.Text;
            RTXT1.Text += " in the ";
            RTXT1.Text += TXT4.Text;
            RTXT1.Text += " sunshine and enjoy the ";
            RTXT1.Text += TXT5.Text;
            RTXT1.Text += ". First, we decided to ";
            RTXT1.Text += TXT6.Text;
            RTXT1.Text += " on the ";
            RTXT1.Text += TXT7.Text;
            RTXT1.Text += " which was known for being ";
            RTXT1.Text += TXT8.Text;
        }
        private void RTXT1_TextChanged(object sender, EventArgs e)
        {
            RTXT1.ReadOnly = true;
        }
    }
}