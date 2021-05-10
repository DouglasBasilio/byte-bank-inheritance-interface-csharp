using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankOPP.Funcionarios
{
    public class Diretor : Funcionario // através dos 'dois pontos' eu extendo a classe funcionario para diretor
    {
        
        public double GetBonificacao()
        {
            return Salario;
        }
    }
}
