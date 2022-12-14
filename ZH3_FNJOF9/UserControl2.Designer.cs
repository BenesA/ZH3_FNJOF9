namespace ZH3_FNJOF9
{
    partial class UserControl2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textbookFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderSkDataGridViewTextBoxColumn,
            this.studentFkDataGridViewTextBoxColumn,
            this.textbookFkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(782, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ZH3_FNJOF9.Models.Order);
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(ZH3_FNJOF9.Models.Order);
            // 
            // orderSkDataGridViewTextBoxColumn
            // 
            this.orderSkDataGridViewTextBoxColumn.DataPropertyName = "OrderSk";
            this.orderSkDataGridViewTextBoxColumn.HeaderText = "OrderSk";
            this.orderSkDataGridViewTextBoxColumn.Name = "orderSkDataGridViewTextBoxColumn";
            // 
            // studentFkDataGridViewTextBoxColumn
            // 
            this.studentFkDataGridViewTextBoxColumn.DataPropertyName = "StudentFkNavigation";
            this.studentFkDataGridViewTextBoxColumn.DataSource = this.orderBindingSource1;
            this.studentFkDataGridViewTextBoxColumn.DisplayMember = "StudentFkNavigation";
            this.studentFkDataGridViewTextBoxColumn.HeaderText = "StudentFk";
            this.studentFkDataGridViewTextBoxColumn.Name = "studentFkDataGridViewTextBoxColumn";
            this.studentFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // textbookFkDataGridViewTextBoxColumn
            // 
            this.textbookFkDataGridViewTextBoxColumn.DataPropertyName = "TextbookFk";
            this.textbookFkDataGridViewTextBoxColumn.HeaderText = "TextbookFk";
            this.textbookFkDataGridViewTextBoxColumn.Name = "textbookFkDataGridViewTextBoxColumn";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(788, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn orderSkDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn studentFkDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource1;
        private DataGridViewTextBoxColumn textbookFkDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
    }
}
