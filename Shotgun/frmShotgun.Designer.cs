namespace Shotgun
{
    partial class frmShotgun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShotgun));
            this.picBoxYouStart = new System.Windows.Forms.PictureBox();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.lblYourShotsLeftCount = new System.Windows.Forms.Label();
            this.lblYouShotsLeft = new System.Windows.Forms.Label();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.picYouBlock = new System.Windows.Forms.PictureBox();
            this.picYouLoad = new System.Windows.Forms.PictureBox();
            this.picYouShoot = new System.Windows.Forms.PictureBox();
            this.picYouShotgun = new System.Windows.Forms.PictureBox();
            this.picCompShotgun = new System.Windows.Forms.PictureBox();
            this.picCompShoot = new System.Windows.Forms.PictureBox();
            this.picCompLoad = new System.Windows.Forms.PictureBox();
            this.picCompBlock = new System.Windows.Forms.PictureBox();
            this.lblCompShotsLeft = new System.Windows.Forms.Label();
            this.lblCompShotsLeftCount = new System.Windows.Forms.Label();
            this.picBoxCompStart = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblLooser = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblYou = new System.Windows.Forms.Label();
            this.picLine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYouStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouShoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouShotgun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompShotgun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompShoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCompStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxYouStart
            // 
            this.picBoxYouStart.Image = ((System.Drawing.Image)(resources.GetObject("picBoxYouStart.Image")));
            this.picBoxYouStart.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxYouStart.InitialImage")));
            this.picBoxYouStart.Location = new System.Drawing.Point(25, 80);
            this.picBoxYouStart.Name = "picBoxYouStart";
            this.picBoxYouStart.Size = new System.Drawing.Size(252, 255);
            this.picBoxYouStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxYouStart.TabIndex = 0;
            this.picBoxYouStart.TabStop = false;
            // 
            // btnShotgun
            // 
            this.btnShotgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShotgun.Location = new System.Drawing.Point(147, 420);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(104, 44);
            this.btnShotgun.TabIndex = 7;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // lblYourShotsLeftCount
            // 
            this.lblYourShotsLeftCount.AutoSize = true;
            this.lblYourShotsLeftCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourShotsLeftCount.Location = new System.Drawing.Point(188, 383);
            this.lblYourShotsLeftCount.Name = "lblYourShotsLeftCount";
            this.lblYourShotsLeftCount.Size = new System.Drawing.Size(19, 20);
            this.lblYourShotsLeftCount.TabIndex = 3;
            this.lblYourShotsLeftCount.Text = "0";
            // 
            // lblYouShotsLeft
            // 
            this.lblYouShotsLeft.AutoSize = true;
            this.lblYouShotsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouShotsLeft.Location = new System.Drawing.Point(18, 383);
            this.lblYouShotsLeft.Name = "lblYouShotsLeft";
            this.lblYouShotsLeft.Size = new System.Drawing.Size(90, 20);
            this.lblYouShotsLeft.TabIndex = 6;
            this.lblYouShotsLeft.Text = "Shots left";
            // 
            // btnShoot
            // 
            this.btnShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoot.Location = new System.Drawing.Point(203, 470);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(85, 44);
            this.btnShoot.TabIndex = 5;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.Location = new System.Drawing.Point(112, 470);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(85, 44);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(21, 470);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(85, 44);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Blue;
            this.lblWinner.Location = new System.Drawing.Point(180, 170);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(300, 69);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Text = "You Won!";
            // 
            // picYouBlock
            // 
            this.picYouBlock.Image = ((System.Drawing.Image)(resources.GetObject("picYouBlock.Image")));
            this.picYouBlock.Location = new System.Drawing.Point(25, 86);
            this.picYouBlock.Name = "picYouBlock";
            this.picYouBlock.Size = new System.Drawing.Size(263, 264);
            this.picYouBlock.TabIndex = 6;
            this.picYouBlock.TabStop = false;
            // 
            // picYouLoad
            // 
            this.picYouLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picYouLoad.Image = ((System.Drawing.Image)(resources.GetObject("picYouLoad.Image")));
            this.picYouLoad.Location = new System.Drawing.Point(28, 87);
            this.picYouLoad.Name = "picYouLoad";
            this.picYouLoad.Size = new System.Drawing.Size(253, 263);
            this.picYouLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picYouLoad.TabIndex = 6;
            this.picYouLoad.TabStop = false;
            // 
            // picYouShoot
            // 
            this.picYouShoot.Image = ((System.Drawing.Image)(resources.GetObject("picYouShoot.Image")));
            this.picYouShoot.Location = new System.Drawing.Point(21, 80);
            this.picYouShoot.Name = "picYouShoot";
            this.picYouShoot.Size = new System.Drawing.Size(264, 250);
            this.picYouShoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYouShoot.TabIndex = 6;
            this.picYouShoot.TabStop = false;
            // 
            // picYouShotgun
            // 
            this.picYouShotgun.Image = ((System.Drawing.Image)(resources.GetObject("picYouShotgun.Image")));
            this.picYouShotgun.Location = new System.Drawing.Point(25, 86);
            this.picYouShotgun.Name = "picYouShotgun";
            this.picYouShotgun.Size = new System.Drawing.Size(256, 244);
            this.picYouShotgun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYouShotgun.TabIndex = 6;
            this.picYouShotgun.TabStop = false;
            // 
            // picCompShotgun
            // 
            this.picCompShotgun.Image = ((System.Drawing.Image)(resources.GetObject("picCompShotgun.Image")));
            this.picCompShotgun.Location = new System.Drawing.Point(359, 86);
            this.picCompShotgun.Name = "picCompShotgun";
            this.picCompShotgun.Size = new System.Drawing.Size(256, 244);
            this.picCompShotgun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompShotgun.TabIndex = 8;
            this.picCompShotgun.TabStop = false;
            // 
            // picCompShoot
            // 
            this.picCompShoot.Image = ((System.Drawing.Image)(resources.GetObject("picCompShoot.Image")));
            this.picCompShoot.Location = new System.Drawing.Point(358, 80);
            this.picCompShoot.Name = "picCompShoot";
            this.picCompShoot.Size = new System.Drawing.Size(264, 250);
            this.picCompShoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompShoot.TabIndex = 8;
            this.picCompShoot.TabStop = false;
            // 
            // picCompLoad
            // 
            this.picCompLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCompLoad.Image = ((System.Drawing.Image)(resources.GetObject("picCompLoad.Image")));
            this.picCompLoad.Location = new System.Drawing.Point(358, 75);
            this.picCompLoad.Name = "picCompLoad";
            this.picCompLoad.Size = new System.Drawing.Size(263, 260);
            this.picCompLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCompLoad.TabIndex = 8;
            this.picCompLoad.TabStop = false;
            // 
            // picCompBlock
            // 
            this.picCompBlock.Image = ((System.Drawing.Image)(resources.GetObject("picCompBlock.Image")));
            this.picCompBlock.Location = new System.Drawing.Point(358, 75);
            this.picCompBlock.Name = "picCompBlock";
            this.picCompBlock.Size = new System.Drawing.Size(263, 264);
            this.picCompBlock.TabIndex = 7;
            this.picCompBlock.TabStop = false;
            // 
            // lblCompShotsLeft
            // 
            this.lblCompShotsLeft.AutoSize = true;
            this.lblCompShotsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompShotsLeft.Location = new System.Drawing.Point(347, 383);
            this.lblCompShotsLeft.Name = "lblCompShotsLeft";
            this.lblCompShotsLeft.Size = new System.Drawing.Size(90, 20);
            this.lblCompShotsLeft.TabIndex = 7;
            this.lblCompShotsLeft.Text = "Shots left";
            // 
            // lblCompShotsLeftCount
            // 
            this.lblCompShotsLeftCount.AutoSize = true;
            this.lblCompShotsLeftCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompShotsLeftCount.Location = new System.Drawing.Point(513, 383);
            this.lblCompShotsLeftCount.Name = "lblCompShotsLeftCount";
            this.lblCompShotsLeftCount.Size = new System.Drawing.Size(19, 20);
            this.lblCompShotsLeftCount.TabIndex = 7;
            this.lblCompShotsLeftCount.Text = "0";
            // 
            // picBoxCompStart
            // 
            this.picBoxCompStart.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCompStart.Image")));
            this.picBoxCompStart.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxCompStart.InitialImage")));
            this.picBoxCompStart.Location = new System.Drawing.Point(359, 80);
            this.picBoxCompStart.Name = "picBoxCompStart";
            this.picBoxCompStart.Size = new System.Drawing.Size(262, 255);
            this.picBoxCompStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxCompStart.TabIndex = 8;
            this.picBoxCompStart.TabStop = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(212, 242);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(214, 61);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblLooser
            // 
            this.lblLooser.AutoSize = true;
            this.lblLooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLooser.ForeColor = System.Drawing.Color.Purple;
            this.lblLooser.Location = new System.Drawing.Point(162, 170);
            this.lblLooser.Name = "lblLooser";
            this.lblLooser.Size = new System.Drawing.Size(341, 69);
            this.lblLooser.TabIndex = 5;
            this.lblLooser.Text = "You Loose!";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(351, 12);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(152, 36);
            this.lblComputer.TabIndex = 9;
            this.lblComputer.Text = "Computer";
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.Location = new System.Drawing.Point(23, 12);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(72, 36);
            this.lblYou.TabIndex = 10;
            this.lblYou.Text = "You";
            // 
            // picLine
            // 
            this.picLine.Image = ((System.Drawing.Image)(resources.GetObject("picLine.Image")));
            this.picLine.Location = new System.Drawing.Point(317, 0);
            this.picLine.Name = "picLine";
            this.picLine.Size = new System.Drawing.Size(10, 540);
            this.picLine.TabIndex = 11;
            this.picLine.TabStop = false;
            // 
            // frmShotgun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 540);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.lblLooser);
            this.Controls.Add(this.lblYourShotsLeftCount);
            this.Controls.Add(this.lblYouShotsLeft);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.picBoxCompStart);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.lblCompShotsLeftCount);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblCompShotsLeft);
            this.Controls.Add(this.picYouLoad);
            this.Controls.Add(this.picYouShoot);
            this.Controls.Add(this.picYouShotgun);
            this.Controls.Add(this.picLine);
            this.Controls.Add(this.picBoxYouStart);
            this.Controls.Add(this.picYouBlock);
            this.Controls.Add(this.picCompLoad);
            this.Controls.Add(this.picCompShotgun);
            this.Controls.Add(this.picCompShoot);
            this.Controls.Add(this.picCompBlock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShotgun";
            this.Text = "Shotgun";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYouStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouShoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouShotgun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompShotgun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompShoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCompStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxYouStart;
        private System.Windows.Forms.Label lblYourShotsLeftCount;
        private System.Windows.Forms.Label lblYouShotsLeft;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox picYouBlock;
        private System.Windows.Forms.PictureBox picYouLoad;
        private System.Windows.Forms.PictureBox picYouShoot;
        private System.Windows.Forms.PictureBox picYouShotgun;
        private System.Windows.Forms.PictureBox picCompShotgun;
        private System.Windows.Forms.PictureBox picCompShoot;
        private System.Windows.Forms.PictureBox picCompLoad;
        private System.Windows.Forms.PictureBox picCompBlock;
        private System.Windows.Forms.Label lblCompShotsLeft;
        private System.Windows.Forms.Label lblCompShotsLeftCount;
        private System.Windows.Forms.PictureBox picBoxCompStart;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblLooser;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.PictureBox picLine;
    }
}

