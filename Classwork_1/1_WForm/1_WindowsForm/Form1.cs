using System;
using System.Drawing;
using System.Windows.Forms;

namespace _1_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            Label7_Click(sender, e);
            Label8_Click(sender, e);
            Label9_Click(sender, e);
            Label10_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            label1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            label2.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }









        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        // Main Box
        private void Form1_Load(object sender, EventArgs e)
        {
            changeBGImageToolStripMenuItem_Click(sender, e);
        }
        private void changeBGImageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\student\Pictures\calculator_img.jpg");
            this.BackgroundImage = myimage as Bitmap;

        }



        // If user doesn't input at least one number in one field
        private bool isCounting(object sender, EventArgs e, Label label)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                label.Text = "Error!!!";
                label.Visible = true;
                label11.Visible = true;
                return false;
            }
            label11.Visible = false;
            return true;
        }



                    
                            // PRINT LABELS
        // Input labels
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }


        // Math operation labels' names
        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void Label5_Click(object sender, EventArgs e)
        {
        }
        private void Label6_Click(object sender, EventArgs e)
        {

        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }



                            // LABELS FOR COUNTING
        // Multiplication
        private void Label7_Click(object sender, EventArgs e)
        {
            if (!isCounting(sender, e, label7)) return; // End if input is empty

            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            int a = Int32.Parse(str1);
            int b = Int32.Parse(str2);

            int multi = a * b;

            label7.Text = $"{multi}";
            label7.Visible = true;
        }

        // Dividion
        private void Label8_Click(object sender, EventArgs e)
        {
            if (!isCounting(sender, e, label8)) return; // End if input is empty

            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            double a = Int32.Parse(str1);
            double b = Int32.Parse(str2);

            double divide = a / b;

            label8.Text = $"{divide}";
            label8.Visible = true;
        }

        // Substration
        private void Label9_Click(object sender, EventArgs e)
        {
            if (!isCounting(sender, e, label9)) return; // End if input is empty

            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            double a = Int32.Parse(str1);
            double b = Int32.Parse(str2);

            double divide = a - b;

            label9.Text = $"{divide}";
            label9.Visible = true;
        }

        // Sum
        private void Label10_Click(object sender, EventArgs e)
        {
            if (!isCounting(sender, e, label10)) return; // End if input is empty

            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            int a = Int32.Parse(str1);
            int b = Int32.Parse(str2);

            int sum = a + b;

            label10.Text = $"{sum}";
            label10.Visible = true;
        }


        // Error label
        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                label11.Visible = false;
                return;
            }
            label11.Visible = true;
        }

        private void Calc_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 0 || textBox2.Text.Length < 0)
            {
                Calc.Visible = false;
                return;
            }
            Calc.Visible = true;
        }
    }
}
