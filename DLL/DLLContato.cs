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
    public class DLLContato
    {

        private DALConexao conexao;

        public DLLContato(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloContato modelo)
        {
            //verificando se o nome da categoria foi digitado
            if (modelo.ContatoNome.Trim().Length == 0)
            {
                throw new Exception("O nome do contato é obrigatório!");
            }
            

            DALContato DALobjContato = new DALContato(conexao);
            DALobjContato.Incluir(modelo);
        }
        public void Alterar(ModeloContato modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.ContatoNome.Trim().Length == 0)
            {
                throw new Exception("O nome do contato é obrigatório!");
            }
            if (modelo.ContatoCod <= 0)
            {
                throw new Exception("O código do contato é obrigatório!");
            }
            

            DALContato DALobjContato = new DALContato(conexao);
            DALobjContato.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALContato DALobjContato = new DALContato(conexao);
            DALobjContato.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALContato DALobjContato = new DALContato(conexao);
            return DALobjContato.Localizar(valor);
        }

        public ModeloContato CarregaModeloContato(int codigo)
        {
            DALContato DALobjContato = new DALContato(conexao);
            return DALobjContato.CarregaModeloContato(codigo);
        }


    }
}
