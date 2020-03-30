/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 03/01/2016
 *Data da Ultima Revisão: 
 *
 * Descrição: Classe utilizada para validar as alterações feitas.
 *
 * Modificações da Revisão: Nenhuma
 */



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
    public class DLLTipoCobranca
    {

         private DALConexao conexao;

        public DLLTipoCobranca(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoCobranca modelo)
        {
            //verificando se o nome do tipo de cobrança foi digitado
            if (modelo.TipoCobNome.Trim().Length == 0)
            {
                throw new Exception("O nome do tipo é obrigatório!");
            }

            DALTipoCobranca DALobj = new DALTipoCobranca(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloTipoCobranca modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.TipoCobNome.Trim().Length == 0)
            {
                throw new Exception("O nome do tipo é obrigatório!");
            }
            if (modelo.TipoCobCod <= 0)
            {
                throw new Exception("O código do tipo é obrigatório!");
            }

            DALTipoCobranca DALobj = new DALTipoCobranca(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALTipoCobranca DALobj = new DALTipoCobranca(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALTipoCobranca DALobj = new DALTipoCobranca(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaTipoCobranca(string valor) //0 - não encontrado || valor > 0 - valor encontrado
        {
            DALTipoCobranca DALobj = new DALTipoCobranca(conexao);
            return DALobj.VerificaTipoCobranca(valor);
        }

        public ModeloTipoCobranca CarregaModeloTipoCobranca(int codigo)
        {
            DALTipoCobranca DALobj = new DALTipoCobranca(conexao);
            return DALobj.CarregaModeloTipoCobranca(codigo);
        }

    }
}
