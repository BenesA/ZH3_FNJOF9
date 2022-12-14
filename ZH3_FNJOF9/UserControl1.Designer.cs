namespace ZH3_FNJOF9
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentszur = new System.Windows.Forms.TextBox();
            this.konyvszur = new System.Windows.Forms.TextBox();
            this.studentbox = new System.Windows.Forms.ListBox();
            this.orderbox = new System.Windows.Forms.ListBox();
            this.bookbox = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.rem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentszur
            // 
            this.studentszur.Location = new System.Drawing.Point(46, 35);
            this.studentszur.Name = "studentszur";
            this.studentszur.Size = new System.Drawing.Size(160, 23);
            this.studentszur.TabIndex = 0;
            this.studentszur.TextChanged += new System.EventHandler(this.studentszur_TextChanged);
            // 
            // konyvszur
            // 
            this.konyvszur.Location = new System.Drawing.Point(664, 35);
            this.konyvszur.Name = "konyvszur";
            this.konyvszur.Size = new System.Drawing.Size(160, 23);
            this.konyvszur.TabIndex = 1;
            this.konyvszur.TextChanged += new System.EventHandler(this.konyvszur_TextChanged);
            // 
            // studentbox
            // 
            this.studentbox.FormattingEnabled = true;
            this.studentbox.ItemHeight = 15;
            this.studentbox.Location = new System.Drawing.Point(46, 97);
            this.studentbox.Name = "studentbox";
            this.studentbox.Size = new System.Drawing.Size(160, 319);
            this.studentbox.TabIndex = 2;
            // 
            // orderbox
            // 
            this.orderbox.FormattingEnabled = true;
            this.orderbox.ItemHeight = 15;
            this.orderbox.Location = new System.Drawing.Point(273, 97);
            this.orderbox.Name = "orderbox";
            this.orderbox.Size = new System.Drawing.Size(160, 319);
            this.orderbox.TabIndex = 3;
            // 
            // bookbox
            // 
            this.bookbox.FormattingEnabled = true;
            this.bookbox.ItemHeight = 15;
            this.bookbox.Location = new System.Drawing.Point(664, 97);
            this.bookbox.Name = "bookbox";
            this.bookbox.Size = new System.Drawing.Size(160, 319);
            this.bookbox.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(487, 131);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(128, 65);
            this.add.TabIndex = 5;
            this.add.Text = "Hozzáadás";
            this.add.UseVisualStyleBackColor = true;
            // 
            // rem
            // 
            this.rem.Location = new System.Drawing.Point(487, 250);
            this.rem.Name = "rem";
            this.rem.Size = new System.Drawing.Size(128, 66);
            this.rem.TabIndex = 6;
            this.rem.Text = "Töréls";
            this.rem.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rem);
            this.Controls.Add(this.add);
            this.Controls.Add(this.bookbox);
            this.Controls.Add(this.orderbox);
            this.Controls.Add(this.studentbox);
            this.Controls.Add(this.konyvszur);
            this.Controls.Add(this.studentszur);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(886, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox studentszur;
        private TextBox konyvszur;
        private ListBox studentbox;
        private ListBox orderbox;
        private ListBox bookbox;
        private Button add;
        private Button rem;
    }
}
