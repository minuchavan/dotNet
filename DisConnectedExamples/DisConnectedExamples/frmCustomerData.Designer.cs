namespace DisConnectedExamples
{
    partial class frmCustomerData
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.Label();
            this.txtcustomerId = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.contactname = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtcontactname = new System.Windows.Forms.TextBox();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnMovePreveious = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(224, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Details ";
            // 
            // customerId
            // 
            this.customerId.AutoSize = true;
            this.customerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerId.Location = new System.Drawing.Point(179, 120);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(118, 24);
            this.customerId.TabIndex = 1;
            this.customerId.Text = "Customer_ID";
            // 
            // txtcustomerId
            // 
            this.txtcustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerId.Location = new System.Drawing.Point(356, 114);
            this.txtcustomerId.MaximumSize = new System.Drawing.Size(300, 150);
            this.txtcustomerId.Name = "txtcustomerId";
            this.txtcustomerId.Size = new System.Drawing.Size(205, 30);
            this.txtcustomerId.TabIndex = 2;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(179, 213);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(126, 24);
            this.city.TabIndex = 3;
            this.city.Text = "Customer City";
            // 
            // contactname
            // 
            this.contactname.AutoSize = true;
            this.contactname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactname.Location = new System.Drawing.Point(179, 167);
            this.contactname.Name = "contactname";
            this.contactname.Size = new System.Drawing.Size(147, 24);
            this.contactname.TabIndex = 4;
            this.contactname.Text = "Customer Name";
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(356, 213);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(205, 30);
            this.txtcity.TabIndex = 5;
            // 
            // txtcontactname
            // 
            this.txtcontactname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactname.Location = new System.Drawing.Point(356, 167);
            this.txtcontactname.Name = "txtcontactname";
            this.txtcontactname.Size = new System.Drawing.Size(205, 30);
            this.txtcontactname.TabIndex = 6;
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveFirst.Location = new System.Drawing.Point(175, 274);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(95, 44);
            this.btnMoveFirst.TabIndex = 7;
            this.btnMoveFirst.Text = "<<";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnMovePreveious
            // 
            this.btnMovePreveious.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovePreveious.Location = new System.Drawing.Point(309, 274);
            this.btnMovePreveious.Name = "btnMovePreveious";
            this.btnMovePreveious.Size = new System.Drawing.Size(95, 44);
            this.btnMovePreveious.TabIndex = 8;
            this.btnMovePreveious.Text = "<";
            this.btnMovePreveious.UseVisualStyleBackColor = true;
            this.btnMovePreveious.Click += new System.EventHandler(this.btnMovePreveious_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveNext.Location = new System.Drawing.Point(428, 274);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(96, 44);
            this.btnMoveNext.TabIndex = 9;
            this.btnMoveNext.Text = ">";
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveLast.Location = new System.Drawing.Point(552, 274);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(96, 44);
            this.btnMoveLast.TabIndex = 10;
            this.btnMoveLast.Text = ">>";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(175, 352);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 44);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(309, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 44);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(428, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 44);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Modify";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(552, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 44);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnMoveLast);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePreveious);
            this.Controls.Add(this.btnMoveFirst);
            this.Controls.Add(this.txtcontactname);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.contactname);
            this.Controls.Add(this.city);
            this.Controls.Add(this.txtcustomerId);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomerData";
            this.Text = "Infoway Customer Form";
            this.Load += new System.EventHandler(this.frmCustomerData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerId;
        private System.Windows.Forms.TextBox txtcustomerId;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label contactname;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtcontactname;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnMovePreveious;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}