
namespace stok
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kULLANICIİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kULLANICIEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kULLANICISİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yARDIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yARDIMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnbarkod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnphone = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.kULLANICIİŞLEMLERİToolStripMenuItem,
            this.yARDIMToolStripMenuItem,
            this.yARDIMToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem});
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIS";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // kULLANICIİŞLEMLERİToolStripMenuItem
            // 
            this.kULLANICIİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kULLANICIEKLEToolStripMenuItem,
            this.kULLANICISİLToolStripMenuItem});
            this.kULLANICIİŞLEMLERİToolStripMenuItem.Name = "kULLANICIİŞLEMLERİToolStripMenuItem";
            this.kULLANICIİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.kULLANICIİŞLEMLERİToolStripMenuItem.Text = "KULLANICI ISLEMLERI";
            // 
            // kULLANICIEKLEToolStripMenuItem
            // 
            this.kULLANICIEKLEToolStripMenuItem.Name = "kULLANICIEKLEToolStripMenuItem";
            this.kULLANICIEKLEToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.kULLANICIEKLEToolStripMenuItem.Text = "KULLANICI EKLE";
            this.kULLANICIEKLEToolStripMenuItem.Click += new System.EventHandler(this.kULLANICIEKLEToolStripMenuItem_Click);
            // 
            // kULLANICISİLToolStripMenuItem
            // 
            this.kULLANICISİLToolStripMenuItem.Name = "kULLANICISİLToolStripMenuItem";
            this.kULLANICISİLToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.kULLANICISİLToolStripMenuItem.Text = "KULLANICI SİL";
            this.kULLANICISİLToolStripMenuItem.Click += new System.EventHandler(this.kULLANICISİLToolStripMenuItem_Click);
            // 
            // yARDIMToolStripMenuItem
            // 
            this.yARDIMToolStripMenuItem.Name = "yARDIMToolStripMenuItem";
            this.yARDIMToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.yARDIMToolStripMenuItem.Text = "AYARLAR";
            this.yARDIMToolStripMenuItem.Click += new System.EventHandler(this.yARDIMToolStripMenuItem_Click);
            // 
            // yARDIMToolStripMenuItem1
            // 
            this.yARDIMToolStripMenuItem1.Name = "yARDIMToolStripMenuItem1";
            this.yARDIMToolStripMenuItem1.Size = new System.Drawing.Size(78, 22);
            this.yARDIMToolStripMenuItem1.Text = "YARDIM";
            this.yARDIMToolStripMenuItem1.Click += new System.EventHandler(this.yARDIMToolStripMenuItem1_Click);
            // 
            // btnbarkod
            // 
            this.btnbarkod.BackColor = System.Drawing.Color.SeaShell;
            this.btnbarkod.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbarkod.ForeColor = System.Drawing.Color.Orange;
            this.btnbarkod.Location = new System.Drawing.Point(667, 60);
            this.btnbarkod.Name = "btnbarkod";
            this.btnbarkod.Size = new System.Drawing.Size(283, 249);
            this.btnbarkod.TabIndex = 3;
            this.btnbarkod.Text = "BARKOD OKUYUCU";
            this.btnbarkod.UseVisualStyleBackColor = false;
            this.btnbarkod.Click += new System.EventHandler(this.btnbarkod_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.BackgroundImage = global::stok.Properties.Resources._41;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(62, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 251);
            this.button1.TabIndex = 4;
            this.button1.Text = "AKSESUAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Image = global::stok.Properties.Resources._2;
            this.button2.Location = new System.Drawing.Point(363, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 249);
            this.button2.TabIndex = 1;
            this.button2.Text = "BİLGİSAYAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnphone
            // 
            this.btnphone.BackColor = System.Drawing.Color.SeaShell;
            this.btnphone.BackgroundImage = global::stok.Properties.Resources._3;
            this.btnphone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnphone.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphone.ForeColor = System.Drawing.Color.Orange;
            this.btnphone.Location = new System.Drawing.Point(62, 60);
            this.btnphone.Name = "btnphone";
            this.btnphone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnphone.Size = new System.Drawing.Size(284, 249);
            this.btnphone.TabIndex = 0;
            this.btnphone.Text = "TELEFON";
            this.btnphone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnphone.UseVisualStyleBackColor = false;
            this.btnphone.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1087, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbarkod);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnphone);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANASAYFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnphone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kULLANICIİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kULLANICIEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kULLANICISİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yARDIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yARDIMToolStripMenuItem1;
        private System.Windows.Forms.Button btnbarkod;
        private System.Windows.Forms.Button button1;
    }
}

