﻿using ByteBankOPP.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankOPP
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario douglas = new Funcionario(2000, "123.123.123-54");

            douglas.Nome = "Douglas";

            douglas.AumentarSalario();
            Console.WriteLine("Novo salário do Douglas " + douglas.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(douglas);

            Diretor felipe = new Diretor("312.312.312-43");
            felipe.Nome = "Felipe";
            //felipe.CPF = "312.312.312-43";

            felipe.AumentarSalario();
            Console.WriteLine("Novo salário do Felipe " + felipe.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(felipe);

            Console.WriteLine(douglas.Nome);
            Console.WriteLine(douglas.GetBonificacao());

            Console.WriteLine(felipe.Nome);
            Console.WriteLine(felipe.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
