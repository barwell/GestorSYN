/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1.1
 *Data da Criação: 28/11/2015
 *Data da Ultima Revisão: nunca
 *
 * Descrição: Classe utilizada para preencher a tabela
 * de atividades do banco de dados.
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
    public class ModeloAtividades
    {

        //Construtor de Variáveis
        public ModeloAtividades()
        {
            this.AtivCod = 0;
            this.AtivData = "";
            this.AtivNome = "";
            this.AtivDias = 0;
            this.AtivHoras = 0;
            this.AtivMinutos = 0;
            this.AtivHorasDia = 0;
            this.AtivStatus = "";
            this.AtivTime = "";
        }
        
        public ModeloAtividades(int ativ_cod, string ativ_nome, int ativ_temp_dias, int ativ_temp_horas, int ativ_temp_minutos, int ativ_horas_dia, string ativ_data, string ativ_time, string ativ_status)
        {
            this.AtivCod = ativ_cod;
            this.AtivNome = ativ_nome;
            this.AtivDias = ativ_temp_dias;
            this.AtivHoras = ativ_temp_horas;
            this.AtivMinutos = ativ_temp_minutos;
            this.AtivHorasDia = ativ_horas_dia;
            this.AtivData = ativ_data;
            this.AtivTime = ativ_time;
            this.AtivStatus = ativ_status;
        }

        //********************************
        //Chamadas das Variáveis
        private int ativ_cod;
        public int AtivCod
        {
            get { return this.ativ_cod; }
            set { this.ativ_cod = value; }
        }
        private String ativ_nome;
        public String AtivNome
        {
            get { return this.ativ_nome; }
            set { this.ativ_nome = value; }
        }
        private int ativ_temp_dias;
        public int AtivDias
        {
            get { return this.ativ_temp_dias; }
            set { this.ativ_temp_dias = value; }
        }
        private int ativ_temp_horas;
        public int AtivHoras
        {
            get { return this.ativ_temp_horas; }
            set { this.ativ_temp_horas = value; }
        }
        private int ativ_temp_minutos;
        public int AtivMinutos
        {
            get { return this.ativ_temp_minutos; }
            set { this.ativ_temp_minutos = value; }
        }
        private int ativ_horas_dia;
        public int AtivHorasDia
        {
            get { return this.ativ_horas_dia; }
            set { this.ativ_horas_dia = value; }
        }
        private String ativ_data;
        public String AtivData
        {
            get { return this.ativ_data; }
            set { this.ativ_data = value; }
        }
        private String ativ_time;

        public String AtivTime
        {
            get{return this.ativ_time;}
            set{this.ativ_time = value;}
        }
        private String ativ_status;

        public string AtivStatus
        {
            get{return this.ativ_status;}
            set{this.ativ_status = value;}
        }
        //**********************************


    }
}
