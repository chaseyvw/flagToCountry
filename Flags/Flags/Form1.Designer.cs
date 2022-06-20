namespace Flags
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
            this.label1 = new System.Windows.Forms.Label();
            this.swedishFlag = new System.Windows.Forms.PictureBox();
            this.germanFlag = new System.Windows.Forms.PictureBox();
            this.frenchFlag = new System.Windows.Forms.PictureBox();
            this.countryNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.swedishFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frenchFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click a flag to see the name of the country!";
            // 
            // swedishFlag
            // 
            this.swedishFlag.Image = global::Flags.Properties.Resources.Swedish_Flag;
            this.swedishFlag.Location = new System.Drawing.Point(522, 180);
            this.swedishFlag.Name = "swedishFlag";
            this.swedishFlag.Size = new System.Drawing.Size(164, 108);
            this.swedishFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.swedishFlag.TabIndex = 2;
            this.swedishFlag.TabStop = false;
            this.swedishFlag.Click += new System.EventHandler(this.swedishFlag_Click);
            // 
            // germanFlag
            // 
            this.germanFlag.Image = global::Flags.Properties.Resources.germany_flag;
            this.germanFlag.Location = new System.Drawing.Point(319, 180);
            this.germanFlag.Name = "germanFlag";
            this.germanFlag.Size = new System.Drawing.Size(164, 108);
            this.germanFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.germanFlag.TabIndex = 1;
            this.germanFlag.TabStop = false;
            this.germanFlag.Click += new System.EventHandler(this.germanFlag_Click);
            // 
            // frenchFlag
            // 
            this.frenchFlag.Image = global::Flags.Properties.Resources.France_Flag;
            this.frenchFlag.Location = new System.Drawing.Point(95, 180);
            this.frenchFlag.Name = "frenchFlag";
            this.frenchFlag.Size = new System.Drawing.Size(196, 108);
            this.frenchFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frenchFlag.TabIndex = 0;
            this.frenchFlag.TabStop = false;
            this.frenchFlag.Click += new System.EventHandler(this.frenchFlag_Click);
            // 
            // countryNameTextBox
            // 
            this.countryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryNameTextBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryNameTextBox.Location = new System.Drawing.Point(235, 333);
            this.countryNameTextBox.Name = "countryNameTextBox";
            this.countryNameTextBox.Size = new System.Drawing.Size(336, 31);
            this.countryNameTextBox.TabIndex = 4;
            this.countryNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countryNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swedishFlag);
            this.Controls.Add(this.germanFlag);
            this.Controls.Add(this.frenchFlag);
            this.Name = "Form1";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.swedishFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frenchFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox frenchFlag;
        private System.Windows.Forms.PictureBox germanFlag;
        private System.Windows.Forms.PictureBox swedishFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryNameTextBox;
    }
}

