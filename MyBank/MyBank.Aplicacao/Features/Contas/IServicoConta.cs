using MyBank.Aplicacao.Interfaces;
using MyBank.Dominio.Features.Agencias;
using MyBank.Dominio.Features.Contas;

namespace MyBank.Aplicacao.Features.Contas
{
	public interface IServicoConta : IServico<Conta>
	{
		Agencia SelecionarAgencia(string nome);
	}
}