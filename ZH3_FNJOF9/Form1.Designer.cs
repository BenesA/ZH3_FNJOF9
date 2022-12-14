namespace ZH3_FNJOF9
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
            this.u1 = new System.Windows.Forms.Button();
            this.u2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // u1
            // 
            this.u1.Location = new System.Drawing.Point(37, 76);
            this.u1.Name = "u1";
            this.u1.Size = new System.Drawing.Size(134, 53);
            this.u1.TabIndex = 0;
            this.u1.Text = "Rendelés módosítás";
            this.u1.UseVisualStyleBackColor = true;
            this.u1.Click += new System.EventHandler(this.u1_Click);
            // 
            // u2
            // 
            this.u2.Location = new System.Drawing.Point(37, 157);
            this.u2.Name = "u2";
            this.u2.Size = new System.Drawing.Size(134, 56);
            this.u2.TabIndex = 1;
            this.u2.Text = "Rendelés lista";
            this.u2.UseVisualStyleBackColor = true;
            this.u2.Click += new System.EventHandler(this.u2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(222, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 486);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.u2);
            this.Controls.Add(this.u1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button u1;
        private Button u2;
        private Panel panel1;
    }
}