using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankOPP.Funcionarios
{
    public class Diretor : Funcionario // através dos 'dois pontos' eu extendo a classe funcionario para diretor
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao() // sobrepondo o método da classe Funcionario
        {
            return Salario + base.GetBonificacao(); // base - referência da classe Funcionario
        }
    }
}
