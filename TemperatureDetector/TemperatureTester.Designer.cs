namespace TemperatureDetector
{
    partial class TemperatureTester
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
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonFarenheit = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonDecreasing = new System.Windows.Forms.RadioButton();
            this.radioButtonIncreasing = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.textBoxHysterisis = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "test Temperature Detector";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonCelsius
            // 
            this.radioButtonCelsius.AutoSize = true;
            this.radioButtonCelsius.Checked = true;
            this.radioButtonCelsius.Location = new System.Drawing.Point(3, 3);
            this.radioButtonCelsius.Name = "radioButtonCelsius";
            this.radioButtonCelsius.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCelsius.TabIndex = 1;
            this.radioButtonCelsius.TabStop = true;
            this.radioButtonCelsius.Text = "Celsius";
            this.radioButtonCelsius.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonFarenheit);
            this.panel1.Controls.Add(this.radioButtonCelsius);
            this.panel1.Location = new System.Drawing.Point(13, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 49);
            this.panel1.TabIndex = 2;
            // 
            // radioButtonFarenheit
            // 
            this.radioButtonFarenheit.AutoSize = true;
            this.radioButtonFarenheit.Location = new System.Drawing.Point(3, 26);
            this.radioButtonFarenheit.Name = "radioButtonFarenheit";
            this.radioButtonFarenheit.Size = new System.Drawing.Size(69, 17);
            this.radioButtonFarenheit.TabIndex = 2;
            this.radioButtonFarenheit.Text = "Farenheit";
            this.radioButtonFarenheit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonDecreasing);
            this.panel2.Controls.Add(this.radioButtonIncreasing);
            this.panel2.Location = new System.Drawing.Point(112, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 49);
            this.panel2.TabIndex = 3;
            // 
            // radioButtonDecreasing
            // 
            this.radioButtonDecreasing.AutoSize = true;
            this.radioButtonDecreasing.Checked = true;
            this.radioButtonDecreasing.Location = new System.Drawing.Point(3, 26);
            this.radioButtonDecreasing.Name = "radioButtonDecreasing";
            this.radioButtonDecreasing.Size = new System.Drawing.Size(79, 17);
            this.radioButtonDecreasing.TabIndex = 2;
            this.radioButtonDecreasing.TabStop = true;
            this.radioButtonDecreasing.Text = "Decreasing";
            this.radioButtonDecreasing.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncreasing
            // 
            this.radioButtonIncreasing.AutoSize = true;
            this.radioButtonIncreasing.Location = new System.Drawing.Point(3, 3);
            this.radioButtonIncreasing.Name = "radioButtonIncreasing";
            this.radioButtonIncreasing.Size = new System.Drawing.Size(74, 17);
            this.radioButtonIncreasing.TabIndex = 1;
            this.radioButtonIncreasing.Text = "Increasing";
            this.radioButtonIncreasing.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hysterisis";
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(265, 78);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(30, 20);
            this.textBoxThreshold.TabIndex = 6;
            this.textBoxThreshold.Text = "0";
            // 
            // textBoxHysterisis
            // 
            this.textBoxHysterisis.Location = new System.Drawing.Point(265, 105);
            this.textBoxHysterisis.Name = "textBoxHysterisis";
            this.textBoxHysterisis.Size = new System.Drawing.Size(30, 20);
            this.textBoxHysterisis.TabIndex = 7;
            this.textBoxHysterisis.Text = "2";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(13, 155);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(43, 200);
            this.textBoxInput.TabIndex = 8;
            this.textBoxInput.Text = "0";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(62, 155);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(44, 200);
            this.textBoxOutput.TabIndex = 9;
            this.textBoxOutput.Text = "0";
            // 
            // TemperatureTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 367);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxHysterisis);
            this.Controls.Add(this.textBoxThreshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "TemperatureTester";
            this.Text = "Test Temperature Class";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonCelsius;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonFarenheit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonDecreasing;
        private System.Windows.Forms.RadioButton radioButtonIncreasing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.TextBox textBoxHysterisis;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}

