namespace CustomerApplicationJohnPietrangelo
{
    partial class AddCustomerForm
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
            this.addCustInfoLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveAndExitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxBx = new System.Windows.Forms.TextBox();
            this.addressTxBx = new System.Windows.Forms.TextBox();
            this.zipTxBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addCustInfoLbl
            // 
            this.addCustInfoLbl.AutoSize = true;
            this.addCustInfoLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addCustInfoLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustInfoLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addCustInfoLbl.Location = new System.Drawing.Point(47, 9);
            this.addCustInfoLbl.Name = "addCustInfoLbl";
            this.addCustInfoLbl.Size = new System.Drawing.Size(385, 36);
            this.addCustInfoLbl.TabIndex = 0;
            this.addCustInfoLbl.Text = "Add Customer Information";
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(36, 226);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 29);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveAndExitBtn
            // 
            this.saveAndExitBtn.AutoSize = true;
            this.saveAndExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.saveAndExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveAndExitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAndExitBtn.Location = new System.Drawing.Point(372, 226);
            this.saveAndExitBtn.Name = "saveAndExitBtn";
            this.saveAndExitBtn.Size = new System.Drawing.Size(102, 29);
            this.saveAndExitBtn.TabIndex = 2;
            this.saveAndExitBtn.Text = "Save and Exit";
            this.saveAndExitBtn.UseVisualStyleBackColor = true;
            this.saveAndExitBtn.Click += new System.EventHandler(this.saveAndExitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zip:";
            // 
            // nameTxBx
            // 
            this.nameTxBx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxBx.Location = new System.Drawing.Point(130, 72);
            this.nameTxBx.Name = "nameTxBx";
            this.nameTxBx.Size = new System.Drawing.Size(302, 26);
            this.nameTxBx.TabIndex = 6;
            // 
            // addressTxBx
            // 
            this.addressTxBx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxBx.Location = new System.Drawing.Point(130, 122);
            this.addressTxBx.Name = "addressTxBx";
            this.addressTxBx.Size = new System.Drawing.Size(302, 26);
            this.addressTxBx.TabIndex = 7;
            // 
            // zipTxBx
            // 
            this.zipTxBx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTxBx.Location = new System.Drawing.Point(130, 171);
            this.zipTxBx.Name = "zipTxBx";
            this.zipTxBx.Size = new System.Drawing.Size(100, 26);
            this.zipTxBx.TabIndex = 8;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.zipTxBx);
            this.Controls.Add(this.addressTxBx);
            this.Controls.Add(this.nameTxBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveAndExitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addCustInfoLbl);
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addCustInfoLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveAndExitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxBx;
        private System.Windows.Forms.TextBox addressTxBx;
        private System.Windows.Forms.TextBox zipTxBx;
    }
}