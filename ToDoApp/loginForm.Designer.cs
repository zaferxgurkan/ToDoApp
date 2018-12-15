namespace ToDoApp
{
    partial class loginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.subtitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.link_lbl_singup = new System.Windows.Forms.LinkLabel();
            this.btn_giris = new System.Windows.Forms.Button();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txtbx_pass = new System.Windows.Forms.TextBox();
            this.txtbx_userName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Location = new System.Drawing.Point(69, 62);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(143, 13);
            this.subtitle.TabIndex = 15;
            this.subtitle.Text = "Gününüzü Daha İyi Planlayın";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.Location = new System.Drawing.Point(79, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(122, 32);
            this.title.TabIndex = 14;
            this.title.Text = "ToDoApp";
            // 
            // link_lbl_singup
            // 
            this.link_lbl_singup.AutoSize = true;
            this.link_lbl_singup.Location = new System.Drawing.Point(69, 197);
            this.link_lbl_singup.Name = "link_lbl_singup";
            this.link_lbl_singup.Size = new System.Drawing.Size(132, 13);
            this.link_lbl_singup.TabIndex = 13;
            this.link_lbl_singup.TabStop = true;
            this.link_lbl_singup.Text = "Kayıt Olmak İçin Tıklayınız!";
            this.link_lbl_singup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_singup_LinkClicked);
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(174, 160);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 12;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(41, 131);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(43, 13);
            this.lbl_pass.TabIndex = 11;
            this.lbl_pass.Text = "Parola :";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(14, 97);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(70, 13);
            this.lbl_UserName.TabIndex = 10;
            this.lbl_UserName.Text = "Kullanıcı Adı :";
            // 
            // txtbx_pass
            // 
            this.txtbx_pass.Location = new System.Drawing.Point(107, 131);
            this.txtbx_pass.Name = "txtbx_pass";
            this.txtbx_pass.Size = new System.Drawing.Size(142, 20);
            this.txtbx_pass.TabIndex = 9;
            this.txtbx_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_KeyDown);
            // 
            // txtbx_userName
            // 
            this.txtbx_userName.Location = new System.Drawing.Point(107, 94);
            this.txtbx_userName.Name = "txtbx_userName";
            this.txtbx_userName.Size = new System.Drawing.Size(142, 20);
            this.txtbx_userName.TabIndex = 8;
            this.txtbx_userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userName_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.close_app_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 257);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.link_lbl_singup);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txtbx_pass);
            this.Controls.Add(this.txtbx_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.Text = "ToDoApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.LinkLabel link_lbl_singup;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txtbx_pass;
        private System.Windows.Forms.TextBox txtbx_userName;
        private System.Windows.Forms.Button button1;
    }
}

