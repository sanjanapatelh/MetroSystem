namespace project1
{
    partial class gocashless
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gocashless));
            this.getnewcard = new System.Windows.Forms.Button();
            this.checkbalance = new System.Windows.Forms.Button();
            this.recharge = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // getnewcard
            // 
            this.getnewcard.BackColor = System.Drawing.SystemColors.WindowText;
            this.getnewcard.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getnewcard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getnewcard.Location = new System.Drawing.Point(715, 230);
            this.getnewcard.Name = "getnewcard";
            this.getnewcard.Size = new System.Drawing.Size(205, 45);
            this.getnewcard.TabIndex = 0;
            this.getnewcard.Text = "GET NEW CARD";
            this.getnewcard.UseVisualStyleBackColor = false;
            this.getnewcard.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbalance
            // 
            this.checkbalance.BackColor = System.Drawing.SystemColors.WindowText;
            this.checkbalance.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbalance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkbalance.Location = new System.Drawing.Point(715, 313);
            this.checkbalance.Name = "checkbalance";
            this.checkbalance.Size = new System.Drawing.Size(205, 45);
            this.checkbalance.TabIndex = 1;
            this.checkbalance.Text = "CHECK BALANCE";
            this.checkbalance.UseVisualStyleBackColor = false;
            this.checkbalance.Click += new System.EventHandler(this.button2_Click);
            // 
            // recharge
            // 
            this.recharge.BackColor = System.Drawing.SystemColors.WindowText;
            this.recharge.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recharge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recharge.Location = new System.Drawing.Point(715, 392);
            this.recharge.Name = "recharge";
            this.recharge.Size = new System.Drawing.Size(205, 42);
            this.recharge.TabIndex = 2;
            this.recharge.Text = "RECHARGE";
            this.recharge.UseVisualStyleBackColor = false;
            this.recharge.Click += new System.EventHandler(this.recharge_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.Location = new System.Drawing.Point(170, 220);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(358, 229);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button4.Location = new System.Drawing.Point(264, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(568, 123);
            this.button4.TabIndex = 4;
            this.button4.Text = "GO CASHLESS!!!!!!";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // gocashless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1044, 545);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.recharge);
            this.Controls.Add(this.checkbalance);
            this.Controls.Add(this.getnewcard);
            this.Name = "gocashless";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "metrocard";
            this.Load += new System.EventHandler(this.gocashless_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getnewcard;
        private System.Windows.Forms.Button checkbalance;
        private System.Windows.Forms.Button recharge;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button4;
    }
}