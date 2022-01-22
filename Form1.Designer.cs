
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
            this.money = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wylosowano = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GraczLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HasloLabel
            // 
            this.HasloLabel.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HasloLabel.Location = new System.Drawing.Point(12, 57);
            this.HasloLabel.Name = "HasloLabel";
            this.HasloLabel.Size = new System.Drawing.Size(1255, 195);
            this.HasloLabel.TabIndex = 0;
            this.HasloLabel.Text = "HASLO";
            this.HasloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wcisnieto
            // 
            this.Wcisnieto.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wcisnieto.Location = new System.Drawing.Point(611, 890);
            this.Wcisnieto.Name = "Wcisnieto";
            this.Wcisnieto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Wcisnieto.Size = new System.Drawing.Size(494, 54);
            this.Wcisnieto.TabIndex = 1;
            this.Wcisnieto.Text = "Wpisz litere na klawiaturze";
            this.Wcisnieto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Potwierdz
            // 
            this.Potwierdz.Location = new System.Drawing.Point(1111, 890);
            this.Potwierdz.Name = "Potwierdz";
            this.Potwierdz.Size = new System.Drawing.Size(156, 54);
            this.Potwierdz.TabIndex = 2;
            this.Potwierdz.Text = "Potwierdź";
            this.Potwierdz.UseVisualStyleBackColor = true;
            this.Potwierdz.Click += new System.EventHandler(this.button1_Click);
            this.Potwierdz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            // 
            // KategoriaLabel
            // 
            this.KategoriaLabel.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KategoriaLabel.Location = new System.Drawing.Point(12, 9);
            this.KategoriaLabel.Name = "KategoriaLabel";
            this.KategoriaLabel.Size = new System.Drawing.Size(1255, 48);
            this.KategoriaLabel.TabIndex = 3;
            this.KategoriaLabel.Text = "Kategoria";
            this.KategoriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.money.Location = new System.Drawing.Point(807, 361);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(52, 32);
            this.money.TabIndex = 5;
            this.money.Text = "0 zł";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 915);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wylosowano:";
            // 
            // wylosowano
            // 
            this.wylosowano.AutoSize = true;
            this.wylosowano.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wylosowano.Location = new System.Drawing.Point(171, 915);
            this.wylosowano.Name = "wylosowano";
            this.wylosowano.Size = new System.Drawing.Size(0, 32);
            this.wylosowano.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(274, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "\\/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(674, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gracz: ";
            // 
            // GraczLabel
            // 
            this.GraczLabel.AutoSize = true;
            this.GraczLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GraczLabel.Location = new System.Drawing.Point(765, 292);
            this.GraczLabel.Name = "GraczLabel";
            this.GraczLabel.Size = new System.Drawing.Size(0, 32);
            this.GraczLabel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(674, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stan konta:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1111, 788);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Zgadnij hasło";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(611, 803);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 39);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 956);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GraczLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wylosowano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.money);
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
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wylosowano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GraczLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

