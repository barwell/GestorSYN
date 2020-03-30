/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 21/12/2015
 *Data da Ultima nunca
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
    public class DLLFerramentas
    {

        private DALConexao conexao;

        public DLLFerramentas(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFerramentas modelo)
        {
            //verificando se o nome da Ferramentas foi digitado
            if (modelo.FerrNome.Trim().Length == 0)
            {
                throw new Exception("O nome da ferramentas é obrigatório!");
            }
            //Comando coloca o nome sempre em maiúsculo
            modelo.FerrNome = modelo.FerrNome.ToUpper();

            DALFerramentas DALobj = new DALFerramentas(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloFerramentas modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.FerrCod <= 0)
            {
                throw new Exception("O código da ferramentas é obrigatório para alterar o registro!");
            }
            //verificando se o nome da Ferramentas foi digitado
            if (modelo.FerrNome.Trim().Length == 0)
            {
                throw new Exception("O nome da ferramentas é obrigatório!");
            }
            //Comando coloca o nome sempre em maiúsculo
            modelo.FerrNome = modelo.FerrNome.ToUpper();

            DALFerramentas DALobj = new DALFerramentas(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALFerramentas DALobj = new DALFerramentas(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALFerramentas DALobj = new DALFerramentas(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloFerramentas CarregaModeloFerramentas(int codigo)
        {
            DALFerramentas DALobj = new DALFerramentas(conexao);
            return DALobj.CarregaModeloFerramentas(codigo);
        }

    }
}
