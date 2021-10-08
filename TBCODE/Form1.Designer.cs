namespace TBCODE
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_prefix = new System.Windows.Forms.GroupBox();
            this.tb_prefix = new System.Windows.Forms.TextBox();
            this.ckb_active_prefix = new System.Windows.Forms.CheckBox();
            this.gb_input = new System.Windows.Forms.GroupBox();
            this.tb_entry = new System.Windows.Forms.TextBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.gb_output = new System.Windows.Forms.GroupBox();
            this.tb_exit = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.gb_function = new System.Windows.Forms.GroupBox();
            this.rb_decrypt = new System.Windows.Forms.RadioButton();
            this.rb_encrypt = new System.Windows.Forms.RadioButton();
            this.tt_shortcuts = new System.Windows.Forms.ToolTip(this.components);
            this.gb_prefix.SuspendLayout();
            this.gb_input.SuspendLayout();
            this.gb_output.SuspendLayout();
            this.gb_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_prefix
            // 
            this.gb_prefix.Controls.Add(this.tb_prefix);
            this.gb_prefix.Controls.Add(this.ckb_active_prefix);
            this.gb_prefix.Location = new System.Drawing.Point(12, 76);
            this.gb_prefix.Name = "gb_prefix";
            this.gb_prefix.Size = new System.Drawing.Size(171, 56);
            this.gb_prefix.TabIndex = 0;
            this.gb_prefix.TabStop = false;
            this.gb_prefix.Text = "Prefixo";
            // 
            // tb_prefix
            // 
            this.tb_prefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_prefix.Enabled = false;
            this.tb_prefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prefix.Location = new System.Drawing.Point(81, 19);
            this.tb_prefix.MaxLength = 2;
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(76, 24);
            this.tb_prefix.TabIndex = 1;
            this.tb_prefix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_prefix_KeyDown);
            // 
            // ckb_active_prefix
            // 
            this.ckb_active_prefix.AutoSize = true;
            this.ckb_active_prefix.Location = new System.Drawing.Point(15, 25);
            this.ckb_active_prefix.Name = "ckb_active_prefix";
            this.ckb_active_prefix.Size = new System.Drawing.Size(53, 17);
            this.ckb_active_prefix.TabIndex = 1;
            this.ckb_active_prefix.Text = "Ativar";
            this.ckb_active_prefix.UseVisualStyleBackColor = true;
            this.ckb_active_prefix.CheckedChanged += new System.EventHandler(this.ckb_active_prefix_CheckedChanged);
            // 
            // gb_input
            // 
            this.gb_input.Controls.Add(this.tb_entry);
            this.gb_input.Location = new System.Drawing.Point(210, 76);
            this.gb_input.Name = "gb_input";
            this.gb_input.Size = new System.Drawing.Size(275, 56);
            this.gb_input.TabIndex = 1;
            this.gb_input.TabStop = false;
            this.gb_input.Text = "Entrada";
            // 
            // tb_entry
            // 
            this.tb_entry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_entry.Location = new System.Drawing.Point(6, 19);
            this.tb_entry.Name = "tb_entry";
            this.tb_entry.Size = new System.Drawing.Size(260, 24);
            this.tb_entry.TabIndex = 1;
            this.tb_entry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_entry_KeyDown);
            this.tb_entry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_entry_KeyUp);
            // 
            // btn_execute
            // 
            this.btn_execute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_execute.Location = new System.Drawing.Point(410, 150);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(75, 23);
            this.btn_execute.TabIndex = 2;
            this.btn_execute.Text = "Executar";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // gb_output
            // 
            this.gb_output.Controls.Add(this.tb_exit);
            this.gb_output.Location = new System.Drawing.Point(12, 150);
            this.gb_output.Name = "gb_output";
            this.gb_output.Size = new System.Drawing.Size(367, 60);
            this.gb_output.TabIndex = 4;
            this.gb_output.TabStop = false;
            this.gb_output.Text = "Saída";
            // 
            // tb_exit
            // 
            this.tb_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_exit.Location = new System.Drawing.Point(6, 23);
            this.tb_exit.Name = "tb_exit";
            this.tb_exit.ReadOnly = true;
            this.tb_exit.Size = new System.Drawing.Size(355, 24);
            this.tb_exit.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Location = new System.Drawing.Point(410, 187);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // gb_function
            // 
            this.gb_function.Controls.Add(this.rb_decrypt);
            this.gb_function.Controls.Add(this.rb_encrypt);
            this.gb_function.Location = new System.Drawing.Point(12, 12);
            this.gb_function.Name = "gb_function";
            this.gb_function.Size = new System.Drawing.Size(473, 48);
            this.gb_function.TabIndex = 6;
            this.gb_function.TabStop = false;
            this.gb_function.Text = "Função";
            // 
            // rb_decrypt
            // 
            this.rb_decrypt.AutoSize = true;
            this.rb_decrypt.Location = new System.Drawing.Point(276, 19);
            this.rb_decrypt.Name = "rb_decrypt";
            this.rb_decrypt.Size = new System.Drawing.Size(97, 17);
            this.rb_decrypt.TabIndex = 1;
            this.rb_decrypt.Text = "Descriptografar";
            this.rb_decrypt.UseVisualStyleBackColor = true;
            this.rb_decrypt.CheckedChanged += new System.EventHandler(this.rb_decrypt_CheckedChanged);
            // 
            // rb_encrypt
            // 
            this.rb_encrypt.AutoSize = true;
            this.rb_encrypt.Checked = true;
            this.rb_encrypt.Location = new System.Drawing.Point(107, 19);
            this.rb_encrypt.Name = "rb_encrypt";
            this.rb_encrypt.Size = new System.Drawing.Size(79, 17);
            this.rb_encrypt.TabIndex = 0;
            this.rb_encrypt.TabStop = true;
            this.rb_encrypt.Text = "Criptografar";
            this.rb_encrypt.UseVisualStyleBackColor = true;
            this.rb_encrypt.CheckedChanged += new System.EventHandler(this.rb_encrypt_CheckedChanged);
            // 
            // tt_shortcuts
            // 
            this.tt_shortcuts.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tt_shortcuts.IsBalloon = true;
            this.tt_shortcuts.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_shortcuts.ToolTipTitle = "Atalho";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 222);
            this.Controls.Add(this.gb_function);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.gb_output);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.gb_input);
            this.Controls.Add(this.gb_prefix);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TBCODE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.gb_prefix.ResumeLayout(false);
            this.gb_prefix.PerformLayout();
            this.gb_input.ResumeLayout(false);
            this.gb_input.PerformLayout();
            this.gb_output.ResumeLayout(false);
            this.gb_output.PerformLayout();
            this.gb_function.ResumeLayout(false);
            this.gb_function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_prefix;
        private System.Windows.Forms.TextBox tb_prefix;
        private System.Windows.Forms.CheckBox ckb_active_prefix;
        private System.Windows.Forms.GroupBox gb_input;
        private System.Windows.Forms.TextBox tb_entry;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.GroupBox gb_output;
        private System.Windows.Forms.TextBox tb_exit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox gb_function;
        private System.Windows.Forms.RadioButton rb_decrypt;
        private System.Windows.Forms.RadioButton rb_encrypt;
        private System.Windows.Forms.ToolTip tt_shortcuts;
    }
}

