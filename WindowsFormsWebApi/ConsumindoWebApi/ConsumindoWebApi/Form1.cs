using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ConsumindoWebApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string URI = "";
        int codigoUsuario = 1;
               
        private async void btnObterUsuarios_Click(object sender, EventArgs e)
        {
            URI = txtURI.Text;
            dgvDados.DataSource = await ConsomeApi.GetUsuarios(URI); 
        }

        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            URI = txtURI.Text;
            Usuario usuario = new Usuario();
            usuario.Nome = "Elvis Presley";
            usuario.Senha = "elvis123";
            usuario.Email = "elvis@teste.com";

            ConsomeApi.AddUsuario(URI, usuario);
        }

        private void btnAtualizaUsuario_Click(object sender, EventArgs e)
        {
            URI = txtURI.Text;
            InputBox();
            if(codigoUsuario != -1)
            {
                Usuario usuario = new Usuario();
                usuario.UsuarioId = codigoUsuario;
                usuario.Nome = "Elvis Presley";
                usuario.Senha = "elvis123";
                usuario.Email = "xxxxxxxxxxxx@teste.com";

                try
                {
                    URI = URI + "/" + codigoUsuario;
                    ConsomeApi.UpdateUsuario(URI, usuario);
                    MessageBox.Show("Usuário atualizado com sucesso");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro : ", ex.Message);
                }
            }
        }

        private void btnDeletarUsuario_Click(object sender, EventArgs e)
        {
            URI = txtURI.Text;
            InputBox();
            if(codigoUsuario != -1)
            {
                try
                {
                    ConsomeApi.DeleteUsuario(URI, codigoUsuario);
                    MessageBox.Show("Usuário deletado com sucesso");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro : ", ex.Message);
                }
            }
        }

        private async void btnUsuarioById_Click(object sender, EventArgs e)
        {
            BindingSource bsDados = new BindingSource();
            URI = txtURI.Text;
            InputBox();
            if(codigoUsuario != -1)
            {
                URI = txtURI.Text + "/" + codigoUsuario.ToString();
                bsDados.DataSource = await ConsomeApi.GetUsuarioById(URI);
                dgvDados.DataSource = bsDados;
            }
        }

        private void InputBox()
        {
            string Prompt = "Informe o código do Usuário.";
            string Titulo = "www.marcelo.com.br";
            //string Resultado = Interaction.InputBox(Prompt, Titulo, "9", 600, 350);
            
            string Resultado = txtUsuarioId.Text;
            if (Resultado != "")
            {
                codigoUsuario = Convert.ToInt32(Resultado);
            }
            else
            {
                codigoUsuario = -1;
            }
        }
    }
}
