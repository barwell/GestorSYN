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
    public class DLLCentroCustos
    {

         private DALConexao conexao;

        public DLLCentroCustos(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCentroCustos modelo)
        {
            //verificando se o nome do centro de custos foi digitado
            if (modelo.CentroCustNome.Trim().Length == 0)
            {
                throw new Exception("O nome do centro é obrigatório!");
            }

            DALCentroCustos DALobj = new DALCentroCustos(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloCentroCustos modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.CentroCustNome.Trim().Length == 0)
            {
                throw new Exception("O nome do centro é obrigatório!");
            }
            if (modelo.CentroCustCod <= 0)
            {
                throw new Exception("O código do centro é obrigatório!");
            }

            DALCentroCustos DALobj = new DALCentroCustos(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCentroCustos DALobj = new DALCentroCustos(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCentroCustos DALobj = new DALCentroCustos(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaCentroCustos(string valor) //0 - não encontrado || valor > 0 - valor encontrado
        {
            DALCentroCustos DALobj = new DALCentroCustos(conexao);
            return DALobj.VerificaCentroCustos(valor);
        }

        public ModeloCentroCustos CarregaModeloCentroCustos(int codigo)
        {
            DALCentroCustos DALobj = new DALCentroCustos(conexao);
            return DALobj.CarregaModeloCentroCustos(codigo);
        }

    }
}
