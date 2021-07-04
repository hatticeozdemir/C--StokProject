
namespace stok
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.sTOKDataSet = new stok.STOKDataSet();
            this.sTOKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstokadd = new System.Windows.Forms.Button();
            this.btnstokupdate = new System.Windows.Forms.Button();
            this.btnstokdelete = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btngeri = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sTOKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sTOKDataSet
            // 
            this.sTOKDataSet.DataSetName = "STOKDataSet";
            this.sTOKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOKDataSetBindingSource
            // 
            this.sTOKDataSetBindingSource.DataSource = this.sTOKDataSet;
            this.sTOKDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOK ADI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "STOK ADET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "SORUMLU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "MODEL";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(316, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(316, 22);
            this.textBox4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(34, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 208);
            this.panel1.TabIndex = 8;
            // 
            // btnstokadd
            // 
            this.btnstokadd.BackColor = System.Drawing.Color.Orange;
            this.btnstokadd.Location = new System.Drawing.Point(230, 333);
            this.btnstokadd.Name = "btnstokadd";
            this.btnstokadd.Size = new System.Drawing.Size(146, 50);
            this.btnstokadd.TabIndex = 0;
            this.btnstokadd.Text = "STOK EKLE";
            this.btnstokadd.UseVisualStyleBackColor = false;
            this.btnstokadd.Click += new System.EventHandler(this.btnstokadd_Click);
            // 
            // btnstokupdate
            // 
            this.btnstokupdate.BackColor = System.Drawing.Color.Orange;
            this.btnstokupdate.Location = new System.Drawing.Point(396, 333);
            this.btnstokupdate.Name = "btnstokupdate";
            this.btnstokupdate.Size = new System.Drawing.Size(146, 50);
            this.btnstokupdate.TabIndex = 1;
            this.btnstokupdate.Text = "STOK GÜNCELLE";
            this.btnstokupdate.UseVisualStyleBackColor = false;
            this.btnstokupdate.Click += new System.EventHandler(this.btnstokupdate_Click);
            // 
            // btnstokdelete
            // 
            this.btnstokdelete.BackColor = System.Drawing.Color.Orange;
            this.btnstokdelete.Location = new System.Drawing.Point(66, 333);
            this.btnstokdelete.Name = "btnstokdelete";
            this.btnstokdelete.Size = new System.Drawing.Size(146, 50);
            this.btnstokdelete.TabIndex = 2;
            this.btnstokdelete.Text = "STOK SİL";
            this.btnstokdelete.UseVisualStyleBackColor = false;
            this.btnstokdelete.Click += new System.EventHandler(this.btnstokdelete_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(40, 280);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(271, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Yapılan değişiklikleri onaylıyorum";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Silver;
            this.btngeri.Location = new System.Drawing.Point(766, 471);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(140, 43);
            this.btngeri.TabIndex = 10;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncıkıs.Location = new System.Drawing.Point(912, 471);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(140, 43);
            this.btncıkıs.TabIndex = 11;
            this.btncıkıs.Text = "ÇIKIŞ";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1087, 578);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnstokadd);
            this.Controls.Add(this.btnstokupdate);
            this.Controls.Add(this.btnstokdelete);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELEFON STOK İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTOKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sTOKDataSetBindingSource;
        private STOKDataSet sTOKDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnstokdelete;
        private System.Windows.Forms.Button btnstokupdate;
        private System.Windows.Forms.Button btnstokadd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Timer timer1;
    }
}