using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBCODE
{
    public partial class Form1 : Form
    {
        // ============================================ 1. VARIAVEIS GLOBAIS ===================================================================================================        
        //                                                1.1 COMPONENTES
        private RadioButton rb_prefix_false;
        private RadioButton rb_prefix_true;                


        //                                                 1.2 APLICAÇÃO
        private string InputData = "";
        // =====================================================================================================================================================================





        // ================================================= 2. METODOS ========================================================================================================  
        //                                                2.1 COMPONENTES        
        private void InitializeRBPrefix(bool status)
        {
            if (status)
            {
                //                            Ocultar Componentes Primários
                this.ckb_active_prefix.Visible = false;
                this.ckb_active_prefix.Checked = false;

                this.tb_prefix.Visible = false;
                this.tb_prefix.Text = "";


                //                           Mostrar Componentes Secundários
                // Instanciamento
                this.rb_prefix_false = new RadioButton();
                this.rb_prefix_true = new RadioButton();

                // Propriedades
                this.rb_prefix_false.Location = new Point(26, 23);
                this.rb_prefix_false.Size = new Size(60, 17);
                this.rb_prefix_false.Text = "Não";
                this.rb_prefix_false.Checked = true;

                this.rb_prefix_true.Location = new Point(100, 23);
                this.rb_prefix_true.Size = new Size(60, 17);
                this.rb_prefix_true.Text = "Sim";

                // Adicionar
                this.gb_prefix.Controls.Add(this.rb_prefix_false);
                this.gb_prefix.Controls.Add(this.rb_prefix_true);
            }
            else
            {
                //                           Ocultar Componentes Secundários
                this.rb_prefix_false.Dispose();
                this.rb_prefix_true.Dispose();


                //                            Mostrar Componentes Primários
                this.ckb_active_prefix.Visible = true;
                this.tb_prefix.Visible = true;
            }
        }


        //                                                 2.2 PRINCIPAL   
        public Form1()
        {
            InitializeComponent();
            this.ShortcutInfo();
        }



        //                                                 2.3 APLICAÇÃO
        private void MessageOk(string mensagem)
        {
            MessageBox.Show(mensagem, "TBCODE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MessageAlert(string mensagem)
        {
            MessageBox.Show(mensagem, "TBCODE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MessageError(string mensagem)
        {
            MessageBox.Show(mensagem, "TBCODE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShortcutInfo()
        {
            this.tt_shortcuts.SetToolTip(this.rb_encrypt, "Ctrl + E");
            this.tt_shortcuts.SetToolTip(this.rb_decrypt, "Ctrl + D");
            this.tt_shortcuts.SetToolTip(this.ckb_active_prefix, "Ctrl + I");
            this.tt_shortcuts.SetToolTip(this.btn_execute, "Enter");
            this.tt_shortcuts.SetToolTip(this.btn_clear, "Ctrl + L");
        }

        private void ControlsManager(bool Block)
        {
            if (this.ckb_active_prefix.Checked)
            {
                this.tb_prefix.ReadOnly = Block;
            }
            
            this.tb_entry.ReadOnly = Block;
            this.btn_execute.Enabled = !Block;            
        }

        private void ClearFields()
        {
            // Executar limpeza de campos            
            this.tb_entry.Text = "";
            this.tb_exit.Text = "";

            // Limpar Variaveis
            this.InputData = "";

            // Colocar foco no campo prefixo/entrada
            if (this.ckb_active_prefix.Checked && this.tb_prefix.Text == "")
            {
                this.tb_prefix.Focus();
                this.tb_prefix.Select();
            }
            else
            {
                this.tb_entry.Focus();
                this.tb_entry.Select();
            }            
        }

        private void Execute()
        {
            try
            {
                if (this.tb_entry.Text != string.Empty)
                {
                    this.ControlsManager(true);

                    if (rb_encrypt.Checked)
                    {
                        Encrypt Encrypt = new Encrypt();

                        if (this.ckb_active_prefix.Checked)
                        {
                            this.tb_exit.Text = this.tb_prefix.Text.ToUpper().Trim().Replace(" ", "") + Encrypt.Encode(this.InputData);
                        }
                        else
                        {
                            this.tb_exit.Text = Encrypt.Encode(this.InputData);
                        }
                    }
                    else
                    {
                        Decrypt Decrypt = new Decrypt();

                        if (this.rb_prefix_true.Checked)
                        {
                            this.tb_exit.Text = this.tb_entry.Text.ToString()[0].ToString() + this.tb_entry.Text.ToString()[1].ToString() + Decrypt.Decode(this.InputData);                               
                        }
                        else
                        {
                            this.tb_exit.Text = Decrypt.Decode(this.InputData);
                        }
                    }

                    this.ControlsManager(false);
                }
                else
                {
                    this.MessageAlert("Campo entrada está vazio!");

                    this.tb_entry.Focus();
                    this.tb_entry.Select();
                }
            }
            catch (Exception ex)
            {                
                MessageError(ex.Message + ex.StackTrace);
            }            
        }
        // =====================================================================================================================================================================





        // =============================================== 3. EVENTOS ==========================================================================================================        
        //                                                3.1 COMPONENTES     
        private void ckb_active_prefix_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckb_active_prefix.Checked)
            {
                this.tb_prefix.Enabled = true;
                this.tb_prefix.Focus();
                this.tb_prefix.Select();
            }
            else
            {
                this.tb_prefix.Enabled = false;
                this.tb_prefix.Text = "";
                this.tb_entry.Focus();
                this.tb_entry.Select();
            }
        }

        private void tb_entry_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.rb_decrypt.Checked && this.rb_prefix_true.Checked && this.tb_entry.Text != "")
            {
                this.InputData = this.tb_entry.Text.Trim().Replace(" ", "").Remove(0, 2);
            }
            else
            {
                 this.InputData = this.tb_entry.Text.Trim().Replace(" ", "");                
            }            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            this.Execute();
        }

        
        // Atalhos
        private void tb_prefix_KeyDown(object sender, KeyEventArgs e)
        {
            // Atalho Enter: Foco no campo entrada
            if(e.KeyCode == Keys.Enter)
            {
                this.tb_entry.Focus();
                this.tb_entry.Select();
            }
        }

        private void tb_entry_KeyDown(object sender, KeyEventArgs e)
        {
            // Atalho Enter: Encriptação/Decriptação
            if (e.KeyCode == Keys.Enter)
            {
                this.Execute();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Atalho Ctrl + E: Função Criptografar
            if (e.Control && e.KeyCode == Keys.E)
            {
                this.rb_encrypt.Checked = true;
            }

            // Atalho Ctrl + D: Função Descriptografar
            if (e.Control && e.KeyCode == Keys.D)
            {
                this.rb_decrypt.Checked = true;
            }

            // Atalho Ctrl + I: Ativar Prefixo
            if (e.Control && e.KeyCode == Keys.I)
            {
                if (this.rb_encrypt.Checked)
                {
                    if (!this.ckb_active_prefix.Checked)
                    {
                        this.ckb_active_prefix.Checked = true;
                    }
                    else
                    {
                        this.ckb_active_prefix.Checked = false;
                    }
                }
                else
                {
                    if (!this.rb_prefix_true.Checked)
                    {
                        this.rb_prefix_true.Checked = true;
                    }
                    else
                    {
                        this.rb_prefix_false.Checked = true;
                    }
                }                
            }

            // Atalho Ctrl + L: Limpar Campos
            if (e.Control && e.KeyCode == Keys.L)
            {
                this.ClearFields();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Desligar beep das teclas            
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void rb_decrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_decrypt.Checked)
            {
                this.InitializeRBPrefix(true);
            }            
        }

        private void rb_encrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_encrypt.Checked)
            {
                this.InitializeRBPrefix(false);
            }
        }


        //                                                 3.2 PRINCIPAL   
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tb_entry.Focus();
            this.tb_entry.Select();
        }
        // =====================================================================================================================================================================
    }
}
