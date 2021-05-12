using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankOPP.Funcionarios
{
    public class Funcionario
    {     
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf) // primeiro é executado o construtor da classe base e depois da classe derivada
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario * 1.1;
            Salario *= 1.1;
        }

        public virtual double GetBonificacao() // método virtual, tem uma implementação, mas é possível sobrescrever
        {
           return Salario * 0.10;
        }
    }
}
