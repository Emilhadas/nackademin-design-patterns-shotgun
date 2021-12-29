
namespace Shotgun_1._0
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tbxYourAmmo = new System.Windows.Forms.TextBox();
            this.tbxCPUAmmo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.pbxLoad = new System.Windows.Forms.PictureBox();
            this.pbxShoot = new System.Windows.Forms.PictureBox();
            this.pbxBlock = new System.Windows.Forms.PictureBox();
            this.pbxCPUReload = new System.Windows.Forms.PictureBox();
            this.pbxCPUShoot = new System.Windows.Forms.PictureBox();
            this.pbxCPUShield = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.lbxScoresheet = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCPUReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCPUShoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCPUShield)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(140, 16);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Ladda";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(140, 45);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 16;
            this.btnBlock.Text = "Blocka";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(140, 78);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(75, 23);
            this.btnShoot.TabIndex = 17;
            this.btnShoot.Text = "Skjut!";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Visible = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(140, 241);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 18;
            this.btnRestart.Text = "Börja om";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // tbxYourAmmo
            // 
            this.tbxYourAmmo.Location = new System.Drawing.Point(6, 45);
            this.tbxYourAmmo.Name = "tbxYourAmmo";
            this.tbxYourAmmo.ReadOnly = true;
            this.tbxYourAmmo.Size = new System.Drawing.Size(100, 23);
            this.tbxYourAmmo.TabIndex = 19;
            // 
            // tbxCPUAmmo
            // 
            this.tbxCPUAmmo.Location = new System.Drawing.Point(253, 45);
            this.tbxCPUAmmo.Name = "tbxCPUAmmo";
            this.tbxCPUAmmo.ReadOnly = true;
            this.tbxCPUAmmo.Size = new System.Drawing.Size(100, 23);
            this.tbxCPUAmmo.TabIndex = 20;
            this.tbxCPUAmmo.TextChanged += new System.EventHandler(this.tbxCPU_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dina skott";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Datorns skott";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(253, 121);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(0, 15);
            this.lblAction.TabIndex = 23;
            // 
            // pbxLoad
            // 
            this.pbxLoad.Image = global::Shotgun_1._0.Properties.Resources.Reload;
            this.pbxLoad.InitialImage = global::Shotgun_1._0.Properties.Resources.Reload;
            this.pbxLoad.Location = new System.Drawing.Point(6, 78);
            this.pbxLoad.Name = "pbxLoad";
            this.pbxLoad.Size = new System.Drawing.Size(100, 100);
            this.pbxLoad.TabIndex = 24;
            this.pbxLoad.TabStop = false;
            this.pbxLoad.Visible = false;
            // 
            // pbxShoot
            // 
            this.pbxShoot.Image = global::Shotgun_1._0.Properties.Resources.Shotgun;
            this.pbxShoot.Location = new System.Drawing.Point(6, 269);
            this.pbxShoot.Name = "pbxShoot";
            this.pbxShoot.Size = new System.Drawing.Size(100, 100);
            this.pbxShoot.TabIndex = 25;
            this.pbxShoot.TabStop = false;
            this.pbxShoot.Visible = false;
            // 
            // pbxBlock
            // 
            this.pbxBlock.Image = global::Shotgun_1._0.Properties.Resources.Shield;
            this.pbxBlock.Location = new System.Drawing.Point(6, 173);
            this.pbxBlock.Name = "pbxBlock";
            this.pbxBlock.Size = new System.Drawing.Size(100, 100);
            this.pbxBlock.TabIndex = 26;
            this.pbxBlock.TabStop = false;
            this.pbxBlock.Visible = false;
            // 
            // pbxCPUReload
            // 
            this.pbxCPUReload.Image = global::Shotgun_1._0.Properties.Resources.Reload;
            this.pbxCPUReload.InitialImage = global::Shotgun_1._0.Properties.Resources.Reload;
            this.pbxCPUReload.Location = new System.Drawing.Point(253, 78);
            this.pbxCPUReload.Name = "pbxCPUReload";
            this.pbxCPUReload.Size = new System.Drawing.Size(100, 100);
            this.pbxCPUReload.TabIndex = 27;
            this.pbxCPUReload.TabStop = false;
            this.pbxCPUReload.Visible = false;
            // 
            // pbxCPUShoot
            // 
            this.pbxCPUShoot.Image = global::Shotgun_1._0.Properties.Resources.Shotgun;
            this.pbxCPUShoot.Location = new System.Drawing.Point(253, 269);
            this.pbxCPUShoot.Name = "pbxCPUShoot";
            this.pbxCPUShoot.Size = new System.Drawing.Size(100, 100);
            this.pbxCPUShoot.TabIndex = 28;
            this.pbxCPUShoot.TabStop = false;
            this.pbxCPUShoot.Visible = false;
            // 
            // pbxCPUShield
            // 
            this.pbxCPUShield.Image = global::Shotgun_1._0.Properties.Resources.Shield;
            this.pbxCPUShield.Location = new System.Drawing.Point(253, 173);
            this.pbxCPUShield.Name = "pbxCPUShield";
            this.pbxCPUShield.Size = new System.Drawing.Size(100, 100);
            this.pbxCPUShield.TabIndex = 29;
            this.pbxCPUShield.TabStop = false;
            this.pbxCPUShield.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShotgun);
            this.groupBox1.Controls.Add(this.pbxCPUShield);
            this.groupBox1.Controls.Add(this.pbxCPUShoot);
            this.groupBox1.Controls.Add(this.pbxCPUReload);
            this.groupBox1.Controls.Add(this.pbxBlock);
            this.groupBox1.Controls.Add(this.pbxShoot);
            this.groupBox1.Controls.Add(this.pbxLoad);
            this.groupBox1.Controls.Add(this.lblAction);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxCPUAmmo);
            this.groupBox1.Controls.Add(this.tbxYourAmmo);
            this.groupBox1.Controls.Add(this.btnRestart);
            this.groupBox1.Controls.Add(this.btnShoot);
            this.groupBox1.Controls.Add(this.btnBlock);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 383);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shotgun";
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(140, 164);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(75, 23);
            this.btnShotgun.TabIndex = 16;
            this.btnShotgun.Text = "Shotgun!!!";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Visible = false;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // lbxScoresheet
            // 
            this.lbxScoresheet.FormattingEnabled = true;
            this.lbxScoresheet.ItemHeight = 15;
            this.lbxScoresheet.Location = new System.Drawing.Point(442, 19);
            this.lbxScoresheet.Name = "lbxScoresheet";
            this.lbxScoresheet.Size = new System.Drawing.Size(346, 364);
            this.lbxScoresheet.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxScoresheet);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Shotgun";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCPUReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCPUShoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCPUShield)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox tbxYourAmmo;
        private System.Windows.Forms.TextBox tbxCPUAmmo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.PictureBox pbxLoad;
        private System.Windows.Forms.PictureBox pbxShoot;
        private System.Windows.Forms.PictureBox pbxBlock;
        private System.Windows.Forms.PictureBox pbxCPUReload;
        private System.Windows.Forms.PictureBox pbxCPUShoot;
        private System.Windows.Forms.PictureBox pbxCPUShield;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.ListBox lbxScoresheet;
    }
}

