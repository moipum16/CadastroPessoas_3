using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroJudicial.Class;
using CadastroJudicial.Class.Interfaces.Controlador;
using CadastroJudicial.Class.Objetos.Pessoa;

namespace CadastroJudicial.Class.Objetos.Controlador
{
    public class Controlador_1 : Controlador_0
    {
        public Controlador_1 ?Self{get;set;}
        public long PessoasEnumerador{get;set;}
        private void CriarPessoa()
        {
            Pessoa_1 PS = new Pessoa_1();
            PS.GlobalController=Self;
            PS.Inicial();
            PessoasEnumerador++;
        }

        private int RemoverPessoa(int index)
        {
            return index;
        }

        public void Inicial()
        {
            PessoasEnumerador=0;
            CriarPessoa();
        }

        public void Recursao(string NNome, string EEndereco, DateTime DataDDeNascimento, Boolean EPessoaFisicaa, long FinaldFDOcumento)
        {
           
            Console.WriteLine($"Finalizado! Nome: {NNome}, Endereço: {EEndereco}, Data de Nascimento: {DataDDeNascimento}, Documento: {FinaldFDOcumento}, é Pessoa jurídica?: {EPessoaFisicaa}.");
            Console.WriteLine("");
            Console.WriteLine("Pressione Enter para sair!");
            Console.ReadLine();

        }
    }
}