namespace NewsViewer
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
            this.title1 = new System.Windows.Forms.Label();
            this.content1 = new System.Windows.Forms.Label();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.image2 = new System.Windows.Forms.PictureBox();
            this.content2 = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.prevBut = new System.Windows.Forms.Button();
            this.newxBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).BeginInit();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title1.Location = new System.Drawing.Point(419, 75);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(70, 25);
            this.title1.TabIndex = 0;
            this.title1.Text = "label1";
            // 
            // content1
            // 
            this.content1.AutoSize = true;
            this.content1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.content1.Location = new System.Drawing.Point(421, 122);
            this.content1.Name = "content1";
            this.content1.Size = new System.Drawing.Size(51, 20);
            this.content1.TabIndex = 1;
            this.content1.Text = "label2";
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(222, 75);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(178, 146);
            this.image1.TabIndex = 2;
            this.image1.TabStop = false;
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(222, 271);
            this.image2.Name = "image2";
            this.image2.Size = new System.Drawing.Size(178, 146);
            this.image2.TabIndex = 5;
            this.image2.TabStop = false;
            // 
            // content2
            // 
            this.content2.AutoSize = true;
            this.content2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.content2.Location = new System.Drawing.Point(421, 318);
            this.content2.Name = "content2";
            this.content2.Size = new System.Drawing.Size(51, 20);
            this.content2.TabIndex = 4;
            this.content2.Text = "label3";
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title2.Location = new System.Drawing.Point(419, 271);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(70, 25);
            this.title2.TabIndex = 3;
            this.title2.Text = "label4";
            // 
            // prevBut
            // 
            this.prevBut.Location = new System.Drawing.Point(183, 523);
            this.prevBut.Name = "prevBut";
            this.prevBut.Size = new System.Drawing.Size(75, 23);
            this.prevBut.TabIndex = 6;
            this.prevBut.Text = "Prev";
            this.prevBut.UseVisualStyleBackColor = true;
            this.prevBut.Click += new System.EventHandler(this.prevBut_Click);
            // 
            // newxBut
            // 
            this.newxBut.Location = new System.Drawing.Point(634, 523);
            this.newxBut.Name = "newxBut";
            this.newxBut.Size = new System.Drawing.Size(75, 23);
            this.newxBut.TabIndex = 7;
            this.newxBut.Text = "next";
            this.newxBut.UseVisualStyleBackColor = true;
            this.newxBut.Click += new System.EventHandler(this.newxBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 647);
            this.Controls.Add(this.newxBut);
            this.Controls.Add(this.prevBut);
            this.Controls.Add(this.image2);
            this.Controls.Add(this.content2);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.content1);
            this.Controls.Add(this.title1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label content1;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.PictureBox image2;
        private System.Windows.Forms.Label content2;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Button prevBut;
        private System.Windows.Forms.Button newxBut;
    }
}

