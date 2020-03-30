/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1.0
 *Data da Criação: 21/12/2015
 *Data da Ultima Revisão: nunca
 *
 * Descrição: Classe utilizada para preencher a tabela
 * de ferramentas do banco de dados.
 *
 * Modificações da Revisão: Inserção de construtor de variáveis
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFerramentas
    {
        //Construtor de Variáveis
        public ModeloFerramentas()
        {
            this.FerrCod = 0;
            this.FerrData = "";
            this.FerrNome = "";
            this.FerrValor = 0;
            this.FerrStatus = "";
            this.FerrTime = "";
        }
        
        public ModeloFerramentas(int ferr_cod, string ferr_nome, double ferr_valor, string ferr_data, string ferr_time, string ferr_status)
        {
            this.FerrCod = ferr_cod;
            this.FerrData = ferr_data;
            this.FerrNome = ferr_nome;
            this.FerrValor = ferr_valor;
            this.FerrStatus = ferr_status;
            this.FerrTime = ferr_time;
        }

        //********************************
        //Chamadas das Variáveis
        private int ferr_cod;
        public int FerrCod
        {
            get { return this.ferr_cod; }
            set { this.ferr_cod = value; }
        }
        private String ferr_nome;
        public String FerrNome
        {
            get { return this.ferr_nome; }
            set { this.ferr_nome = value; }
        }
        private Double ferr_valor;
        public Double FerrValor
        {
            get { return this.ferr_valor; }
            set { this.ferr_valor = value; }
        }
        private String ferr_data;
        public String FerrData
        {
            get { return this.ferr_data; }
            set { this.ferr_data = value; }
        }
        private String ferr_time;

        public String FerrTime
        {
            get{return this.ferr_time;}
            set{this.ferr_time = value;}
        }
        private String ferr_status;

        public string FerrStatus
        {
            get{return this.ferr_status;}
            set{this.ferr_status = value;}
        }
        //**********************************


    }
}
