namespace _2_WForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.TextBox();
            this.celsiumLabel = new System.Windows.Forms.Label();
            this.fahrenheitLabel = new System.Windows.Forms.Label();
            this.swapBox = new System.Windows.Forms.PictureBox();
            this.thermometerBox = new System.Windows.Forms.PictureBox();
            this.toCButton = new System.Windows.Forms.Button();
            this.toFButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.swapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.IndianRed;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.Title.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(69, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(175, 39);
            this.Title.TabIndex = 1;
            this.Title.Text = "Conversation";
            this.Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // celsiumLabel
            // 
            this.celsiumLabel.AutoSize = true;
            this.celsiumLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.celsiumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.celsiumLabel.Location = new System.Drawing.Point(12, 100);
            this.celsiumLabel.Name = "celsiumLabel";
            this.celsiumLabel.Size = new System.Drawing.Size(83, 25);
            this.celsiumLabel.TabIndex = 2;
            this.celsiumLabel.Text = "Celsium";
            // 
            // fahrenheitLabel
            // 
            this.fahrenheitLabel.AutoSize = true;
            this.fahrenheitLabel.BackColor = System.Drawing.Color.BlueViolet;
            this.fahrenheitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fahrenheitLabel.Location = new System.Drawing.Point(12, 143);
            this.fahrenheitLabel.Name = "fahrenheitLabel";
            this.fahrenheitLabel.Size = new System.Drawing.Size(105, 25);
            this.fahrenheitLabel.TabIndex = 3;
            this.fahrenheitLabel.Text = "Fahrenheit";
            this.fahrenheitLabel.UseMnemonic = false;
            // 
            // swapBox
            // 
            this.swapBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.swapBox.Image = global::_2_WForm.Properties.Resources.swap;
            this.swapBox.Location = new System.Drawing.Point(17, 199);
            this.swapBox.Name = "swapBox";
            this.swapBox.Size = new System.Drawing.Size(57, 26);
            this.swapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.swapBox.TabIndex = 4;
            this.swapBox.TabStop = false;
            // 
            // thermometerBox
            // 
            this.thermometerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thermometerBox.Image = global::_2_WForm.Properties.Resources.thermometer;
            this.thermometerBox.InitialImage = null;
            this.thermometerBox.Location = new System.Drawing.Point(0, 0);
            this.thermometerBox.Name = "thermometerBox";
            this.thermometerBox.Size = new System.Drawing.Size(706, 450);
            this.thermometerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thermometerBox.TabIndex = 0;
            this.thermometerBox.TabStop = false;
            this.thermometerBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toCButton
            // 
            this.toCButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toCButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.toCButton.FlatAppearance.BorderSize = 0;
            this.toCButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toCButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toCButton.Location = new System.Drawing.Point(69, 199);
            this.toCButton.Name = "toCButton";
            this.toCButton.Size = new System.Drawing.Size(175, 26);
            this.toCButton.TabIndex = 5;
            this.toCButton.Text = "Fahrenheit to Celsium";
            this.toCButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toCButton.UseVisualStyleBackColor = false;
            // 
            // toFButton
            // 
            this.toFButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toFButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.toFButton.FlatAppearance.BorderSize = 0;
            this.toFButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toFButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toFButton.Location = new System.Drawing.Point(69, 219);
            this.toFButton.Name = "toFButton";
            this.toFButton.Size = new System.Drawing.Size(175, 26);
            this.toFButton.TabIndex = 6;
            this.toFButton.Text = "Celsium to Fahrenheit";
            this.toFButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toFButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(140, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(140, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 27);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toCButton);
            this.Controls.Add(this.toFButton);
            this.Controls.Add(this.swapBox);
            this.Controls.Add(this.fahrenheitLabel);
            this.Controls.Add(this.celsiumLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.thermometerBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.swapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox thermometerBox;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label celsiumLabel;
        private System.Windows.Forms.Label fahrenheitLabel;
        private System.Windows.Forms.PictureBox swapBox;
        private System.Windows.Forms.Button toCButton;
        private System.Windows.Forms.Button toFButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

