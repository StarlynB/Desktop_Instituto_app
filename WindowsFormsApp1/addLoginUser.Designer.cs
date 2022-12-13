namespace WindowsFormsApp1
{
    partial class addLoginUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtADDemail = new System.Windows.Forms.TextBox();
            this.txtADDpassword = new System.Windows.Forms.TextBox();
            this.btnADDloginUser = new System.Windows.Forms.Button();
            this.btnSalirADDlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtADDemail
            // 
            this.txtADDemail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtADDemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtADDemail.Location = new System.Drawing.Point(194, 215);
            this.txtADDemail.Name = "txtADDemail";
            this.txtADDemail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtADDemail.Size = new System.Drawing.Size(151, 20);
            this.txtADDemail.TabIndex = 2;
            // 
            // txtADDpassword
            // 
            this.txtADDpassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtADDpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtADDpassword.Location = new System.Drawing.Point(194, 255);
            this.txtADDpassword.Name = "txtADDpassword";
            this.txtADDpassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtADDpassword.Size = new System.Drawing.Size(148, 20);
            this.txtADDpassword.TabIndex = 3;
            // 
            // btnADDloginUser
            // 
            this.btnADDloginUser.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnADDloginUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnADDloginUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDloginUser.Location = new System.Drawing.Point(269, 309);
            this.btnADDloginUser.Name = "btnADDloginUser";
            this.btnADDloginUser.Size = new System.Drawing.Size(75, 33);
            this.btnADDloginUser.TabIndex = 4;
            this.btnADDloginUser.Text = "Guardar";
            this.btnADDloginUser.UseVisualStyleBackColor = true;
            this.btnADDloginUser.Click += new System.EventHandler(this.btnADDloginUser_Click);
            // 
            // btnSalirADDlogin
            // 
            this.btnSalirADDlogin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalirADDlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirADDlogin.Location = new System.Drawing.Point(343, 405);
            this.btnSalirADDlogin.Name = "btnSalirADDlogin";
            this.btnSalirADDlogin.Size = new System.Drawing.Size(75, 33);
            this.btnSalirADDlogin.TabIndex = 5;
            this.btnSalirADDlogin.Text = "Salir";
            this.btnSalirADDlogin.UseVisualStyleBackColor = true;
            this.btnSalirADDlogin.Click += new System.EventHandler(this.btnSalirADDlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.agregarusers;
            this.pictureBox1.Location = new System.Drawing.Point(145, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // addLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirADDlogin);
            this.Controls.Add(this.btnADDloginUser);
            this.Controls.Add(this.txtADDpassword);
            this.Controls.Add(this.txtADDemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addLoginUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addLoginUser";
            this.Load += new System.EventHandler(this.addLoginUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtADDemail;
        private System.Windows.Forms.TextBox txtADDpassword;
        private System.Windows.Forms.Button btnADDloginUser;
        private System.Windows.Forms.Button btnSalirADDlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}