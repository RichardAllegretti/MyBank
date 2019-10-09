using MyBank.Apresentacao.Console.objetos;

namespace MyBank.Apresentacao.Console.Features.Contas
{
	public interface IMenuConta<T>
	{
		void Inicio(Menu menu);
		void Cadastrar();
		void Atualizar();
		void Remover();
		void SelecionarTudo();
	}
}
