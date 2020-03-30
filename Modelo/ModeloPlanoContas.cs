/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1.1
 *Data da Criação: 31/12/2015
 *Data da Ultima Revisão: nunca
 *
 * Descrição: Classe utilizada para preencher a tabela
 * de Plano de Contas do banco de dados.
 *
 * Modificações da Revisão: 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPlanoContas
    {
          //Construtor de Variáveis
        public ModeloPlanoContas()
        {
            this.PlanContaCod = 0;
            this.PlanContaData = "";
            this.PlanContaNome = "";
            this.PlanContaStatus = "";
            this.PlanContaTime = "";
        }
        
        public ModeloPlanoContas(int planconta_cod, string planconta_nome, string planconta_data, string planconta_time, string planconta_status)
        {
            this.PlanContaCod = planconta_cod;
            this.PlanContaData = planconta_data;
            this.PlanContaNome = planconta_nome;
            this.PlanContaStatus = planconta_status;
            this.PlanContaTime = planconta_time;
        }

        //********************************
        //Chamadas das Variáveis
        private int planconta_cod;
        public int PlanContaCod
        {
            get { return this.planconta_cod; }
            set { this.planconta_cod = value; }
        }
        private String planconta_nome;
        public String PlanContaNome
        {
            get { return this.planconta_nome; }
            set { this.planconta_nome = value; }
        }
        private String planconta_data;
        public String PlanContaData
        {
            get { return this.planconta_data; }
            set { this.planconta_data = value; }
        }
        private String planconta_time;

        public String PlanContaTime
        {
            get{return this.planconta_time;}
            set{this.planconta_time = value;}
        }
        private String planconta_status;

        public string PlanContaStatus
        {
            get{return this.planconta_status;}
            set{this.planconta_status = value;}
        }
        //**********************************

    }
}
