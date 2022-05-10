using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAula33_PreProva.domain
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        
        public string Sobrenome { get; set; }

        public int Idade { get; set; }

        public const double salarioFixo = 4350.19; 
        public Pessoa(string nome, string sobrenome, int idade)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
        }
        public Pessoa()
        {

        }
        public void mudarNome(string nome)
        {
            

        }

        public override string ToString()
        {
            //return $"Nome: {Nome}{ Sobrenome}, Idade: {Idade}";
            return "Nome: " + Nome + ", Sobrenome: " + Sobrenome + " e a idade: "+ Idade;
        }

    }
}
