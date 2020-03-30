/*
 *WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 03/01/2016
 *Data da Ultima Revisão:
 *
 * Descrição: Classe utilizada para preencher a tabela
 * de Cidades do banco de dados.
 *
 * Modificações da Revisão: Nenhuma
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCidade
    {
        //Construtor de variáveis
        public ModeloCidade()
        {
            this.CityCod = 0;
            this.CityData = "";
            this.CityNome = "";
            this.CityEstadoCod = 0;
            this.CityCodFed = 0;
            this.CityStatus = "";
            this.CityTime = "";
        }

        public ModeloCidade(int citycod, string citynome, int citycodfed, int cityestadocod, string citydata, string citytime, string citystatus)
        {
            this.CityCod = citycod;
            this.CityData = citydata;
            this.CityNome = citynome;
            this.CityCodFed = citycodfed;
            this.CityEstadoCod = cityestadocod;
            this.CityStatus = citystatus;
            this.CityTime = citytime;
        }

        //*******************************
        //Variáveis
        private int city_cod;
        public int CityCod
        {
            get { return this.city_cod; }
            set { this.city_cod = value; }
        }
        private String city_nome;
        public String CityNome
        {
            get { return this.city_nome; }
            set { this.city_nome = value; }
        }
        private int city_codfed;
        public int CityCodFed
        {
            get { return this.city_codfed; }
            set { this.city_codfed = value; }
        }
        private int city_estado_cod;
        public int CityEstadoCod
        {
            get { return this.city_estado_cod; }
            set { this.city_estado_cod = value; }
        }
        private String city_data;
        public String CityData
        {
            get { return this.city_data; }
            set { this.city_data = value; }
        }
        private String city_time;

        public String CityTime
        {
            get { return this.city_time; }
            set { this.city_time = value; }
        }
        private String city_status;

        public string CityStatus
        {
            get { return this.city_status; }
            set { this.city_status = value; }
        }
        //****************************

    }
}
