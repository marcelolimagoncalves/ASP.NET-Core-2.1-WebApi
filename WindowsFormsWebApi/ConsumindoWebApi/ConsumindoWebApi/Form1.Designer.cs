namespace ConsumindoWebApi
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
            this.txtURI = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnIncluirUsuario = new System.Windows.Forms.Button();
            this.btnAtualizaUsuario = new System.Windows.Forms.Button();
            this.btnDeletarUsuario = new System.Windows.Forms.Button();
            this.btnUsuarioById = new System.Windows.Forms.Button();
            this.btnObterUsuarios = new System.Windows.Forms.Button();
            this.txtUsuarioId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(187, 13);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(564, 20);
            this.txtURI.TabIndex = 0;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(30, 39);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(928, 350);
            this.dgvDados.TabIndex = 1;
            // 
            // btnIncluirUsuario
            // 
            this.btnIncluirUsuario.Location = new System.Drawing.Point(140, 414);
            this.btnIncluirUsuario.Name = "btnIncluirUsuario";
            this.btnIncluirUsuario.Size = new System.Drawing.Size(121, 23);
            this.btnIncluirUsuario.TabIndex = 3;
            this.btnIncluirUsuario.Text = "Incluir Usuário";
            this.btnIncluirUsuario.UseVisualStyleBackColor = true;
            this.btnIncluirUsuario.Click += new System.EventHandler(this.btnIncluirUsuario_Click);
            // 
            // btnAtualizaUsuario
            // 
            this.btnAtualizaUsuario.Location = new System.Drawing.Point(267, 414);
            this.btnAtualizaUsuario.Name = "btnAtualizaUsuario";
            this.btnAtualizaUsuario.Size = new System.Drawing.Size(108, 23);
            this.btnAtualizaUsuario.TabIndex = 4;
            this.btnAtualizaUsuario.Text = "Alterar Usuário";
            this.btnAtualizaUsuario.UseVisualStyleBackColor = true;
            this.btnAtualizaUsuario.Click += new System.EventHandler(this.btnAtualizaUsuario_Click);
            // 
            // btnDeletarUsuario
            // 
            this.btnDeletarUsuario.Location = new System.Drawing.Point(381, 414);
            this.btnDeletarUsuario.Name = "btnDeletarUsuario";
            this.btnDeletarUsuario.Size = new System.Drawing.Size(115, 23);
            this.btnDeletarUsuario.TabIndex = 5;
            this.btnDeletarUsuario.Text = "Deletar Usuário";
            this.btnDeletarUsuario.UseVisualStyleBackColor = true;
            this.btnDeletarUsuario.Click += new System.EventHandler(this.btnDeletarUsuario_Click);
            // 
            // btnUsuarioById
            // 
            this.btnUsuarioById.Location = new System.Drawing.Point(502, 414);
            this.btnUsuarioById.Name = "btnUsuarioById";
            this.btnUsuarioById.Size = new System.Drawing.Size(104, 23);
            this.btnUsuarioById.TabIndex = 6;
            this.btnUsuarioById.Text = "Usuário por ID";
            this.btnUsuarioById.UseVisualStyleBackColor = true;
            this.btnUsuarioById.Click += new System.EventHandler(this.btnUsuarioById_Click);
            // 
            // btnObterUsuarios
            // 
            this.btnObterUsuarios.Location = new System.Drawing.Point(30, 414);
            this.btnObterUsuarios.Name = "btnObterUsuarios";
            this.btnObterUsuarios.Size = new System.Drawing.Size(104, 23);
            this.btnObterUsuarios.TabIndex = 7;
            this.btnObterUsuarios.Text = "Todos Usuários";
            this.btnObterUsuarios.UseVisualStyleBackColor = true;
            this.btnObterUsuarios.Click += new System.EventHandler(this.btnObterUsuarios_Click);
            // 
            // txtUsuarioId
            // 
            this.txtUsuarioId.Location = new System.Drawing.Point(790, 12);
            this.txtUsuarioId.Name = "txtUsuarioId";
            this.txtUsuarioId.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioId.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 479);
            this.Controls.Add(this.txtUsuarioId);
            this.Controls.Add(this.btnObterUsuarios);
            this.Controls.Add(this.btnUsuarioById);
            this.Controls.Add(this.btnDeletarUsuario);
            this.Controls.Add(this.btnAtualizaUsuario);
            this.Controls.Add(this.btnIncluirUsuario);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtURI);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnIncluirUsuario;
        private System.Windows.Forms.Button btnAtualizaUsuario;
        private System.Windows.Forms.Button btnDeletarUsuario;
        private System.Windows.Forms.Button btnUsuarioById;
        private System.Windows.Forms.Button btnObterUsuarios;
        private System.Windows.Forms.TextBox txtUsuarioId;
    }
}

