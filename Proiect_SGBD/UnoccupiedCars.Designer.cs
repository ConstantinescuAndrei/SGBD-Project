namespace Proiect_SGBD
{
    partial class UnoccupiedCars
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
            this.carsDataGrid = new System.Windows.Forms.DataGridView();
            this.rentACarButton = new System.Windows.Forms.Button();
            this.rentACarTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // carsDataGrid
            // 
            this.carsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.carsDataGrid.Name = "carsDataGrid";
            this.carsDataGrid.Size = new System.Drawing.Size(412, 417);
            this.carsDataGrid.TabIndex = 0;
            // 
            // rentACarButton
            // 
            this.rentACarButton.Location = new System.Drawing.Point(184, 461);
            this.rentACarButton.Name = "rentACarButton";
            this.rentACarButton.Size = new System.Drawing.Size(75, 23);
            this.rentACarButton.TabIndex = 1;
            this.rentACarButton.Text = "Rent a car";
            this.rentACarButton.UseVisualStyleBackColor = true;
            this.rentACarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rentACarTextbox
            // 
            this.rentACarTextbox.Location = new System.Drawing.Point(170, 435);
            this.rentACarTextbox.Name = "rentACarTextbox";
            this.rentACarTextbox.Size = new System.Drawing.Size(100, 20);
            this.rentACarTextbox.TabIndex = 3;
            this.rentACarTextbox.TextChanged += new System.EventHandler(this.rentACarTextbox_TextChanged);
            // 
            // UnoccupiedCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 520);
            this.Controls.Add(this.rentACarTextbox);
            this.Controls.Add(this.rentACarButton);
            this.Controls.Add(this.carsDataGrid);
            this.Name = "UnoccupiedCars";
            this.Text = "UnoccupiedCars";
            this.Load += new System.EventHandler(this.UnoccupiedCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDataGrid;
        private System.Windows.Forms.Button rentACarButton;
        private System.Windows.Forms.TextBox rentACarTextbox;
    }
}