﻿using Dominio;
using Dominio.Enum;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    public class ProdutoModel
    {
        private ProdutoRepositorio _produtoRepositorio = new ProdutoRepositorio();

        public async Task<Produto[]> ListarProdutos()
        {
            return await _produtoRepositorio.GetAllAsync();
        }

        public async void AdicionarProduto
        (
            string descricao,
            UnidadeMedida unidadeDeMedida,
            string codBarras,
            decimal precoCusto,
            decimal precoVenda,
            bool ativo,
            ProdutoGrupo produtoGrupo
        )
        {
            Produto produto = new Produto(descricao, unidadeDeMedida, codBarras, precoCusto, precoVenda, DateTime.Now, ativo, produtoGrupo);

            _produtoRepositorio.Add(produto);
            await _produtoRepositorio.SaveChangesAsync();
        }
    }
}
