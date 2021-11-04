namespace TP10_200581
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBxTE = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblOnlyView4 = new System.Windows.Forms.Label();
            this.LblUF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultado da verificação:";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(324, 168);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 15);
            this.LblResultado.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Título de eleitor:";
            // 
            // TxtBxTE
            // 
            this.TxtBxTE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxTE.Location = new System.Drawing.Point(130, 54);
            this.TxtBxTE.Name = "TxtBxTE";
            this.TxtBxTE.Size = new System.Drawing.Size(100, 21);
            this.TxtBxTE.TabIndex = 3;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificar.Location = new System.Drawing.Point(144, 99);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(75, 23);
            this.BtnVerificar.TabIndex = 4;
            this.BtnVerificar.Text = "Verficar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(294, 52);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblOnlyView4
            // 
            this.LblOnlyView4.AutoSize = true;
            this.LblOnlyView4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView4.Location = new System.Drawing.Point(290, 199);
            this.LblOnlyView4.Name = "LblOnlyView4";
            this.LblOnlyView4.Size = new System.Drawing.Size(26, 15);
            this.LblOnlyView4.TabIndex = 6;
            this.LblOnlyView4.Text = "UF:";
            // 
            // LblUF
            // 
            this.LblUF.AutoSize = true;
            this.LblUF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUF.Location = new System.Drawing.Point(334, 199);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(0, 15);
            this.LblUF.TabIndex = 7;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP10_200581.Properties.Resources.treimagemfundo;
            this.ClientSize = new System.Drawing.Size(414, 221);
            this.Controls.Add(this.LblUF);
            this.Controls.Add(this.LblOnlyView4);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.TxtBxTE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "App - Tribunal Regional Eleitoral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBxTE;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblOnlyView4;
        private System.Windows.Forms.Label LblUF;
    }
}

