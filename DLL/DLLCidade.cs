using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DLLCidade
    {
         private DALConexao conexao;

        public DLLCidade(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCidade modelo)
        {
            //verificando se o nome da categoria foi digitado
            if (modelo.CityNome.Trim().Length == 0)
            {
                throw new Exception("O nome da cidade é obrigatório!");
            }
            if(modelo.CityEstadoCod <= 0)
            {
                throw new Exception("O código do Estado é obrigatório!");
            }

            DALCidade DALobjCidade = new DALCidade(conexao);
            DALobjCidade.Incluir(modelo);
        }
        public void Alterar(ModeloCidade modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.CityNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Cidade é obrigatório!");
            }
            if (modelo.CityCod <= 0)
            {
                throw new Exception("O código da Cidade é obrigatório!");
            }
            if (modelo.CityEstadoCod <= 0)
            {
                throw new Exception("O código do Estado é obrigatório!");
            }

            DALCidade DALobjCidade = new DALCidade(conexao);
            DALobjCidade.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCidade DALobjCidade = new DALCidade(conexao);
            DALobjCidade.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCidade DALobjCidade = new DALCidade(conexao);
            return DALobjCidade.Localizar(valor);
        }

        public DataTable LocalizarItens(int valor, String tabbanco, String coluna)
        {
            DALEstado DALobjEstado = new DALEstado(conexao);
            return DALobjEstado.LocalizarItens(valor, tabbanco, coluna);
        }

        public ModeloCidade CarregaModeloCidade(int codigo)
        {
            DALCidade DALobjCidade = new DALCidade(conexao);
            return DALobjCidade.CarregaModeloCidade(codigo);
        }

    }
}
