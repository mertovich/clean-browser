
namespace Clear_browser
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
            this.button_clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_clear
            // 
            this.button_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_clear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.button_clear.Location = new System.Drawing.Point(0, 489);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(708, 72);
            this.button_clear.TabIndex = 0;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Clear_browser.Properties.Resources._1276490;
            this.pictureBox1.Location = new System.Drawing.Point(211, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 320);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_clear);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clear browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

