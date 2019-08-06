namespace CarRace
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BetAmount = new System.Windows.Forms.NumericUpDown();
            this.BidOnCar = new System.Windows.Forms.NumericUpDown();
            this.PlaceBid = new System.Windows.Forms.Button();
            this.StartRace = new System.Windows.Forms.Button();
            this.Car4 = new System.Windows.Forms.PictureBox();
            this.Car3 = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackLength = new System.Windows.Forms.PictureBox();
            this.Car5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BidOnCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Betting Parlor";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 455);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 478);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 501);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bet Amount : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bet On?";
            // 
            // BetAmount
            // 
            this.BetAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Location = new System.Drawing.Point(557, 448);
            this.BetAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(120, 20);
            this.BetAmount.TabIndex = 15;
            this.BetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BidOnCar
            // 
            this.BidOnCar.Location = new System.Drawing.Point(557, 474);
            this.BidOnCar.Name = "BidOnCar";
            this.BidOnCar.Size = new System.Drawing.Size(120, 20);
            this.BidOnCar.TabIndex = 16;
            // 
            // PlaceBid
            // 
            this.PlaceBid.Location = new System.Drawing.Point(482, 500);
            this.PlaceBid.Name = "PlaceBid";
            this.PlaceBid.Size = new System.Drawing.Size(195, 36);
            this.PlaceBid.TabIndex = 17;
            this.PlaceBid.Text = "Place Bid";
            this.PlaceBid.UseVisualStyleBackColor = true;
            this.PlaceBid.Click += new System.EventHandler(this.PlaceBid_Click);
            // 
            // StartRace
            // 
            this.StartRace.Location = new System.Drawing.Point(683, 516);
            this.StartRace.Name = "StartRace";
            this.StartRace.Size = new System.Drawing.Size(193, 60);
            this.StartRace.TabIndex = 18;
            this.StartRace.Text = "Race";
            this.StartRace.UseVisualStyleBackColor = true;
            this.StartRace.Click += new System.EventHandler(this.StartRace_Click);
            // 
            // Car4
            // 
            this.Car4.Image = global::CarRace.Properties.Resources.RaceCarRed;
            this.Car4.Location = new System.Drawing.Point(28, 241);
            this.Car4.Name = "Car4";
            this.Car4.Size = new System.Drawing.Size(50, 50);
            this.Car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car4.TabIndex = 4;
            this.Car4.TabStop = false;
            // 
            // Car3
            // 
            this.Car3.Image = global::CarRace.Properties.Resources.RaceCarPink;
            this.Car3.Location = new System.Drawing.Point(28, 176);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(50, 50);
            this.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car3.TabIndex = 3;
            this.Car3.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.Image = global::CarRace.Properties.Resources.RaceCarGray;
            this.Car2.Location = new System.Drawing.Point(28, 111);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(50, 50);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 2;
            this.Car2.TabStop = false;
            // 
            // Car1
            // 
            this.Car1.Image = global::CarRace.Properties.Resources.RaceCarBlue;
            this.Car1.Location = new System.Drawing.Point(28, 46);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(50, 50);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 1;
            this.Car1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CarRace.Properties.Resources.imageedit_1_5647473994;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(753, 407);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackLength
            // 
            this.trackLength.BackgroundImage = global::CarRace.Properties.Resources.imageedit_1_5647473994;
            this.trackLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackLength.Location = new System.Drawing.Point(12, 12);
            this.trackLength.Name = "trackLength";
            this.trackLength.Size = new System.Drawing.Size(597, 407);
            this.trackLength.TabIndex = 5;
            this.trackLength.TabStop = false;
            // 
            // Car5
            // 
            this.Car5.Image = global::CarRace.Properties.Resources.RaceCarPurple;
            this.Car5.Location = new System.Drawing.Point(28, 308);
            this.Car5.Name = "Car5";
            this.Car5.Size = new System.Drawing.Size(50, 50);
            this.Car5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car5.TabIndex = 19;
            this.Car5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 588);
            this.Controls.Add(this.Car5);
            this.Controls.Add(this.StartRace);
            this.Controls.Add(this.PlaceBid);
            this.Controls.Add(this.BidOnCar);
            this.Controls.Add(this.BetAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Car4);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackLength);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BidOnCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car3;
        private System.Windows.Forms.PictureBox Car4;
        private System.Windows.Forms.PictureBox trackLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown BetAmount;
        private System.Windows.Forms.NumericUpDown BidOnCar;
        private System.Windows.Forms.Button PlaceBid;
        private System.Windows.Forms.Button StartRace;
        private System.Windows.Forms.PictureBox Car5;
        private System.Windows.Forms.Timer timer1;
    }
}

