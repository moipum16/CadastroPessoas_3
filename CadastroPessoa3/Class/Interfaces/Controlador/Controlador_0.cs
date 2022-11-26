using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroJudicial.Class;
using CadastroJudicial.Class.Objetos.Pessoa;

namespace CadastroJudicial.Class.Interfaces.Controlador
{
    public interface Controlador_0
    {
        public abstract void Inicial();
        public abstract long PessoasEnumerador{get;set;}
        
    }
}