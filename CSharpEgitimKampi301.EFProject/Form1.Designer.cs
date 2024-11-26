namespace CSharpEgitimKampi301.EFProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btngetbyıd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rehber id:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(119, 37);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(170, 22);
            this.txtid.TabIndex = 1;
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnlist.Location = new System.Drawing.Point(128, 149);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(152, 51);
            this.btnlist.TabIndex = 2;
            this.btnlist.Text = "Listele";
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 401);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(119, 80);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(170, 22);
            this.txtname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rehber Adı:";
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(119, 121);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(170, 22);
            this.txtsurname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rehber Soyadı:";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnekle.Location = new System.Drawing.Point(128, 193);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(152, 51);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DarkSalmon;
            this.btndelete.Location = new System.Drawing.Point(128, 237);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(152, 51);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Sil";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnupdate.Location = new System.Drawing.Point(128, 281);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(152, 51);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Güncelle";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btngetbyıd
            // 
            this.btngetbyıd.BackColor = System.Drawing.Color.DarkSalmon;
            this.btngetbyıd.Location = new System.Drawing.Point(128, 331);
            this.btngetbyıd.Name = "btngetbyıd";
            this.btngetbyıd.Size = new System.Drawing.Size(152, 51);
            this.btngetbyıd.TabIndex = 11;
            this.btngetbyıd.Text = "Id\'ye Göre Getir";
            this.btngetbyıd.UseVisualStyleBackColor = false;
            this.btngetbyıd.Click += new System.EventHandler(this.btngetbyıd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.btngetbyıd);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rehber İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btngetbyıd;
    }
}

