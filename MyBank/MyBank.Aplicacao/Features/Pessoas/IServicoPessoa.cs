using MyBank.Aplicacao.Interfaces;
using MyBank.Dominio.Features.Agencias;
using MyBank.Dominio.Features.Contas;
using MyBank.Dominio.Features.Pessoas;

namespace MyBank.Aplicacao.Features.Pessoas
{
	public interface IServicoPessoa : IServico<Pessoa>
	{
		Agencia SelecionarAgencia(string nome);
		Conta SelecionarConta(string nome);
	}
}
