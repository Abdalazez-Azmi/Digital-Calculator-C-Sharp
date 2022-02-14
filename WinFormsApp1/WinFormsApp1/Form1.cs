namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double result;
        string proc;
        public Form1()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton9_Click(object sender, EventArgs e)
        {

        }

        private void roundButton7_Click(object sender, EventArgs e)
        {

        }

        private void roundButton16_Click(object sender, EventArgs e)
        {

        }

        private void roundButton8_Click(object sender, EventArgs e)
        {

        }

        private void roundButton15_Click(object sender, EventArgs e)
        {

        }

        private void roundButton16_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nums_click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            if (label1.Text == "0") 
            {
                label1.Text = "";
                label1.Text = label1.Text + btn.Text;
                label2.Text = label1.Text ;
            }
            else
            {
                label1.Text = label1.Text + btn.Text;
                label2.Text = label1.Text;
            }
            

        }

        private void proccess_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num1 = Convert.ToDouble(label1.Text);
            proc = btn.Text;
            if(btn.Text != "AC")
            {
                label2.Text = label1.Text + btn.Text;
            }
         
            label1.Text = "";

        }

        private void roundButton9_Click_1(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(label1.Text);
            if(proc == "+")
            {
                result = num1 + num2;
                label1.Text = Convert.ToString(result);
                label2.Text = "";
            }
            else if (proc == "-")
            {
                result = num1 - num2;
                label1.Text = Convert.ToString(result);
                label2.Text = "";
            }
            else if(proc == "x")
            {
                result = num1 * num2;
                label1.Text=Convert.ToString(result);
                label2.Text = "";
            }
            else if (proc == "/")
            {
                result =num1 / num2;
                label1.Text=Convert.ToString(result);
                label2.Text = "";
            }
            else if (proc == "AC")
            {
                
                label1.Text = "";
                label2.Text = "";

             

            }else if (proc == "%")
            {
                result = num1 % num2;
                label1.Text = Convert.ToString(result);
                label2.Text = "";
            } else if (proc == "+/-")
            {
                num2 = num2 - num2 * 2;
            }
        }
    }
}