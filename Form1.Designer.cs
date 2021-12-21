
namespace inlämmningsuppgift2
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
            this.btnLadda = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnSkjut = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lableCountDown = new System.Windows.Forms.Label();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.lablePlayerAmmo = new System.Windows.Forms.Label();
            this.labelComputerAmmo = new System.Windows.Forms.Label();
            this.countDown = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLadda
            // 
            this.btnLadda.Location = new System.Drawing.Point(66, 152);
            this.btnLadda.Name = "btnLadda";
            this.btnLadda.Size = new System.Drawing.Size(75, 23);
            this.btnLadda.TabIndex = 0;
            this.btnLadda.Text = "Ladda";
            this.btnLadda.UseVisualStyleBackColor = true;
            this.btnLadda.Click += new System.EventHandler(this.btnLadda_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(66, 181);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 1;
            this.btnBlock.Text = "Blocka";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnSkjut
            // 
            this.btnSkjut.Location = new System.Drawing.Point(66, 210);
            this.btnSkjut.Name = "btnSkjut";
            this.btnSkjut.Size = new System.Drawing.Size(75, 23);
            this.btnSkjut.TabIndex = 2;
            this.btnSkjut.Text = "Skjuta";
            this.btnSkjut.UseVisualStyleBackColor = true;
            this.btnSkjut.Click += new System.EventHandler(this.btnSkjut_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(416, 399);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Computer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // lableCountDown
            // 
            this.lableCountDown.AutoSize = true;
            this.lableCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableCountDown.Location = new System.Drawing.Point(440, 204);
            this.lableCountDown.Name = "lableCountDown";
            this.lableCountDown.Size = new System.Drawing.Size(24, 25);
            this.lableCountDown.TabIndex = 9;
            this.lableCountDown.Text = "0";
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(66, 239);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(75, 23);
            this.btnShotgun.TabIndex = 11;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // lablePlayerAmmo
            // 
            this.lablePlayerAmmo.AutoSize = true;
            this.lablePlayerAmmo.Location = new System.Drawing.Point(153, 297);
            this.lablePlayerAmmo.Name = "lablePlayerAmmo";
            this.lablePlayerAmmo.Size = new System.Drawing.Size(48, 13);
            this.lablePlayerAmmo.TabIndex = 12;
            this.lablePlayerAmmo.Text = "Ammo: 0";
            // 
            // labelComputerAmmo
            // 
            this.labelComputerAmmo.AutoSize = true;
            this.labelComputerAmmo.Location = new System.Drawing.Point(736, 297);
            this.labelComputerAmmo.Name = "labelComputerAmmo";
            this.labelComputerAmmo.Size = new System.Drawing.Size(48, 13);
            this.labelComputerAmmo.TabIndex = 13;
            this.labelComputerAmmo.Text = "Ammo: 0";
            // 
            // countDown
            // 
            this.countDown.Interval = 1000;
            this.countDown.Tick += new System.EventHandler(this.countDownTime);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::inlämmningsuppgift2.Properties.Resources.question_mark;
            this.pictureBox2.Location = new System.Drawing.Point(536, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inlämmningsuppgift2.Properties.Resources.question_mark;
            this.pictureBox1.Location = new System.Drawing.Point(205, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 457);
            this.Controls.Add(this.labelComputerAmmo);
            this.Controls.Add(this.lablePlayerAmmo);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.lableCountDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSkjut);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnLadda);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLadda;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnSkjut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lableCountDown;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Label lablePlayerAmmo;
        private System.Windows.Forms.Label labelComputerAmmo;
        private System.Windows.Forms.Timer countDown;
    }
}

