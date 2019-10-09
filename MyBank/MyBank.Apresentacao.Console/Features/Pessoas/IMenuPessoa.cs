﻿using MyBank.Apresentacao.Console.objetos;

namespace MyBank.Apresentacao.Console.Features.Pessoas
{
	public interface IMenuPessoa<T>
	{
		void Inicio(Menu menu);
		void Cadastrar();
		void Atualizar();
		void Remover();
		void SelecionarTudo();
	}
}