﻿
namespace Kolo_fortuny
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HasloLabel = new System.Windows.Forms.Label();
            this.Wcisnieto = new System.Windows.Forms.Label();
            this.Potwierdz = new System.Windows.Forms.Button();
            this.KategoriaLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HasloLabel
            // 
            this.HasloLabel.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HasloLabel.Location = new System.Drawing.Point(12, 57);
            this.HasloLabel.Name = "HasloLabel";
            this.HasloLabel.Size = new System.Drawing.Size(1007, 120);
            this.HasloLabel.TabIndex = 0;
            this.HasloLabel.Text = "PROGRAMOWANIE";
            this.HasloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wcisnieto
            // 
            this.Wcisnieto.AutoSize = true;
            this.Wcisnieto.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wcisnieto.Location = new System.Drawing.Point(696, 630);
            this.Wcisnieto.Name = "Wcisnieto";
            this.Wcisnieto.Size = new System.Drawing.Size(130, 54);
            this.Wcisnieto.TabIndex = 1;
            this.Wcisnieto.Text = "label1";
            // 
            // Potwierdz
            // 
            this.Potwierdz.Location = new System.Drawing.Point(854, 630);
            this.Potwierdz.Name = "Potwierdz";
            this.Potwierdz.Size = new System.Drawing.Size(156, 54);
            this.Potwierdz.TabIndex = 2;
            this.Potwierdz.Text = "Potwierdz";
            this.Potwierdz.UseVisualStyleBackColor = true;
            this.Potwierdz.Click += new System.EventHandler(this.button1_Click);
            this.Potwierdz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            // 
            // KategoriaLabel
            // 
            this.KategoriaLabel.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KategoriaLabel.Location = new System.Drawing.Point(3, 9);
            this.KategoriaLabel.Name = "KategoriaLabel";
            this.KategoriaLabel.Size = new System.Drawing.Size(1007, 48);
            this.KategoriaLabel.TabIndex = 3;
            this.KategoriaLabel.Text = "PROGRAMOWANIE";
            this.KategoriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KategoriaLabel);
            this.Controls.Add(this.Potwierdz);
            this.Controls.Add(this.Wcisnieto);
            this.Controls.Add(this.HasloLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HasloLabel;
        private System.Windows.Forms.Label Wcisnieto;
        private System.Windows.Forms.Button Potwierdz;
        private System.Windows.Forms.Label KategoriaLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

