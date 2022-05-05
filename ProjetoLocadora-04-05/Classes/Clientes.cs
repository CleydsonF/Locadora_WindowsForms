using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadora_04_05
{
    public class Clientes
    {
        public string Nome { get; set; }
        public long CPF { get; }
        

        public Clientes(string nome, long cpf)
        {
            Nome = nome;
            CPF = cpf;
            

        }

        public override string ToString()
        {
            return Nome + " - CPF: " + CPF;
        }

    }
    public class ListaDeClientes
    {
        public static List<Clientes> InicializarCliente()
        {
            List<Clientes> clientes = new List<Clientes>();

            clientes.Add(new Clientes("Cleydson", 02145836932));
            clientes.Add(new Clientes("Rafa", 65232145896));
            clientes.Add(new Clientes("João", 74785632114));
            clientes.Add(new Clientes("Pedro", 65232001236));
            clientes.Add(new Clientes("Diogo", 02554198532));
            clientes.Add(new Clientes("Maria", 01220136585));
            return clientes;
        }
    }
}
