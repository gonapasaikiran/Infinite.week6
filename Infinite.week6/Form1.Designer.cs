namespace Infinite.week6
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
            this.TxtEmployeeNo = new System.Windows.Forms.TextBox();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.TxtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioconsultant = new System.Windows.Forms.RadioButton();
            this.grpEmployeeType = new System.Windows.Forms.GroupBox();
            this.radiopayroll = new System.Windows.Forms.RadioButton();
            this.LblMessage = new System.Windows.Forms.Label();
            this.grpEmployeeType.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEmployeeNo
            // 
            this.TxtEmployeeNo.Location = new System.Drawing.Point(207, 62);
            this.TxtEmployeeNo.Name = "TxtEmployeeNo";
            this.TxtEmployeeNo.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeNo.TabIndex = 0;
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Location = new System.Drawing.Point(207, 101);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeName.TabIndex = 1;
            // 
            // TxtEmployeeSalary
            // 
            this.TxtEmployeeSalary.Location = new System.Drawing.Point(207, 145);
            this.TxtEmployeeSalary.Name = "TxtEmployeeSalary";
            this.TxtEmployeeSalary.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeSalary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioconsultant
            // 
            this.radioconsultant.AutoSize = true;
            this.radioconsultant.Location = new System.Drawing.Point(37, 61);
            this.radioconsultant.Name = "radioconsultant";
            this.radioconsultant.Size = new System.Drawing.Size(75, 17);
            this.radioconsultant.TabIndex = 9;
            this.radioconsultant.TabStop = true;
            this.radioconsultant.Text = "Consultant";
            this.radioconsultant.UseVisualStyleBackColor = true;
            // 
            // grpEmployeeType
            // 
            this.grpEmployeeType.Controls.Add(this.radiopayroll);
            this.grpEmployeeType.Controls.Add(this.radioconsultant);
            this.grpEmployeeType.Location = new System.Drawing.Point(372, 101);
            this.grpEmployeeType.Name = "grpEmployeeType";
            this.grpEmployeeType.Size = new System.Drawing.Size(200, 100);
            this.grpEmployeeType.TabIndex = 11;
            this.grpEmployeeType.TabStop = false;
            this.grpEmployeeType.Text = "EmployeeType";
            // 
            // radiopayroll
            // 
            this.radiopayroll.AutoSize = true;
            this.radiopayroll.Location = new System.Drawing.Point(37, 23);
            this.radiopayroll.Name = "radiopayroll";
            this.radiopayroll.Size = new System.Drawing.Size(56, 17);
            this.radiopayroll.TabIndex = 8;
            this.radiopayroll.TabStop = true;
            this.radiopayroll.Text = "Payroll";
            this.radiopayroll.UseVisualStyleBackColor = true;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(84, 252);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(35, 13);
            this.LblMessage.TabIndex = 12;
            this.LblMessage.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.grpEmployeeType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEmployeeSalary);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.TxtEmployeeNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpEmployeeType.ResumeLayout(false);
            this.grpEmployeeType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEmployeeNo;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.TextBox TxtEmployeeSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioconsultant;
        private System.Windows.Forms.GroupBox grpEmployeeType;
        private System.Windows.Forms.RadioButton radiopayroll;
        private System.Windows.Forms.Label LblMessage;
    }
}

