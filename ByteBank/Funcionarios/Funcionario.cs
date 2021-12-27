using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        //0 - Funcionario
        //1 - Diretor
        //2 - Designer
        //3 - Gerente de conta corrente
        //4 - Coordenador
        //N - ...

        //Buscando quantos funcionarios tem neste banco.
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        //Construtor.
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONÁRIO!");
            
            Salario = salario;
            CPF = cpf;

            TotalDeFuncionarios++;
        }

        //Aumento de sálário.
        //Mudar para o diretor a porcentagem.
        //No lugar de virtual, podemos utilizar a palavra abstratct para ser obrigatorio os metodos de sobrescritas dentro das classes.
        public abstract void AumentarSalario();

        //Regra do banco ByteBank de bonificação de 10% a.a
        //Permissão de sobrescrita. (virtual)
        public abstract double GetBonificacao();

    }
}
