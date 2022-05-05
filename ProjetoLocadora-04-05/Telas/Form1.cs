using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static ProjetoLocadora_04_05.Carros;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoLocadora_04_05
{
    public partial class Form1 : Form
    {

        List<Carros> carros = ListaDeCarros.InicializarCarros();
        List<Clientes> clientes = ListaDeClientes.InicializarCliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach (Clientes cliente in clientes)
            {
                cbxListaDeClientes.Items.Add(cliente);
            }

            foreach (Carros item in carros)
            {
                cbxListaDeCarros.Items.Add(item);
            }
            // não mostra o erro até compilar, se liga
        }



        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            double valorTotal ;
            Clientes cliente = clientes[cbxListaDeClientes.SelectedIndex];
            Carros carro = carros[cbxListaDeCarros.SelectedIndex];
            double valorDiaria = Convert.ToDouble(txtDiarias.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            valorTotal = valor * valorDiaria;
            MessageBox.Show((string.Format($"{cliente}, {carro} , Valor: {valorTotal}")));
            MessageBox.Show("Locação Realizada com Sucesso!");
            Close();
        }

        
    }
}
