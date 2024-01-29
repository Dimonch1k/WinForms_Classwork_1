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
            calcButton.Hide();
        }


        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            label1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            label2.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }




        // Main Box
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Background image
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }


        // If user doesn't input at least one number in one field
        private bool IsCounting(object sender, EventArgs e, Label label)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                label.Text = "Error!!!";
                return false;
            }
            return true;
        }


        // Call counting methods
        private void Button_Calc_Click(object sender, EventArgs e)
        {
            Label7_Click(sender, e);
            Label8_Click(sender, e);
            Label9_Click(sender, e);
            Label10_Click(sender, e);
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
            if (!IsCounting(sender, e, label7)) return; // End if input is empty

            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            int a = Int32.Parse(str1);
            int b = Int32.Parse(str2);

            int multi = a * b;

            label7.Text = $"{multi}";
            label7.Visible = true;
        }

        // Division
        private void Label8_Click(object sender, EventArgs e)
        {
            if (!IsCounting(sender, e, label8)) return; // End if input is empty

            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            double a = Int32.Parse(str1);
            double b = Int32.Parse(str2);

            double divide = a / b;

            label8.Text = $"{divide}";
            label8.Visible = true;
        }

        // Subtraction
        private void Label9_Click(object sender, EventArgs e)
        {
            if (!IsCounting(sender, e, label9)) return; // End if input is empty

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
            if (!IsCounting(sender, e, label10)) return; // End if input is empty

            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            int a = Int32.Parse(str1);
            int b = Int32.Parse(str2);

            int sum = a + b;

            label10.Text = $"{sum}";
            label10.Visible = true;
        }



        // ERROR LABEL
        private void Label11_Click(object sender, EventArgs e)
        {

        }



                                // CHANGE LABEL
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                label11.Visible = false;
                calcButton.Show();
                return;
            }
            label11.Visible = true;
            calcButton.Hide();
        }
    }
}
