﻿using MyBank.Apresentacao.Console.objetos;

namespace MyBank.Apresentacao.Console.Interfaces
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
