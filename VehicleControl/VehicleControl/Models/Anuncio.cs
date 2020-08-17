using System;
using VehicleControl.Models.Enums;


namespace VehicleControl.Models
{
    public class Anuncio
    {
        public int id { get; set; }
        public Modelo Modelo { get; set; }
        public Marca Marca { get; set; }
        public int Ano { get; set; }
        public double Valor { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public DateTime DataVenda { get; set; }
        public AnuncioStatus Status { get; set; }
       
        public Anuncio()
        {
        }

        public Anuncio(Modelo modelo, Marca marca, int ano, double valor, string cor, string combustivel, DateTime dataVenda, AnuncioStatus status)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Valor = valor;
            Cor = cor;
            Combustivel = combustivel;
            DataVenda = dataVenda;
            Status = status;
        }
    }
}
