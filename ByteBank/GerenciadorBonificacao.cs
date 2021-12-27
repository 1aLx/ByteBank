using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        
        //Calculando a bonificação dos FUNCIONÁRIOS incluindo o Diretor.
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        //Total das bonificações.
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
