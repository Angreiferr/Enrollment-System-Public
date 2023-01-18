namespace Enrollment_System.Menus
{
    partial class PaymentFrm
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
            this.btnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTuition = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblMisc = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(78, 128);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tuition Fees: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Other School Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Miscellaneous Fees:";
            // 
            // lblTuition
            // 
            this.lblTuition.AutoSize = true;
            this.lblTuition.Location = new System.Drawing.Point(158, 20);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(44, 13);
            this.lblTuition.TabIndex = 4;
            this.lblTuition.Text = "variable";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(158, 42);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(44, 13);
            this.lblOther.TabIndex = 5;
            this.lblOther.Text = "variable";
            // 
            // lblMisc
            // 
            this.lblMisc.AutoSize = true;
            this.lblMisc.Location = new System.Drawing.Point(158, 71);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(44, 13);
            this.lblMisc.TabIndex = 6;
            this.lblMisc.Text = "variable";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(158, 96);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "variable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total:";
            // 
            // PaymentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 165);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMisc);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblTuition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPay);
            this.Name = "PaymentFrm";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTuition;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblMisc;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
    }
}