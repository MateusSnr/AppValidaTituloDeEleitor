using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP10_200581
{
    public partial class FrmPrincipal : Form
    {
        #region Inicialização
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Variáveis Globais
        string te;
        int uf1;
        int uf2;
        #endregion

        #region Form Closing
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair ?", "Encerrando o jogo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
        #endregion

        #region Botão Verificar
        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            if (AlgoritmoTituloEleitoral.ClasseAlgoritmoTituloEleitor.ValidaTE(TxtBxTE.Text) == true)
            {
                LblResultado.ForeColor = Color.Green;
                LblResultado.Text = "Válido";

                te = TxtBxTE.Text;

                uf1 = (int.Parse(te.Substring(8, 1)));

                uf2 = (int.Parse(te.Substring(9, 1)));

                if(uf1 == 0 && uf2 == 1)
                {
                    LblUF.Text = "SP";
                }

                else if(uf1 == 0 && uf2 == 2)
                {
                    LblUF.Text = "MG";
                }
                else if (uf1 == 0 && uf2 == 3)
                {
                    LblUF.Text = "RJ";
                }
                else if (uf1 == 0 && uf2 == 4)
                {
                    LblUF.Text = "RS";
                }
                else if (uf1 == 0 && uf2 == 5)
                {
                    LblUF.Text = "BA";
                }
                else if (uf1 == 0 && uf2 == 6)
                {
                    LblUF.Text = "PR";
                }
                else if (uf1 == 0 && uf2 == 7)
                {
                    LblUF.Text = "CE";
                }
                else if (uf1 == 0 && uf2 == 8)
                {
                    LblUF.Text = "PE";
                }
                else if (uf1 == 0 && uf2 == 9)
                {
                    LblUF.Text = "SC";
                }
                else if (uf1 == 1 && uf2 == 0)
                {
                    LblUF.Text = "GO";
                }
                else if (uf1 == 1 && uf2 == 1)
                {
                    LblUF.Text = "MA";
                }
                else if (uf1 == 1 && uf2 == 2)
                {
                    LblUF.Text = "PB";
                }
                else if (uf1 == 1 && uf2 == 3)
                {
                    LblUF.Text = "PA";
                }
                else if (uf1 == 1 && uf2 == 4)
                {
                    LblUF.Text = "ES";
                }
                else if (uf1 == 1 && uf2 == 5)
                {
                    LblUF.Text = "PI";
                }
                else if (uf1 == 1 && uf2 == 6)
                {
                    LblUF.Text = "RN";
                }
                else if (uf1 == 1 && uf2 == 7)
                {
                    LblUF.Text = "AL";
                }
                else if (uf1 == 1 && uf2 == 8)
                {
                    LblUF.Text = "MT";
                }
                else if (uf1 == 1 && uf2 == 9)
                {
                    LblUF.Text = "MS";
                }
                else if (uf1 == 2 && uf2 == 0)
                {
                    LblUF.Text = "DF";
                }
                else if (uf1 == 2 && uf2 == 1)
                {
                    LblUF.Text = "SE";
                }
                else if (uf1 == 2 && uf2 == 2)
                {
                    LblUF.Text = "AM";
                }
                else if (uf1 == 2 && uf2 == 3)
                {
                    LblUF.Text = "RO";
                }
                else if (uf1 == 2 && uf2 == 4)
                {
                    LblUF.Text = "AC";
                }
                else if (uf1 == 2 && uf2 == 5)
                {
                    LblUF.Text = "AP";
                }
                else if (uf1 == 2 && uf2 == 6)
                {
                    LblUF.Text = "RR";
                }
                else if (uf1 == 2 && uf2 == 7)
                {
                    LblUF.Text = "TO";
                }
                else if (uf1 == 2 && uf2 == 8)
                {
                    LblUF.Text = "ZZ-Ext.";
                }

                else
                {
                    LblUF.Text = "N/A";
                }
            }
            else
            {
                LblResultado.ForeColor = Color.Red;
                LblResultado.Text = "Inválido";
            }
        }
        #endregion

        #region Limpar
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LblResultado.Text = "";
            TxtBxTE.Clear();
            TxtBxTE.Focus();
            LblUF.Text = "";
        }
        #endregion
    }
}
