using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000.00, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario += (base.Salario * 0.11);
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
