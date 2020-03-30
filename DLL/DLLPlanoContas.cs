/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 31/12/2015
 *Data da Ultima Revisão: nunca
 *
 * Descrição: Classe utilizada para validar as alterações feitas.
 *
 * Modificações da Revisão: Nenhuma
 */

using Modelo;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLL
{
    public class DLLPlanoContas
    {
        private DALConexao conexao;

        public DLLPlanoContas(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPlanoContas modelo)
        {
            //verificando se o nome do plano de contas foi digitado
            if (modelo.PlanContaNome.Trim().Length == 0)
            {
                throw new Exception("O nome do plano de contas é obrigatório!");
            }
            //Comando coloca o nome sempre em maiúsculo
            modelo.PlanContaNome = modelo.PlanContaNome.ToUpper();

            DALPlanoContas DALobj = new DALPlanoContas(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloPlanoContas modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.PlanContaCod <= 0)
            {
                throw new Exception("O código do plano de contas é obrigatório para alterar o registro!");
            }
            //verificando se o nome do plano de contas foi digitado
            if (modelo.PlanContaNome.Trim().Length == 0)
            {
                throw new Exception("O nome do plano de contas é obrigatório!");
            }
            //Comando coloca o nome sempre em maiúsculo
            modelo.PlanContaNome = modelo.PlanContaNome.ToUpper();

            DALPlanoContas DALobj = new DALPlanoContas(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALPlanoContas DALobj = new DALPlanoContas(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALPlanoContas DALobj = new DALPlanoContas(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloPlanoContas CarregaModeloPlanoContas(int codigo)
        {
            DALPlanoContas DALobj = new DALPlanoContas(conexao);
            return DALobj.CarregaModeloPlanoContas(codigo);
        }
    }
}
