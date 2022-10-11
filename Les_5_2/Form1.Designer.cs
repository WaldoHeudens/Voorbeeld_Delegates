namespace Les_5_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tbRemedie = new System.Windows.Forms.TextBox();
            this.lblRemedie = new System.Windows.Forms.Label();
            this.cbDotNet = new System.Windows.Forms.CheckBox();
            this.cbAndroid = new System.Windows.Forms.CheckBox();
            this.cbProjectIntro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Student is te laat met opdracht";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbRemedie
            // 
            this.tbRemedie.Location = new System.Drawing.Point(87, 206);
            this.tbRemedie.Multiline = true;
            this.tbRemedie.Name = "tbRemedie";
            this.tbRemedie.Size = new System.Drawing.Size(270, 192);
            this.tbRemedie.TabIndex = 1;
            // 
            // lblRemedie
            // 
            this.lblRemedie.AutoSize = true;
            this.lblRemedie.Location = new System.Drawing.Point(28, 209);
            this.lblRemedie.Name = "lblRemedie";
            this.lblRemedie.Size = new System.Drawing.Size(53, 15);
            this.lblRemedie.TabIndex = 2;
            this.lblRemedie.Text = "Remedie";
            // 
            // cbDotNet
            // 
            this.cbDotNet.AutoSize = true;
            this.cbDotNet.Location = new System.Drawing.Point(28, 32);
            this.cbDotNet.Name = "cbDotNet";
            this.cbDotNet.Size = new System.Drawing.Size(50, 19);
            this.cbDotNet.TabIndex = 3;
            this.cbDotNet.Text = ".NET";
            this.cbDotNet.UseVisualStyleBackColor = true;
            this.cbDotNet.Click += new System.EventHandler(this.ClickOpCheckbox);
            // 
            // cbAndroid
            // 
            this.cbAndroid.AutoSize = true;
            this.cbAndroid.Location = new System.Drawing.Point(28, 57);
            this.cbAndroid.Name = "cbAndroid";
            this.cbAndroid.Size = new System.Drawing.Size(69, 19);
            this.cbAndroid.TabIndex = 4;
            this.cbAndroid.Text = "Android";
            this.cbAndroid.UseVisualStyleBackColor = true;
            this.cbAndroid.Click += new System.EventHandler(this.ClickOpCheckbox);
            // 
            // cbProjectIntro
            // 
            this.cbProjectIntro.AutoSize = true;
            this.cbProjectIntro.Location = new System.Drawing.Point(28, 82);
            this.cbProjectIntro.Name = "cbProjectIntro";
            this.cbProjectIntro.Size = new System.Drawing.Size(91, 19);
            this.cbProjectIntro.TabIndex = 5;
            this.cbProjectIntro.Text = "Project Intro";
            this.cbProjectIntro.UseVisualStyleBackColor = true;
            this.cbProjectIntro.Click += new System.EventHandler(this.ClickOpCheckbox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 411);
            this.Controls.Add(this.cbProjectIntro);
            this.Controls.Add(this.cbAndroid);
            this.Controls.Add(this.cbDotNet);
            this.Controls.Add(this.lblRemedie);
            this.Controls.Add(this.tbRemedie);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Probleemstudenten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox tbRemedie;
        private Label lblRemedie;
        private CheckBox cbDotNet;
        private CheckBox cbAndroid;
        private CheckBox cbProjectIntro;
    }
}