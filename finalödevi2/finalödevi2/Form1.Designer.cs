
namespace formuygulaması
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btngoruntule = new System.Windows.Forms.Button();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txttur = new System.Windows.Forms.TextBox();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.comboxsirket = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(14, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(674, 141);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btngoruntule
            // 
            this.btngoruntule.BackColor = System.Drawing.Color.White;
            this.btngoruntule.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btngoruntule.FlatAppearance.BorderSize = 2;
            this.btngoruntule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btngoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngoruntule.Location = new System.Drawing.Point(545, 269);
            this.btngoruntule.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btngoruntule.Name = "btngoruntule";
            this.btngoruntule.Size = new System.Drawing.Size(144, 33);
            this.btngoruntule.TabIndex = 1;
            this.btngoruntule.Text = "KAYITLARI GÖRÜNTÜLE";
            this.btngoruntule.UseVisualStyleBackColor = false;
            this.btngoruntule.Click += new System.EventHandler(this.btngoruntule_Click);
            // 
            // txtıd
            // 
            this.txtıd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtıd.Enabled = false;
            this.txtıd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtıd.Location = new System.Drawing.Point(147, 320);
            this.txtıd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtıd.Multiline = true;
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(149, 24);
            this.txtıd.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(147, 419);
            this.txtad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(149, 24);
            this.txtad.TabIndex = 3;
            // 
            // txttur
            // 
            this.txttur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttur.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttur.Location = new System.Drawing.Point(480, 417);
            this.txttur.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txttur.Multiline = true;
            this.txttur.Name = "txttur";
            this.txttur.Size = new System.Drawing.Size(149, 24);
            this.txttur.TabIndex = 5;
            // 
            // txtadet
            // 
            this.txtadet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadet.Location = new System.Drawing.Point(322, 373);
            this.txtadet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtadet.Multiline = true;
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(149, 24);
            this.txtadet.TabIndex = 6;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.White;
            this.btnekle.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnekle.FlatAppearance.BorderSize = 2;
            this.btnekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.Black;
            this.btnekle.Location = new System.Drawing.Point(71, 481);
            this.btnekle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(112, 47);
            this.btnekle.TabIndex = 7;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnsil.FlatAppearance.BorderSize = 2;
            this.btnsil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(520, 481);
            this.btnsil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(112, 47);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.White;
            this.btnguncelle.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnguncelle.FlatAppearance.BorderSize = 2;
            this.btnguncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(372, 481);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(112, 47);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.White;
            this.btntemizle.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btntemizle.FlatAppearance.BorderSize = 2;
            this.btntemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btntemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntemizle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Location = new System.Drawing.Point(218, 481);
            this.btntemizle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(112, 47);
            this.btntemizle.TabIndex = 10;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sıra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 423);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "İlaç Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(394, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "İlaç Şirketi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(406, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "İlaç Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(206, 377);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "İlaç Kutu Adeti:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(674, 101);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Adına Göre Filtrele";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "İlaç Adı:";
            // 
            // txtAra
            // 
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAra.ForeColor = System.Drawing.Color.Black;
            this.txtAra.Location = new System.Drawing.Point(133, 45);
            this.txtAra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(489, 27);
            this.txtAra.TabIndex = 17;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // comboxsirket
            // 
            this.comboxsirket.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboxsirket.FormattingEnabled = true;
            this.comboxsirket.Items.AddRange(new object[] {
            "demir",
            "eczacıbaşı",
            "selçukecza",
            "torun"});
            this.comboxsirket.Location = new System.Drawing.Point(480, 324);
            this.comboxsirket.Name = "comboxsirket";
            this.comboxsirket.Size = new System.Drawing.Size(149, 24);
            this.comboxsirket.Sorted = true;
            this.comboxsirket.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(708, 548);
            this.Controls.Add(this.comboxsirket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtadet);
            this.Controls.Add(this.txttur);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.btngoruntule);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burak Eczanesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btngoruntule;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttur;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboxsirket;
    }
}

