
namespace Prime_Number
{
    partial class Win_Prime
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win_Prime));
            this.Btn_GenPrime = new System.Windows.Forms.Button();
            this.Txt_Time = new System.Windows.Forms.TextBox();
            this.Txt_nbprime = new System.Windows.Forms.TextBox();
            this.Lab_Time = new System.Windows.Forms.Label();
            this.Lab_Qte = new System.Windows.Forms.Label();
            this.Txt_ValueMax = new System.Windows.Forms.TextBox();
            this.Lab_PrimeMax = new System.Windows.Forms.Label();
            this.Lab_Comment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_GenPrime2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_ValueMax2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_TestPrime = new System.Windows.Forms.Button();
            this.Txt_TestPrime = new System.Windows.Forms.TextBox();
            this.Lab_TestPrime = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btn_GenAtkin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_ValueMax3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_GenPrime
            // 
            this.Btn_GenPrime.Location = new System.Drawing.Point(345, 61);
            this.Btn_GenPrime.Name = "Btn_GenPrime";
            this.Btn_GenPrime.Size = new System.Drawing.Size(187, 23);
            this.Btn_GenPrime.TabIndex = 0;
            this.Btn_GenPrime.Text = "Generer Nombres Premiers";
            this.Btn_GenPrime.UseVisualStyleBackColor = true;
            this.Btn_GenPrime.Click += new System.EventHandler(this.Btn_GenPrime_Click);
            // 
            // Txt_Time
            // 
            this.Txt_Time.Location = new System.Drawing.Point(214, 19);
            this.Txt_Time.Name = "Txt_Time";
            this.Txt_Time.ReadOnly = true;
            this.Txt_Time.Size = new System.Drawing.Size(146, 20);
            this.Txt_Time.TabIndex = 4;
            // 
            // Txt_nbprime
            // 
            this.Txt_nbprime.Location = new System.Drawing.Point(214, 45);
            this.Txt_nbprime.Name = "Txt_nbprime";
            this.Txt_nbprime.ReadOnly = true;
            this.Txt_nbprime.Size = new System.Drawing.Size(146, 20);
            this.Txt_nbprime.TabIndex = 5;
            // 
            // Lab_Time
            // 
            this.Lab_Time.AutoSize = true;
            this.Lab_Time.Location = new System.Drawing.Point(23, 19);
            this.Lab_Time.Name = "Lab_Time";
            this.Lab_Time.Size = new System.Drawing.Size(80, 13);
            this.Lab_Time.TabIndex = 6;
            this.Lab_Time.Text = "Temps ecoulé :";
            // 
            // Lab_Qte
            // 
            this.Lab_Qte.AutoSize = true;
            this.Lab_Qte.Location = new System.Drawing.Point(23, 44);
            this.Lab_Qte.Name = "Lab_Qte";
            this.Lab_Qte.Size = new System.Drawing.Size(181, 13);
            this.Lab_Qte.TabIndex = 7;
            this.Lab_Qte.Text = "Quantité de nombre premier trouvés :";
            // 
            // Txt_ValueMax
            // 
            this.Txt_ValueMax.Location = new System.Drawing.Point(147, 31);
            this.Txt_ValueMax.MaxLength = 8;
            this.Txt_ValueMax.Name = "Txt_ValueMax";
            this.Txt_ValueMax.Size = new System.Drawing.Size(143, 20);
            this.Txt_ValueMax.TabIndex = 8;
            this.Txt_ValueMax.Text = "1000";
            this.Txt_ValueMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lab_PrimeMax
            // 
            this.Lab_PrimeMax.AutoSize = true;
            this.Lab_PrimeMax.Location = new System.Drawing.Point(10, 34);
            this.Lab_PrimeMax.Name = "Lab_PrimeMax";
            this.Lab_PrimeMax.Size = new System.Drawing.Size(131, 13);
            this.Lab_PrimeMax.TabIndex = 9;
            this.Lab_PrimeMax.Text = "Generer jusqu\'au nombre :";
            // 
            // Lab_Comment
            // 
            this.Lab_Comment.AutoSize = true;
            this.Lab_Comment.Location = new System.Drawing.Point(11, 495);
            this.Lab_Comment.Name = "Lab_Comment";
            this.Lab_Comment.Size = new System.Drawing.Size(403, 39);
            this.Lab_Comment.TabIndex = 10;
            this.Lab_Comment.Text = resources.GetString("Lab_Comment.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "-> Le resultat sera sauvegardé sous la forme d\'un fichier texte au format csv.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "( Maximum :  99 999 999. )";
            // 
            // Btn_GenPrime2
            // 
            this.Btn_GenPrime2.Location = new System.Drawing.Point(345, 71);
            this.Btn_GenPrime2.Name = "Btn_GenPrime2";
            this.Btn_GenPrime2.Size = new System.Drawing.Size(187, 23);
            this.Btn_GenPrime2.TabIndex = 13;
            this.Btn_GenPrime2.Text = "Generer Nombres Premiers";
            this.Btn_GenPrime2.UseVisualStyleBackColor = true;
            this.Btn_GenPrime2.Click += new System.EventHandler(this.Btn_GenPrime2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_GenPrime);
            this.groupBox1.Controls.Add(this.Lab_PrimeMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_ValueMax);
            this.groupBox1.Location = new System.Drawing.Point(17, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 92);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crible d\'Ératosthène : Generation avec utilisation d\'un tableau de nombre entier " +
    "( int array ).";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Txt_ValueMax2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Btn_GenPrime2);
            this.groupBox2.Location = new System.Drawing.Point(15, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crible d\'Ératosthène : Generation avec utilisation d\'un tableau de bits ( bits ar" +
    "ray ).";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "( Maximum :  715 827 882. )";
            // 
            // Txt_ValueMax2
            // 
            this.Txt_ValueMax2.Location = new System.Drawing.Point(147, 39);
            this.Txt_ValueMax2.MaxLength = 9;
            this.Txt_ValueMax2.Name = "Txt_ValueMax2";
            this.Txt_ValueMax2.Size = new System.Drawing.Size(143, 20);
            this.Txt_ValueMax2.TabIndex = 15;
            this.Txt_ValueMax2.Text = "1000";
            this.Txt_ValueMax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Generer jusqu\'au nombre :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txt_Time);
            this.groupBox3.Controls.Add(this.Txt_nbprime);
            this.groupBox3.Controls.Add(this.Lab_Time);
            this.groupBox3.Controls.Add(this.Lab_Qte);
            this.groupBox3.Location = new System.Drawing.Point(14, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 84);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistiques";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_TestPrime);
            this.groupBox4.Controls.Add(this.Txt_TestPrime);
            this.groupBox4.Controls.Add(this.Lab_TestPrime);
            this.groupBox4.Location = new System.Drawing.Point(17, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(556, 79);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Test de primalité Miller Rabin";
            // 
            // Btn_TestPrime
            // 
            this.Btn_TestPrime.Location = new System.Drawing.Point(345, 26);
            this.Btn_TestPrime.Name = "Btn_TestPrime";
            this.Btn_TestPrime.Size = new System.Drawing.Size(187, 23);
            this.Btn_TestPrime.TabIndex = 12;
            this.Btn_TestPrime.Text = "Test de primalité";
            this.Btn_TestPrime.UseVisualStyleBackColor = true;
            this.Btn_TestPrime.Click += new System.EventHandler(this.Btn_TestPrime_Click);
            // 
            // Txt_TestPrime
            // 
            this.Txt_TestPrime.Location = new System.Drawing.Point(171, 28);
            this.Txt_TestPrime.MaxLength = 12;
            this.Txt_TestPrime.Name = "Txt_TestPrime";
            this.Txt_TestPrime.Size = new System.Drawing.Size(119, 20);
            this.Txt_TestPrime.TabIndex = 11;
            this.Txt_TestPrime.Text = "17";
            this.Txt_TestPrime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lab_TestPrime
            // 
            this.Lab_TestPrime.AutoSize = true;
            this.Lab_TestPrime.Location = new System.Drawing.Point(10, 33);
            this.Lab_TestPrime.Name = "Lab_TestPrime";
            this.Lab_TestPrime.Size = new System.Drawing.Size(155, 13);
            this.Lab_TestPrime.TabIndex = 10;
            this.Lab_TestPrime.Text = "Tester un nombre entier positif :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Btn_GenAtkin);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.Txt_ValueMax3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(17, 302);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(556, 100);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Crible d\' Atkin";
            // 
            // Btn_GenAtkin
            // 
            this.Btn_GenAtkin.Location = new System.Drawing.Point(343, 67);
            this.Btn_GenAtkin.Name = "Btn_GenAtkin";
            this.Btn_GenAtkin.Size = new System.Drawing.Size(187, 23);
            this.Btn_GenAtkin.TabIndex = 18;
            this.Btn_GenAtkin.Text = "Generer Nombres Premiers";
            this.Btn_GenAtkin.UseVisualStyleBackColor = true;
            this.Btn_GenAtkin.Click += new System.EventHandler(this.Btn_GenAtkin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "( Maximum :  715 827 882. )";
            // 
            // Txt_ValueMax3
            // 
            this.Txt_ValueMax3.Location = new System.Drawing.Point(145, 35);
            this.Txt_ValueMax3.MaxLength = 9;
            this.Txt_ValueMax3.Name = "Txt_ValueMax3";
            this.Txt_ValueMax3.Size = new System.Drawing.Size(143, 20);
            this.Txt_ValueMax3.TabIndex = 16;
            this.Txt_ValueMax3.Text = "1000";
            this.Txt_ValueMax3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Generer jusqu\'au nombre :";
            // 
            // Win_Prime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 561);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lab_Comment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Win_Prime";
            this.Text = "Nombres Premiers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_GenPrime;
        private System.Windows.Forms.TextBox Txt_Time;
        private System.Windows.Forms.TextBox Txt_nbprime;
        private System.Windows.Forms.Label Lab_Time;
        private System.Windows.Forms.Label Lab_Qte;
        private System.Windows.Forms.TextBox Txt_ValueMax;
        private System.Windows.Forms.Label Lab_PrimeMax;
        private System.Windows.Forms.Label Lab_Comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_GenPrime2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_ValueMax2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_TestPrime;
        private System.Windows.Forms.TextBox Txt_TestPrime;
        private System.Windows.Forms.Label Lab_TestPrime;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_GenAtkin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_ValueMax3;
        private System.Windows.Forms.Label label5;
    }
}

