
namespace Musteri
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MNo = new System.Windows.Forms.TextBox();
            this.txt_MAd = new System.Windows.Forms.TextBox();
            this.txt_MSoyad = new System.Windows.Forms.TextBox();
            this.txt_MTel = new System.Windows.Forms.TextBox();
            this.date_MDTarih = new System.Windows.Forms.DateTimePicker();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(56, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // txt_MNo
            // 
            this.txt_MNo.Enabled = false;
            this.txt_MNo.Location = new System.Drawing.Point(138, 19);
            this.txt_MNo.Name = "txt_MNo";
            this.txt_MNo.Size = new System.Drawing.Size(183, 22);
            this.txt_MNo.TabIndex = 5;
            // 
            // txt_MAd
            // 
            this.txt_MAd.Location = new System.Drawing.Point(138, 66);
            this.txt_MAd.Name = "txt_MAd";
            this.txt_MAd.Size = new System.Drawing.Size(183, 22);
            this.txt_MAd.TabIndex = 6;
            // 
            // txt_MSoyad
            // 
            this.txt_MSoyad.Location = new System.Drawing.Point(138, 107);
            this.txt_MSoyad.Name = "txt_MSoyad";
            this.txt_MSoyad.Size = new System.Drawing.Size(183, 22);
            this.txt_MSoyad.TabIndex = 7;
            // 
            // txt_MTel
            // 
            this.txt_MTel.Location = new System.Drawing.Point(138, 187);
            this.txt_MTel.Name = "txt_MTel";
            this.txt_MTel.Size = new System.Drawing.Size(183, 22);
            this.txt_MTel.TabIndex = 8;
            // 
            // date_MDTarih
            // 
            this.date_MDTarih.Location = new System.Drawing.Point(138, 148);
            this.date_MDTarih.Name = "date_MDTarih";
            this.date_MDTarih.Size = new System.Drawing.Size(183, 22);
            this.date_MDTarih.TabIndex = 9;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(366, 148);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(99, 32);
            this.btn_Kaydet.TabIndex = 10;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(471, 148);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(100, 32);
            this.btn_Sil.TabIndex = 11;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(577, 148);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(119, 32);
            this.btn_Guncelle.TabIndex = 12;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(746, 231);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.date_MDTarih);
            this.Controls.Add(this.txt_MTel);
            this.Controls.Add(this.txt_MSoyad);
            this.Controls.Add(this.txt_MAd);
            this.Controls.Add(this.txt_MNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MNo;
        private System.Windows.Forms.TextBox txt_MAd;
        private System.Windows.Forms.TextBox txt_MSoyad;
        private System.Windows.Forms.TextBox txt_MTel;
        private System.Windows.Forms.DateTimePicker date_MDTarih;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

