/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 15/12/2015
 *Data da Ultima Revisão: 15/12/2015
 *
 * Descrição: Classe utilizada para validar as alterações feitas.
 *
 * Modificações da Revisão: Nenhuma
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;

namespace DLL
{
    public class DLLSubCategoria
    {

        private DALConexao conexao;

        public DLLSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            //verificando se o nome da categoria foi digitado
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório!");
            }
            if(modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório!");
            }

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloSubCategoria modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório!");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório!");
            }
            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório!");
            }

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.CarregaModeloSubCategoria(codigo);
        }

    }
}
