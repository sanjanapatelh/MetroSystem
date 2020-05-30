namespace project1
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.travel = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.metrocard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // travel
            // 
            this.travel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.travel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.travel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travel.ForeColor = System.Drawing.SystemColors.Control;
            this.travel.Location = new System.Drawing.Point(726, 437);
            this.travel.Name = "travel";
            this.travel.Size = new System.Drawing.Size(249, 79);
            this.travel.TabIndex = 0;
            this.travel.Text = "TRAVEL!!!";
            this.travel.UseVisualStyleBackColor = false;
            this.travel.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin
            // 
            this.admin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.admin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.admin.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin.Location = new System.Drawing.Point(387, 437);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(258, 79);
            this.admin.TabIndex = 1;
            this.admin.Text = "ADMIN";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // metrocard
            // 
            this.metrocard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metrocard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metrocard.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metrocard.ForeColor = System.Drawing.SystemColors.Control;
            this.metrocard.Location = new System.Drawing.Point(91, 437);
            this.metrocard.Name = "metrocard";
            this.metrocard.Size = new System.Drawing.Size(232, 79);
            this.metrocard.TabIndex = 2;
            this.metrocard.Text = "GO CASHLESS....";
            this.metrocard.UseVisualStyleBackColor = false;
            this.metrocard.Click += new System.EventHandler(this.metrocard_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1047, 561);
            this.Controls.Add(this.metrocard);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.travel);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button travel;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button metrocard;
    }
}

