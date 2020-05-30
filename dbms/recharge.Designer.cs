namespace project1
{
    partial class recharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recharge));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.cardno = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.refill = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHONE NO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "RECHARGE^^";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "CARD NO";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "AMOUNT";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(257, 150);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(142, 20);
            this.phone.TabIndex = 4;
            // 
            // cardno
            // 
            this.cardno.Location = new System.Drawing.Point(257, 242);
            this.cardno.Name = "cardno";
            this.cardno.Size = new System.Drawing.Size(142, 20);
            this.cardno.TabIndex = 5;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(257, 319);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(142, 20);
            this.amount.TabIndex = 6;
            // 
            // refill
            // 
            this.refill.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refill.Location = new System.Drawing.Point(257, 396);
            this.refill.Name = "refill";
            this.refill.Size = new System.Drawing.Size(142, 36);
            this.refill.TabIndex = 7;
            this.refill.Text = "REFILL";
            this.refill.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(37, 420);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 36);
            this.back.TabIndex = 8;
            this.back.Text = "<--BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // recharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(466, 505);
            this.Controls.Add(this.back);
            this.Controls.Add(this.refill);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.cardno);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "recharge";
            this.Text = "recharge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox cardno;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button refill;
        private System.Windows.Forms.Button back;
    }
}