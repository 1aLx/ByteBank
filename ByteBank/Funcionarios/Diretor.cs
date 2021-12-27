using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        //Recebendo os argumentos de cpf da classe base.
        public Diretor(string cpf) : base(5000.00, cpf)
        {
            Console.WriteLine("Criando DIRETOR!");
        }

        public override void AumentarSalario()
        {
            Salario += (base.Salario * 0.15);
        }
        //Sobrescrevendo o comportamento do funcionário.
        public override double GetBonificacao()
        {
            //Chamando o GetBonificação() que foi a sobrescrita do FUNCIONARIO e não da classe Main.
            return Salario * 0.5;
        }
    }
}
