namespace OhmsLawCalcwf
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
            this.Voltage_Label = new System.Windows.Forms.Label();
            this.Voltage_Box = new System.Windows.Forms.TextBox();
            this.Current_Box = new System.Windows.Forms.TextBox();
            this.Current_Label = new System.Windows.Forms.Label();
            this.Resistance_Box = new System.Windows.Forms.TextBox();
            this.Resistance_Label = new System.Windows.Forms.Label();
            this.Kilo_Ohms = new System.Windows.Forms.RadioButton();
            this.Maga_Ohms = new System.Windows.Forms.RadioButton();
            this.Calc_Current = new System.Windows.Forms.Button();
            this.Calc_Voltage = new System.Windows.Forms.Button();
            this.Calc_Resistance = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Voltage_Label
            // 
            this.Voltage_Label.AutoSize = true;
            this.Voltage_Label.Location = new System.Drawing.Point(33, 38);
            this.Voltage_Label.Name = "Voltage_Label";
            this.Voltage_Label.Size = new System.Drawing.Size(43, 13);
            this.Voltage_Label.TabIndex = 0;
            this.Voltage_Label.Text = "Voltage";
            // 
            // Voltage_Box
            // 
            this.Voltage_Box.Location = new System.Drawing.Point(36, 65);
            this.Voltage_Box.Name = "Voltage_Box";
            this.Voltage_Box.Size = new System.Drawing.Size(145, 20);
            this.Voltage_Box.TabIndex = 1;
            // 
            // Current_Box
            // 
            this.Current_Box.Location = new System.Drawing.Point(36, 123);
            this.Current_Box.Name = "Current_Box";
            this.Current_Box.Size = new System.Drawing.Size(145, 20);
            this.Current_Box.TabIndex = 2;
            // 
            // Current_Label
            // 
            this.Current_Label.AutoSize = true;
            this.Current_Label.Location = new System.Drawing.Point(36, 104);
            this.Current_Label.Name = "Current_Label";
            this.Current_Label.Size = new System.Drawing.Size(41, 13);
            this.Current_Label.TabIndex = 3;
            this.Current_Label.Text = "Current";
            // 
            // Resistance_Box
            // 
            this.Resistance_Box.Location = new System.Drawing.Point(36, 198);
            this.Resistance_Box.Name = "Resistance_Box";
            this.Resistance_Box.Size = new System.Drawing.Size(145, 20);
            this.Resistance_Box.TabIndex = 4;
            // 
            // Resistance_Label
            // 
            this.Resistance_Label.AutoSize = true;
            this.Resistance_Label.Location = new System.Drawing.Point(40, 179);
            this.Resistance_Label.Name = "Resistance_Label";
            this.Resistance_Label.Size = new System.Drawing.Size(60, 13);
            this.Resistance_Label.TabIndex = 5;
            this.Resistance_Label.Text = "Resistance";
            // 
            // Kilo_Ohms
            // 
            this.Kilo_Ohms.AutoSize = true;
            this.Kilo_Ohms.Location = new System.Drawing.Point(36, 150);
            this.Kilo_Ohms.Name = "Kilo_Ohms";
            this.Kilo_Ohms.Size = new System.Drawing.Size(72, 17);
            this.Kilo_Ohms.TabIndex = 6;
            this.Kilo_Ohms.TabStop = true;
            this.Kilo_Ohms.Text = "Kilo Ohms";
            this.Kilo_Ohms.UseVisualStyleBackColor = true;
            // 
            // Maga_Ohms
            // 
            this.Maga_Ohms.AutoSize = true;
            this.Maga_Ohms.Location = new System.Drawing.Point(125, 150);
            this.Maga_Ohms.Name = "Maga_Ohms";
            this.Maga_Ohms.Size = new System.Drawing.Size(82, 17);
            this.Maga_Ohms.TabIndex = 7;
            this.Maga_Ohms.TabStop = true;
            this.Maga_Ohms.Text = "Mega Ohms";
            this.Maga_Ohms.UseVisualStyleBackColor = true;
            // 
            // Calc_Current
            // 
            this.Calc_Current.Location = new System.Drawing.Point(36, 253);
            this.Calc_Current.Name = "Calc_Current";
            this.Calc_Current.Size = new System.Drawing.Size(75, 23);
            this.Calc_Current.TabIndex = 8;
            this.Calc_Current.Text = "Calc Current";
            this.Calc_Current.UseVisualStyleBackColor = true;
            this.Calc_Current.Click += new System.EventHandler(this.Calc_Current_Click);
            // 
            // Calc_Voltage
            // 
            this.Calc_Voltage.Location = new System.Drawing.Point(142, 253);
            this.Calc_Voltage.Name = "Calc_Voltage";
            this.Calc_Voltage.Size = new System.Drawing.Size(75, 23);
            this.Calc_Voltage.TabIndex = 9;
            this.Calc_Voltage.Text = "Calc Voltage";
            this.Calc_Voltage.UseVisualStyleBackColor = true;
            this.Calc_Voltage.Click += new System.EventHandler(this.Calc_Voltage_Click);
            // 
            // Calc_Resistance
            // 
            this.Calc_Resistance.Location = new System.Drawing.Point(241, 253);
            this.Calc_Resistance.Name = "Calc_Resistance";
            this.Calc_Resistance.Size = new System.Drawing.Size(101, 23);
            this.Calc_Resistance.TabIndex = 10;
            this.Calc_Resistance.Text = "Calc Resistance";
            this.Calc_Resistance.UseVisualStyleBackColor = true;
            this.Calc_Resistance.Click += new System.EventHandler(this.Calc_Resistance_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(374, 252);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button.TabIndex = 11;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 320);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Calc_Resistance);
            this.Controls.Add(this.Calc_Voltage);
            this.Controls.Add(this.Calc_Current);
            this.Controls.Add(this.Maga_Ohms);
            this.Controls.Add(this.Kilo_Ohms);
            this.Controls.Add(this.Resistance_Label);
            this.Controls.Add(this.Resistance_Box);
            this.Controls.Add(this.Current_Label);
            this.Controls.Add(this.Current_Box);
            this.Controls.Add(this.Voltage_Box);
            this.Controls.Add(this.Voltage_Label);
            this.Name = "Form1";
            this.Text = "Ohms Law Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Voltage_Label;
        private System.Windows.Forms.TextBox Voltage_Box;
        private System.Windows.Forms.TextBox Current_Box;
        private System.Windows.Forms.Label Current_Label;
        private System.Windows.Forms.TextBox Resistance_Box;
        private System.Windows.Forms.Label Resistance_Label;
        private System.Windows.Forms.RadioButton Kilo_Ohms;
        private System.Windows.Forms.RadioButton Maga_Ohms;
        private System.Windows.Forms.Button Calc_Current;
        private System.Windows.Forms.Button Calc_Voltage;
        private System.Windows.Forms.Button Calc_Resistance;
        private System.Windows.Forms.Button Clear_Button;
    }
}

