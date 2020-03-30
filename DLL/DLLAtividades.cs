/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 28/12/2015
 *Data da Ultima Revisão: nunca
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
    public class DLLAtividades
    {
        private DALConexao conexao;

        public DLLAtividades(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloAtividades modelo)
        {
            //verificando se o nome da Atividades foi digitado
            if (modelo.AtivNome.Trim().Length == 0)
            {
                throw new Exception("O nome da atividade é obrigatório!");
            }
            //Comando coloca o nome sempre em maiúsculo
            modelo.AtivNome = modelo.AtivNome.ToUpper();

            DALAtividades DALobj = new DALAtividades(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloAtividades modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.AtivCod <= 0)
            {
                throw new Exception("O código da atividade é obrigatório para alterar o registro!");
            }
            //verificando se o nome da atividade foi digitado
            if (modelo.AtivNome.Trim().Length == 0)
            {
                throw new Exception("O nome da atividade é obrigatório!");
            }
            //Comando coloca o nome sempre em maiúsculo
            modelo.AtivNome = modelo.AtivNome.ToUpper();

            DALAtividades DALobj = new DALAtividades(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALAtividades DALobj = new DALAtividades(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALAtividades DALobj = new DALAtividades(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloAtividades CarregaModeloAtividades(int codigo)
        {
            DALAtividades DALobj = new DALAtividades(conexao);
            return DALobj.CarregaModeloAtividades(codigo);
        }
    }
}
