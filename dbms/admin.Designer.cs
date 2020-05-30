namespace project1
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hire = new System.Windows.Forms.Button();
            this.getdetails = new System.Windows.Forms.Button();
            this.fire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(302, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADMIN:)";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 231);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hire
            // 
            this.hire.BackColor = System.Drawing.SystemColors.WindowText;
            this.hire.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hire.Location = new System.Drawing.Point(674, 203);
            this.hire.Name = "hire";
            this.hire.Size = new System.Drawing.Size(215, 59);
            this.hire.TabIndex = 2;
            this.hire.Text = "HIRE";
            this.hire.UseVisualStyleBackColor = false;
            this.hire.Click += new System.EventHandler(this.hire_Click);
            // 
            // getdetails
            // 
            this.getdetails.BackColor = System.Drawing.SystemColors.WindowText;
            this.getdetails.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getdetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getdetails.Location = new System.Drawing.Point(674, 397);
            this.getdetails.Name = "getdetails";
            this.getdetails.Size = new System.Drawing.Size(215, 59);
            this.getdetails.TabIndex = 3;
            this.getdetails.Text = "GET DETAILS";
            this.getdetails.UseVisualStyleBackColor = false;
            this.getdetails.Click += new System.EventHandler(this.button3_Click);
            // 
            // fire
            // 
            this.fire.BackColor = System.Drawing.SystemColors.WindowText;
            this.fire.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fire.Location = new System.Drawing.Point(674, 293);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(216, 55);
            this.fire.TabIndex = 4;
            this.fire.Text = "FIRE";
            this.fire.UseVisualStyleBackColor = false;
            this.fire.Click += new System.EventHandler(this.fire_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 531);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.getdetails);
            this.Controls.Add(this.hire);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "admin";
            this.Text = "admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hire;
        private System.Windows.Forms.Button getdetails;
        private System.Windows.Forms.Button fire;
    }
}