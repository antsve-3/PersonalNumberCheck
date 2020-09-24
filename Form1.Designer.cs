namespace PersonnummerCheck
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
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxFamilyName = new System.Windows.Forms.TextBox();
            this.tbxPersonalNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(114, 85);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(188, 20);
            this.tbxFirstName.TabIndex = 0;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // tbxFamilyName
            // 
            this.tbxFamilyName.Location = new System.Drawing.Point(114, 122);
            this.tbxFamilyName.Name = "tbxFamilyName";
            this.tbxFamilyName.Size = new System.Drawing.Size(188, 20);
            this.tbxFamilyName.TabIndex = 1;
            this.tbxFamilyName.TextChanged += new System.EventHandler(this.tbxFamilyName_TextChanged);
            // 
            // tbxPersonalNumber
            // 
            this.tbxPersonalNumber.Location = new System.Drawing.Point(114, 161);
            this.tbxPersonalNumber.Name = "tbxPersonalNumber";
            this.tbxPersonalNumber.Size = new System.Drawing.Size(188, 20);
            this.tbxPersonalNumber.TabIndex = 2;
            this.tbxPersonalNumber.Text = "YYYYMMDDXXXX";
            this.tbxPersonalNumber.TextChanged += new System.EventHandler(this.tbxPersonalNumber_TextChanged);
            this.tbxPersonalNumber.Enter += new System.EventHandler(this.tbxPersonalNumber_OnFocus);
            this.tbxPersonalNumber.Leave += new System.EventHandler(this.tbxPersonalNumber_DeFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ange namn och personnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Förnamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Efternamn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personnummer:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(64, 246);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Output";
            this.lblOutput.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(227, 204);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(19, 187);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 342);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPersonalNumber);
            this.Controls.Add(this.tbxFamilyName);
            this.Controls.Add(this.tbxFirstName);
            this.Name = "Form1";
            this.Text = "Personnummercheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxFamilyName;
        private System.Windows.Forms.TextBox tbxPersonalNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblError;
    }
}

