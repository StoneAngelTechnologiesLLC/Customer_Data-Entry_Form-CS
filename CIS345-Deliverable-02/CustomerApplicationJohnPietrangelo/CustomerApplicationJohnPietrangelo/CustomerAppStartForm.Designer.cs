namespace CustomerApplicationJohnPietrangelo
{
    partial class CustomerAppStartForm
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
            this.appTitleLbl = new System.Windows.Forms.Label();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.listAllCustomerBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appTitleLbl
            // 
            this.appTitleLbl.AutoSize = true;
            this.appTitleLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appTitleLbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.appTitleLbl.Location = new System.Drawing.Point(33, 32);
            this.appTitleLbl.Name = "appTitleLbl";
            this.appTitleLbl.Size = new System.Drawing.Size(428, 34);
            this.appTitleLbl.TabIndex = 0;
            this.appTitleLbl.Text = "Customer Information Manager";
            this.appTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.AutoSize = true;
            this.addCustomerBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.Location = new System.Drawing.Point(169, 103);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(143, 28);
            this.addCustomerBtn.TabIndex = 1;
            this.addCustomerBtn.Text = "Add a Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // listAllCustomerBtn
            // 
            this.listAllCustomerBtn.AutoSize = true;
            this.listAllCustomerBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAllCustomerBtn.Location = new System.Drawing.Point(169, 166);
            this.listAllCustomerBtn.Name = "listAllCustomerBtn";
            this.listAllCustomerBtn.Size = new System.Drawing.Size(143, 28);
            this.listAllCustomerBtn.TabIndex = 2;
            this.listAllCustomerBtn.Text = "List All Customers";
            this.listAllCustomerBtn.UseVisualStyleBackColor = true;
            this.listAllCustomerBtn.Click += new System.EventHandler(this.listAllCustomerBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(374, 221);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 28);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // CustomerAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.listAllCustomerBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.appTitleLbl);
            this.Name = "CustomerAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Manager Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appTitleLbl;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button listAllCustomerBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

