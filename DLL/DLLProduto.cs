using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DLLProduto
    {

        private DALConexao conexao;

        public DLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto modelo)
        {
            //verificando se o nome da categoria foi digitado
            if (modelo.ProdutoNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório!");
            }
            

            DALProduto DALobjProduto = new DALProduto(conexao);
            DALobjProduto.Incluir(modelo);
        }
        public void Alterar(ModeloProduto modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.ProdutoNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório!");
            }
            if (modelo.ProdutoCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório!");
            }
            

            DALProduto DALobjProduto = new DALProduto(conexao);
            DALobjProduto.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALProduto DALobjProduto = new DALProduto(conexao);
            DALobjProduto.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALProduto DALobjProduto = new DALProduto(conexao);
            return DALobjProduto.Localizar(valor);
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALobjProduto = new DALProduto(conexao);
            return DALobjProduto.CarregaModeloProduto(codigo);
        }

    }
}
