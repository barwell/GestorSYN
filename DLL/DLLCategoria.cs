/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 24/11/2015
 *Data da Ultima Revisão: 24/11/2015
 *
 * Descrição: Classe utilizada para validar as alterações feitas.
 *
 * Modificações da Revisão: Nenhuma
 */

using Modelo;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DLLCategoria
    {
        private DALConexao conexao;

        public DLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            //verificando se o nome da categoria foi digitado
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }
            //Comando coloca o nome sempre em maiúsculo
            modelo.CatNome = modelo.CatNome.ToUpper();

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloCategoria modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório para alterar o registro!");
            }
            //verificando se o nome da categoria foi digitado
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }
            //Comando coloca o nome sempre em maiúsculo
            modelo.CatNome = modelo.CatNome.ToUpper();

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.CarregaModeloCategoria(codigo);
        }
    }
}
