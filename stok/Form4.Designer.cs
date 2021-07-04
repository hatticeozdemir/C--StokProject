
namespace stok
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stok_ParcaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok_ParcaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok_ParcaAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok_KayıtYapan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.sTOKDataSet1 = new stok.STOKDataSet1();
            this.sTOKDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btntelstok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(432, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stok_ParcaID,
            this.Stok_ParcaAdi,
            this.Stok_ParcaAdet,
            this.Stok_KayıtYapan});
            this.dataGridView1.Location = new System.Drawing.Point(141, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 262);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.AutoSizeColumnsModeChanged += new System.Windows.Forms.DataGridViewAutoSizeColumnsModeEventHandler(this.dataGridView1_AutoSizeColumnsModeChanged);
            this.dataGridView1.AutoSizeColumnModeChanged += new System.Windows.Forms.DataGridViewAutoSizeColumnModeEventHandler(this.dataGridView1_AutoSizeColumnModeChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Stok_ParcaID
            // 
            this.Stok_ParcaID.DataPropertyName = "Stok_ParcaID";
            this.Stok_ParcaID.HeaderText = "ID";
            this.Stok_ParcaID.MinimumWidth = 6;
            this.Stok_ParcaID.Name = "Stok_ParcaID";
            this.Stok_ParcaID.Width = 125;
            // 
            // Stok_ParcaAdi
            // 
            this.Stok_ParcaAdi.DataPropertyName = "Stok_ParcaAdi";
            this.Stok_ParcaAdi.HeaderText = "PARÇA ADI";
            this.Stok_ParcaAdi.MinimumWidth = 6;
            this.Stok_ParcaAdi.Name = "Stok_ParcaAdi";
            this.Stok_ParcaAdi.Width = 125;
            // 
            // Stok_ParcaAdet
            // 
            this.Stok_ParcaAdet.DataPropertyName = "Stok_ParcaAdet";
            this.Stok_ParcaAdet.HeaderText = "PARÇA ADET";
            this.Stok_ParcaAdet.MinimumWidth = 6;
            this.Stok_ParcaAdet.Name = "Stok_ParcaAdet";
            this.Stok_ParcaAdet.Width = 125;
            // 
            // Stok_KayıtYapan
            // 
            this.Stok_KayıtYapan.DataPropertyName = "Stok_KayıtYapan";
            this.Stok_KayıtYapan.HeaderText = "SORUMLU";
            this.Stok_KayıtYapan.MinimumWidth = 6;
            this.Stok_KayıtYapan.Name = "Stok_KayıtYapan";
            this.Stok_KayıtYapan.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = " MARKA:";
            // 
            // sTOKDataSet1
            // 
            this.sTOKDataSet1.DataSetName = "STOKDataSet1";
            this.sTOKDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOKDataSet1BindingSource
            // 
            this.sTOKDataSet1BindingSource.DataSource = this.sTOKDataSet1;
            this.sTOKDataSet1BindingSource.Position = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(676, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(399, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Brown;
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.Location = new System.Drawing.Point(894, 538);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(181, 39);
            this.btnCıkıs.TabIndex = 5;
            this.btnCıkıs.Text = "ÇIKIŞ";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // btntelstok
            // 
            this.btntelstok.BackColor = System.Drawing.Color.Cornsilk;
            this.btntelstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntelstok.Location = new System.Drawing.Point(700, 538);
            this.btntelstok.Name = "btntelstok";
            this.btntelstok.Size = new System.Drawing.Size(181, 39);
            this.btntelstok.TabIndex = 6;
            this.btntelstok.Text = "STOK İŞLEMLERİ";
            this.btntelstok.UseVisualStyleBackColor = false;
            this.btntelstok.Click += new System.EventHandler(this.telstok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "MODEL :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1087, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntelstok);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELEFON";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sTOKDataSet1BindingSource;
        private STOKDataSet1 sTOKDataSet1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok_ParcaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok_ParcaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok_ParcaAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok_KayıtYapan;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btntelstok;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}