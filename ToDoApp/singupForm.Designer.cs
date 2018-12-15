namespace ToDoApp
{
    partial class singupForm
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
            this.subtitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txtbx_pass = new System.Windows.Forms.TextBox();
            this.txtbx_userName = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtbx_email = new System.Windows.Forms.TextBox();
            this.close_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Location = new System.Drawing.Point(75, 67);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(143, 13);
            this.subtitle.TabIndex = 22;
            this.subtitle.Text = "Gününüzü Daha İyi Planlayın";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.Location = new System.Drawing.Point(85, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(122, 32);
            this.title.TabIndex = 21;
            this.title.Text = "ToDoApp";
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.Location = new System.Drawing.Point(183, 214);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydol.TabIndex = 20;
            this.btn_kaydol.Text = "Kayıt";
            this.btn_kaydol.UseVisualStyleBackColor = true;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(47, 136);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(43, 13);
            this.lbl_pass.TabIndex = 19;
            this.lbl_pass.Text = "Parola :";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(20, 102);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(70, 13);
            this.lbl_UserName.TabIndex = 18;
            this.lbl_UserName.Text = "Kullanıcı Adı :";
            // 
            // txtbx_pass
            // 
            this.txtbx_pass.Location = new System.Drawing.Point(113, 136);
            this.txtbx_pass.Name = "txtbx_pass";
            this.txtbx_pass.Size = new System.Drawing.Size(145, 20);
            this.txtbx_pass.TabIndex = 17;
            // 
            // txtbx_userName
            // 
            this.txtbx_userName.Location = new System.Drawing.Point(113, 99);
            this.txtbx_userName.Name = "txtbx_userName";
            this.txtbx_userName.Size = new System.Drawing.Size(145, 20);
            this.txtbx_userName.TabIndex = 16;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(40, 172);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 13);
            this.lbl_email.TabIndex = 23;
            this.lbl_email.Text = "E-Posta :";
            // 
            // txtbx_email
            // 
            this.txtbx_email.Location = new System.Drawing.Point(113, 172);
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(145, 20);
            this.txtbx_email.TabIndex = 24;
            // 
            // close_form
            // 
            this.close_form.Location = new System.Drawing.Point(91, 214);
            this.close_form.Name = "close_form";
            this.close_form.Size = new System.Drawing.Size(75, 23);
            this.close_form.TabIndex = 25;
            this.close_form.Text = "Kapat";
            this.close_form.UseVisualStyleBackColor = true;
            this.close_form.Click += new System.EventHandler(this.close_form_Click);
            // 
            // singupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.close_form);
            this.Controls.Add(this.txtbx_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn_kaydol);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txtbx_pass);
            this.Controls.Add(this.txtbx_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "singupForm";
            this.Text = "singupForm";
            this.Load += new System.EventHandler(this.singupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txtbx_pass;
        private System.Windows.Forms.TextBox txtbx_userName;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.Button close_form;
    }
}