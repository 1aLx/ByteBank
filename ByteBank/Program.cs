using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadKey();
        }

        //Usando o sistema a partir de Login.
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("21.654.987-01");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta leticia = new GerenteDeConta("326.985.628-89");
            leticia.Nome = "Letícia";
            leticia.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(leticia, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario gabriel = new Designer("833.222.048-39");
            gabriel.Nome = "Gabriel";

            Funcionario roberta = new Diretor("321.654.987-01");
            roberta.Nome = "Roberta";

            Funcionario vinicius = new Auxiliar("981.198.177-42");
            vinicius.Nome = "Vinícius";

            Funcionario leticia = new GerenteDeConta("326.985.628-89");
            leticia.Nome = "Letícia";

            Funcionario alexandre = new Desenvolvedor("147.125.896-112");
            alexandre.Nome = "Alexandre";

            gerenciadorBonificacao.Registrar(gabriel); 
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(vinicius);
            gerenciadorBonificacao.Registrar(leticia);

            Console.WriteLine($"Total de bonificações do mês: R${gerenciadorBonificacao.GetTotalBonificacao()}");
        }
    }
}
