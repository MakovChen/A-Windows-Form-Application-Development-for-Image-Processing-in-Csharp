namespace Lecture1_EmguCV
{
    partial class Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Screen = new System.Windows.Forms.PictureBox();
            this.START_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HE_Screen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OB_Screen = new System.Windows.Forms.PictureBox();
            this.FE_Screen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LE_Screen = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HE_Screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OB_Screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FE_Screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LE_Screen)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Screen
            // 
            this.Main_Screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Main_Screen.Location = new System.Drawing.Point(12, 13);
            this.Main_Screen.Name = "Main_Screen";
            this.Main_Screen.Size = new System.Drawing.Size(445, 287);
            this.Main_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Main_Screen.TabIndex = 0;
            this.Main_Screen.TabStop = false;
            // 
            // START_Button
            // 
            this.START_Button.Location = new System.Drawing.Point(12, 317);
            this.START_Button.Name = "START_Button";
            this.START_Button.Size = new System.Drawing.Size(115, 42);
            this.START_Button.TabIndex = 1;
            this.START_Button.Text = "PAUSE";
            this.START_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.START_Button.UseVisualStyleBackColor = true;
            this.START_Button.Click += new System.EventHandler(this.START_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Histogram Equalization";
            // 
            // HE_Screen
            // 
            this.HE_Screen.Location = new System.Drawing.Point(476, 41);
            this.HE_Screen.Name = "HE_Screen";
            this.HE_Screen.Size = new System.Drawing.Size(234, 140);
            this.HE_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HE_Screen.TabIndex = 3;
            this.HE_Screen.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(719, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Otsu\'s Binarization";
            // 
            // OB_Screen
            // 
            this.OB_Screen.Location = new System.Drawing.Point(722, 41);
            this.OB_Screen.Name = "OB_Screen";
            this.OB_Screen.Size = new System.Drawing.Size(234, 140);
            this.OB_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OB_Screen.TabIndex = 5;
            this.OB_Screen.TabStop = false;
            // 
            // FE_Screen
            // 
            this.FE_Screen.Location = new System.Drawing.Point(476, 219);
            this.FE_Screen.Name = "FE_Screen";
            this.FE_Screen.Size = new System.Drawing.Size(234, 140);
            this.FE_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FE_Screen.TabIndex = 7;
            this.FE_Screen.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fuzzy Enhance";
            // 
            // LE_Screen
            // 
            this.LE_Screen.Location = new System.Drawing.Point(722, 219);
            this.LE_Screen.Name = "LE_Screen";
            this.LE_Screen.Size = new System.Drawing.Size(234, 140);
            this.LE_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LE_Screen.TabIndex = 9;
            this.LE_Screen.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(719, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Laplacian Edge";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 390);
            this.Controls.Add(this.LE_Screen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FE_Screen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OB_Screen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HE_Screen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.START_Button);
            this.Controls.Add(this.Main_Screen);
            this.Name = "Form";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.Main_Screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HE_Screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OB_Screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FE_Screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LE_Screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Main_Screen;
        private System.Windows.Forms.Button START_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HE_Screen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox OB_Screen;
        private System.Windows.Forms.PictureBox FE_Screen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox LE_Screen;
        private System.Windows.Forms.Label label4;
    }
}

