namespace Proiect_SGBD
{
    partial class ListOfCars
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteRoxTextbox = new System.Windows.Forms.TextBox();
            this.showCarsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.makeRadioButton = new System.Windows.Forms.RadioButton();
            this.modelButton = new System.Windows.Forms.RadioButton();
            this.carYearButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 457);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteRoxTextbox
            // 
            this.deleteRoxTextbox.Location = new System.Drawing.Point(544, 90);
            this.deleteRoxTextbox.Name = "deleteRoxTextbox";
            this.deleteRoxTextbox.Size = new System.Drawing.Size(100, 20);
            this.deleteRoxTextbox.TabIndex = 2;
            // 
            // showCarsButton
            // 
            this.showCarsButton.Location = new System.Drawing.Point(494, 34);
            this.showCarsButton.Name = "showCarsButton";
            this.showCarsButton.Size = new System.Drawing.Size(82, 23);
            this.showCarsButton.TabIndex = 3;
            this.showCarsButton.Text = "Show cars";
            this.showCarsButton.UseVisualStyleBackColor = true;
            this.showCarsButton.Click += new System.EventHandler(this.showCarsButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(544, 186);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 6;
            // 
            // rowTextBox
            // 
            this.rowTextBox.Location = new System.Drawing.Point(544, 223);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(100, 20);
            this.rowTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Value of column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Row";
            // 
            // makeRadioButton
            // 
            this.makeRadioButton.AutoSize = true;
            this.makeRadioButton.Location = new System.Drawing.Point(451, 287);
            this.makeRadioButton.Name = "makeRadioButton";
            this.makeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.makeRadioButton.TabIndex = 11;
            this.makeRadioButton.TabStop = true;
            this.makeRadioButton.Text = "Make";
            this.makeRadioButton.UseVisualStyleBackColor = true;
            // 
            // modelButton
            // 
            this.modelButton.AutoSize = true;
            this.modelButton.Location = new System.Drawing.Point(519, 287);
            this.modelButton.Name = "modelButton";
            this.modelButton.Size = new System.Drawing.Size(54, 17);
            this.modelButton.TabIndex = 12;
            this.modelButton.TabStop = true;
            this.modelButton.Text = "Model";
            this.modelButton.UseVisualStyleBackColor = true;
            // 
            // carYearButton
            // 
            this.carYearButton.AutoSize = true;
            this.carYearButton.Location = new System.Drawing.Point(580, 287);
            this.carYearButton.Name = "carYearButton";
            this.carYearButton.Size = new System.Drawing.Size(64, 17);
            this.carYearButton.TabIndex = 13;
            this.carYearButton.TabStop = true;
            this.carYearButton.Text = "Car year";
            this.carYearButton.UseVisualStyleBackColor = true;
            // 
            // ListOfCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 563);
            this.Controls.Add(this.carYearButton);
            this.Controls.Add(this.modelButton);
            this.Controls.Add(this.makeRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rowTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showCarsButton);
            this.Controls.Add(this.deleteRoxTextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListOfCars";
            this.Text = "ListOfCars";
            this.Load += new System.EventHandler(this.ListOfCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox deleteRoxTextbox;
        private System.Windows.Forms.Button showCarsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox rowTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton makeRadioButton;
        private System.Windows.Forms.RadioButton modelButton;
        private System.Windows.Forms.RadioButton carYearButton;
    }
}