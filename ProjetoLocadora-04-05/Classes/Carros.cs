using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadora_04_05
{
    class Carros
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public Carros(string marca, string modelo, int ano, string cor, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
            Placa = placa;
        }
        public override string ToString()
        {
            return Marca + " - " + Modelo + " - Ano: " + Ano + " Cor: " + Cor + " Placa: " + Placa;
        }
        public class ListaDeCarros
        {
            public static List<Carros> InicializarCarros()
            {
                List<Carros> carros = new List<Carros>();
                carros.Add(new Carros("Ford", "FordKa", 2020, "Azul", "PMX-2123"));
                carros.Add(new Carros("Chevrolet", "Cobalt", 2022, "Branco", "PGM-4525"));
                carros.Add(new Carros("Chevrolet", "S-10", 2021, "Braco", "PMG-1455"));
                carros.Add(new Carros("Chevrolet", "Celta", 2015, "Preto", "PCD-4417"));
                carros.Add(new Carros("Volkswagen", "Gol", 2022, "Preto", "KHA-2552"));

                return carros;
            }
        }

    }
}
