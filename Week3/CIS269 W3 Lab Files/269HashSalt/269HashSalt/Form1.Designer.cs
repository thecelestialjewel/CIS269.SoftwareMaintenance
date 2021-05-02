namespace _269HashSalt
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.btnGenSalt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSHPass = new System.Windows.Forms.TextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(121, 6);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(421, 29);
            this.txtPass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salt:";
            // 
            // txtSalt
            // 
            this.txtSalt.Location = new System.Drawing.Point(121, 47);
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(318, 29);
            this.txtSalt.TabIndex = 3;
            // 
            // btnGenSalt
            // 
            this.btnGenSalt.Location = new System.Drawing.Point(445, 45);
            this.btnGenSalt.Name = "btnGenSalt";
            this.btnGenSalt.Size = new System.Drawing.Size(97, 35);
            this.btnGenSalt.TabIndex = 4;
            this.btnGenSalt.Text = "Generate";
            this.btnGenSalt.UseVisualStyleBackColor = true;
            this.btnGenSalt.Click += new System.EventHandler(this.btnGenSalt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "SHPass:";
            // 
            // txtSHPass
            // 
            this.txtSHPass.Location = new System.Drawing.Point(121, 153);
            this.txtSHPass.Multiline = true;
            this.txtSHPass.Name = "txtSHPass";
            this.txtSHPass.ReadOnly = true;
            this.txtSHPass.Size = new System.Drawing.Size(421, 76);
            this.txtSHPass.TabIndex = 6;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(106, 91);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(144, 46);
            this.btnHash.TabIndex = 7;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 241);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.txtSHPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenSalt);
            this.Controls.Add(this.txtSalt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.Button btnGenSalt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSHPass;
        private System.Windows.Forms.Button btnHash;
    }
}

