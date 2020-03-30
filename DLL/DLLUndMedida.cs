/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 16/12/2015
 *Data da Ultima Revisão: 16/12/2015
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
    public class DLLUndMedida
    {

        private DALConexao conexao;

        public DLLUndMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUndMedida modelo)
        {
            //verificando se o nome da unidade de medida foi digitado
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Unidade é obrigatório!");
            }
            
            DALUndMedida DALobj = new DALUndMedida(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloUndMedida modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade é obrigatório!");
            }
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código da unidade é obrigatório!");
            }

            DALUndMedida DALobj = new DALUndMedida(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALUndMedida DALobj = new DALUndMedida(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALUndMedida DALobj = new DALUndMedida(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaUndMedida(string valor) //0 - não encontrado || valor > 0 - valor encontrado
        {
            DALUndMedida DALobj = new DALUndMedida(conexao);
            return DALobj.VerificaUndDeMedida(valor);
        }

        public ModeloUndMedida CarregaModeloUndMedida(int codigo)
        {
            DALUndMedida DALobj = new DALUndMedida(conexao);
            return DALobj.CarregaModeloUndMedida(codigo);
        }


    }
}
