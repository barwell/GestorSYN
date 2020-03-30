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
    public class DLLEstado
    {

        private DALConexao conexao;

        public DLLEstado(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloEstado modelo)
        {
            //verificando se o nome da categoria foi digitado
            if (modelo.EstadoNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Estado é obrigatório!");
            }
            if(modelo.EstadoPaisCod <= 0)
            {
                throw new Exception("O código do País é obrigatório!");
            }

            DALEstado DALobjEstado = new DALEstado(conexao);
            DALobjEstado.Incluir(modelo);
        }
        public void Alterar(ModeloEstado modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.EstadoNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Estado é obrigatório!");
            }
            if (modelo.EstadoCod <= 0)
            {
                throw new Exception("O código da Estado é obrigatório!");
            }
            if (modelo.EstadoPaisCod <= 0)
            {
                throw new Exception("O código do País é obrigatório!");
            }

            DALEstado DALobjEstado = new DALEstado(conexao);
            DALobjEstado.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALEstado DALobjEstado = new DALEstado(conexao);
            DALobjEstado.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALEstado DALobjEstado = new DALEstado(conexao);
            return DALobjEstado.Localizar(valor);
        }

        public DataTable LocalizarItens(int valor, String tabbanco, String coluna)
        {
            DALEstado DALobjEstado = new DALEstado(conexao);
            return DALobjEstado.LocalizarItens(valor, tabbanco, coluna);
        }

        public ModeloEstado CarregaModeloEstado(int codigo)
        {
            DALEstado DALobjEstado = new DALEstado(conexao);
            return DALobjEstado.CarregaModeloEstado(codigo);
        }

    }
}
