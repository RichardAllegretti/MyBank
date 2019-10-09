using System;
using MyBank.Aplicacao;
using MyBank.Aplicacao.Features.Agencias;
using MyBank.Apresentacao.Console.Features.Agencias;
using MyBank.Dominio.Features.Agencias;
using MyBank.Dominio.Interfaces;
using MyBank.Infra.Gerenciamento.Banco;
using MyBank.Infra.Gerenciamento.Banco.Features.SQLServer;
using MyBank.Infra.SQL;
using MyBank.Infra.SQL.Features.Agencias;

namespace MyBank.Apresentacao.Console.objetos
{
    public class Menu
    {
        private static IGerenciadorSQL<Agencia> _gerenciador = new GerenciadorSQL(); 

		private static IArmazenamento<Agencia> _daoAgencia = new AgenciaSQLDAO(_gerenciador);
		//private static IArmazenamento<Conta> _daoConta = new AgenciaSQLDAO(_gerenciador);
		//private static IArmazenamento<Pessoa> _daoPessoa = new PessoaDAO();		

		private static ServicoAgencia _servicoAgencia = new ServicoAgencia(_daoAgencia);
		//private static ServicoConta _servicoConta = new ServicoConta( _daoConta, _servicoAgencia, _servicoPessoa );
		//private static ServicoPessoa _servicoPessoa = new ServicoPessoa( _daoPessoa, _servicoAgencia, _servicoConta );

		private static MenuAgencia _agencia = new MenuAgencia( _servicoAgencia );
		//private static MenuConta _conta = new MenuConta( _servicoConta );
		//private static MenuPessoa _pessoa = new MenuPessoa( _servicoPessoa );

		public void Inicio()
        {
            System.Console.WriteLine("Bem vindo ao MyBank. \n");
            System.Console.WriteLine( "Agencia: F1 \nContas: F2\nPessoa: F3" );
            var opcao = System.Console.ReadKey();

            switch (opcao.Key)
            {
                case ConsoleKey.F1:
                    _agencia.Inicio(this);
                    break;
                case ConsoleKey.F2:
					//_conta.Inicio(this);
                    break;
				case ConsoleKey.F3:
					//_pessoa.Inicio( this );
					break;
				default:
                    System.Console.WriteLine("Opção Inválida.");
                    break;
            }
        }
    }
}
