using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000.00, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario += (base.Salario * 0.1);
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
