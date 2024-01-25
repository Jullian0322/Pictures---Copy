using System.Runtime.CompilerServices;

namespace Caculator
{


    public partial class Caculator : Form
    {

        string op = "";
        float holdA = 0;

        public Caculator()
        {
            InitializeComponent();
        }
        bool text = false;
        bool point = true;
        bool zero = false;

        public void setNumbers(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (TBX1.Text == "0" || text)
            {
                TBX1.Text = btn.Text;
            }
            else
            {
                TBX1.Text += btn.Text;
            }
            text = false;
            zero = true;

        }


        public void setOP(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            op = btn.Text;
            holdA = float.Parse(TBX1.Text);
            point = true;
            zero = false;
            text = true;
        }


        private void BTNE_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                TBX1.Text = (float.Parse(TBX1.Text) + holdA).ToString();
            }
            else if (op == "-")
            {
                TBX1.Text = (holdA - float.Parse(TBX1.Text)).ToString();
            }
            else if (op == "X")
            {
                TBX1.Text = (float.Parse(TBX1.Text) * holdA).ToString();
            }
            else
            {
                TBX1.Text = (holdA / float.Parse(TBX1.Text)).ToString();
            }
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            if (zero == false)
            {
                TBX1.Text = "";
            }
            else
            {
                TBX1.Text += "0";
            }
        }

        private void BTNDE_Click(object sender, EventArgs e)
        {

            if (text == false)
            {

                text = true;
            }
            if (point == true)
            {
                TBX1.Text += ".";
                point = false;
            }
            else
            {
                TBX1.Text += null;
            }
        }

        private void BTNAC_Click(object sender, EventArgs e)
        {
            TBX1.Text = "";
            op = "";
            holdA = 0;
            point = true;
            zero = false;
        }

        private void TBX1_TextChanged(object sender, EventArgs e)
        {
            text = false;
        }
    }
}