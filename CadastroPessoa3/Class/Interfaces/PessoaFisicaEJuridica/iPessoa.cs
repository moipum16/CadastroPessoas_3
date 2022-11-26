using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroJudicial.Class.Interfaces.PessoaFisicaEJuridica
{
    public interface iPessoa
    {
        public abstract string ?Nome{get;set;}
        public abstract string ?Endereco{get;set;}
        public abstract DateTime DataDeNascimento{get;set;}
        public abstract Boolean EPessoaFisica{get;set;}
        public abstract void Inicial();

    }
}