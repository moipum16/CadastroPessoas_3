using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroJudicial.Class.Interfaces.PessoaFisicaEJuridica;
using CadastroJudicial.Class.Objetos.Controlador;

namespace CadastroJudicial.Class.Objetos.Pessoa
{
    public class Pessoa_1 : iPessoa, PessoaFisica, PessoaJuridica
    {
        public Controlador_1 ?GlobalController{get;set;}
        public Boolean EPessoaFisica{get;set;}
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public long CPNJ { get; set; }
        public long CPF { get; set;}
        public long FinalDocumentoNumeracao{get;set;}
        public void Inicial()
        {
            void QNome()
            {
                Console.WriteLine(" ");
                Console.WriteLine("Qual o seu nome?");
                Console.WriteLine(" ");

                try
                {
                    Nome=Console.ReadLine();
                    QEndereco();
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Caracteres inválidos!");
                    Console.WriteLine(" ");
                    QNome();
                }

            }

            void QEndereco()
            {
                Console.WriteLine(" ");
                Console.WriteLine("Qual o seu endereço?");
                Console.WriteLine(" ");

                try
                {
                    Endereco=Console.ReadLine();
                    QData();
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Caracteres inválidos!");
                    Console.WriteLine(" ");
                    QEndereco();
                }
            }

            void QData()
            {  
                Console.WriteLine(" ");
                Console.WriteLine("Qual a sua data de nascimento?");
                Console.WriteLine(" ");

                try
                {
                    DataDeNascimento=DateTime.Parse(Console.ReadLine());
                    QEPessoaFisica();
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Data inválida!");
                    Console.WriteLine(" ");
                    QData();
                }

            }

            void QEPessoaFisica()
            {
                Console.WriteLine(" ");
                Console.WriteLine("Você possui CPNJ? true ou false.");
                Console.WriteLine(" ");

                try
                {
                    EPessoaFisica=Convert.ToBoolean(Console.ReadLine());

                    if(EPessoaFisica==true)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Qual o seu CPNJ?");
                        Console.WriteLine(" ");
                        try
                        {
                            CPNJ=Convert.ToInt64(Console.ReadLine());
                            FinalDocumentoNumeracao=CPNJ;
                        }
                        catch
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("CPNJ Inválido, o valor deve ser numérico.");
                            Console.WriteLine(" ");
                            QEPessoaFisica();
                        }
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Qual o seu CPF?");
                        Console.WriteLine(" ");

                        try
                        {
                            CPF=Convert.ToInt64(Console.ReadLine());
                            FinalDocumentoNumeracao=CPF;
                        }
                        catch
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("CPF Inválido, o valor deve ser numérico.");
                            Console.WriteLine(" ");
                            QEPessoaFisica();
                        }
                    }

                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Inválido. Digite: true ou false.");
                    Console.WriteLine(" ");
                    QEPessoaFisica();
                }
            }

            Nome="";
            Endereco="";
            QNome();

            GlobalController.Recursao(Nome, Endereco, DataDeNascimento, EPessoaFisica, FinalDocumentoNumeracao);
        }
    }
}