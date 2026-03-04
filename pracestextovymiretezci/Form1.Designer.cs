namespace pracestextovymiretezci
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textOut = new System.Windows.Forms.TextBox();
            this.buttonMezery = new System.Windows.Forms.Button();
            this.textIn = new System.Windows.Forms.TextBox();
            this.buttonPočeta = new System.Windows.Forms.Button();
            this.buttonMala = new System.Windows.Forms.Button();
            this.buttonPočetPp = new System.Windows.Forms.Button();
            this.buttonDelka = new System.Windows.Forms.Button();
            this.buttonRewerse = new System.Windows.Forms.Button();
            this.buttonPalindrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textOut
            // 
            this.textOut.Location = new System.Drawing.Point(12, 324);
            this.textOut.Multiline = true;
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(776, 114);
            this.textOut.TabIndex = 0;
            // 
            // buttonMezery
            // 
            this.buttonMezery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMezery.Location = new System.Drawing.Point(12, 12);
            this.buttonMezery.Name = "buttonMezery";
            this.buttonMezery.Size = new System.Drawing.Size(141, 89);
            this.buttonMezery.TabIndex = 1;
            this.buttonMezery.Text = "Bez mezer";
            this.buttonMezery.UseVisualStyleBackColor = true;
            // 
            // textIn
            // 
            this.textIn.Location = new System.Drawing.Point(12, 204);
            this.textIn.Multiline = true;
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(776, 114);
            this.textIn.TabIndex = 2;
            // 
            // buttonPočeta
            // 
            this.buttonPočeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPočeta.Location = new System.Drawing.Point(12, 107);
            this.buttonPočeta.Name = "buttonPočeta";
            this.buttonPočeta.Size = new System.Drawing.Size(141, 91);
            this.buttonPočeta.TabIndex = 3;
            this.buttonPočeta.Text = "Počet \"a\"";
            this.buttonPočeta.UseVisualStyleBackColor = true;
            // 
            // buttonMala
            // 
            this.buttonMala.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMala.Location = new System.Drawing.Point(175, 12);
            this.buttonMala.Name = "buttonMala";
            this.buttonMala.Size = new System.Drawing.Size(240, 89);
            this.buttonMala.TabIndex = 4;
            this.buttonMala.Text = "Na malá písmena";
            this.buttonMala.UseVisualStyleBackColor = true;
            // 
            // buttonPočetPp
            // 
            this.buttonPočetPp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPočetPp.Location = new System.Drawing.Point(175, 107);
            this.buttonPočetPp.Name = "buttonPočetPp";
            this.buttonPočetPp.Size = new System.Drawing.Size(240, 89);
            this.buttonPočetPp.TabIndex = 5;
            this.buttonPočetPp.Text = "Počet \"p\" a \"P\"";
            this.buttonPočetPp.UseVisualStyleBackColor = true;
            // 
            // buttonDelka
            // 
            this.buttonDelka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelka.Location = new System.Drawing.Point(435, 12);
            this.buttonDelka.Name = "buttonDelka";
            this.buttonDelka.Size = new System.Drawing.Size(141, 89);
            this.buttonDelka.TabIndex = 6;
            this.buttonDelka.Text = "Délka textu";
            this.buttonDelka.UseVisualStyleBackColor = true;
            // 
            // buttonRewerse
            // 
            this.buttonRewerse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRewerse.Location = new System.Drawing.Point(435, 107);
            this.buttonRewerse.Name = "buttonRewerse";
            this.buttonRewerse.Size = new System.Drawing.Size(141, 89);
            this.buttonRewerse.TabIndex = 7;
            this.buttonRewerse.Text = "Pozpátku";
            this.buttonRewerse.UseVisualStyleBackColor = true;
            // 
            // buttonPalindrom
            // 
            this.buttonPalindrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPalindrom.Location = new System.Drawing.Point(592, 12);
            this.buttonPalindrom.Name = "buttonPalindrom";
            this.buttonPalindrom.Size = new System.Drawing.Size(196, 184);
            this.buttonPalindrom.TabIndex = 8;
            this.buttonPalindrom.Text = "Test na palindrom";
            this.buttonPalindrom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPalindrom);
            this.Controls.Add(this.buttonRewerse);
            this.Controls.Add(this.buttonDelka);
            this.Controls.Add(this.buttonPočetPp);
            this.Controls.Add(this.buttonMala);
            this.Controls.Add(this.buttonPočeta);
            this.Controls.Add(this.textIn);
            this.Controls.Add(this.buttonMezery);
            this.Controls.Add(this.textOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOut;
        private System.Windows.Forms.Button buttonMezery;
        private System.Windows.Forms.TextBox textIn;
        private System.Windows.Forms.Button buttonPočeta;
        private System.Windows.Forms.Button buttonMala;
        private System.Windows.Forms.Button buttonPočetPp;
        private System.Windows.Forms.Button buttonDelka;
        private System.Windows.Forms.Button buttonRewerse;
        private System.Windows.Forms.Button buttonPalindrom;
    }
}

