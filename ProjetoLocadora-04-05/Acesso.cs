using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLocadora_04_05
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string senha = "adm";
            string usuario = "adm";
            if (entrarUsuario.Text == usuario && entrarSenha.Text == senha)
            {
                Form1 locacao = new Form1();
                locacao.Show();

            }
            else
            {
                MessageBox.Show("Usuário/Senha incorreto");
                entrarUsuario.Clear();
                entrarSenha.Clear();
                entrarUsuario.Focus();

            }
        }
    }
}
