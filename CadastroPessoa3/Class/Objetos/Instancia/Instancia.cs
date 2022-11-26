using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroJudicial.Class;
using CadastroJudicial.Class.Interfaces.Instancia;
using CadastroJudicial.Class.Objetos.Controlador;

namespace CadastroJudicial.Class.Objetos.Instancia
{
    public class Instancia : Instancia_0
    {
        public void inicial()
        {
            Controlador_1 CC= new Controlador_1();
            CC.Self=CC;
            CC.Inicial();
        }

    }
}