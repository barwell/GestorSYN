/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 18/12/2015
 *Data da Ultima Revisão: 18/12/2015
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
    public class DLLPais
    {

        private DALConexao conexao;

        public DLLPais(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPais modelo)
        {
            //verificando se o nome da categoria foi digitado
            if (modelo.PaisNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }
            //Comando coloca o nome sempre em maiúsculo
            modelo.PaisNome = modelo.PaisNome.ToUpper();

            DALPais DALobj = new DALPais(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloPais modelo)
        {
            //Verifica se o código foi alterado
            if (modelo.PaisCod <= 0)
            {
                throw new Exception("O código do País é obrigatório para alterar o registro!");
            }
            //verificando se o nome do país foi digitado
            if (modelo.PaisNome.Trim().Length == 0)
            {
                throw new Exception("O nome do país é obrigatório!");
            }
            //Comando coloca o nome sempre em maiúsculo
            modelo.PaisNome = modelo.PaisNome.ToUpper();

            DALPais DALobj = new DALPais(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALPais DALobj = new DALPais(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALPais DALobj = new DALPais(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloPais CarregaModeloPais(int codigo)
        {
            DALPais DALobj = new DALPais(conexao);
            return DALobj.CarregaModeloPais(codigo);
        }

    }
}
