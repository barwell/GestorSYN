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
 * de estados do banco de dados.
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
    public class ModeloEstado
    {

        //Construtor de variáveis
        public ModeloEstado()
        {
            this.EstadoCod = 0;
            this.EstadoData = "";
            this.EstadoNome = "";
            this.EstadoCodFed = 0;
            this.EstadoPaisCod = 0;
            this.EstadoStatus = "";
            this.EstadoTime = "";
        }

        public ModeloEstado(int estadocod, string estadonome, string estadodata, int estadopaiscod, int estadocodfed, string estadotime, string estadostatus)
        {
            this.EstadoCod = estadocod;
            this.EstadoData = estadodata;
            this.EstadoNome = estadonome;
            this.EstadoPaisCod = estadopaiscod;
            this.EstadoCodFed = estadocodfed;
            this.EstadoStatus = estadostatus;
            this.EstadoTime = estadotime;
        }

        //*******************************
        //Variáveis
        private int estado_cod;
        public int EstadoCod
        {
            get { return this.estado_cod; }
            set { this.estado_cod = value; }
        }
        private String estado_nome;
        public String EstadoNome
        {
            get { return this.estado_nome; }
            set { this.estado_nome = value; }
        }
        private int estado_codfed;
        public int EstadoCodFed
        {
            get { return this.estado_codfed; }
            set { this.estado_codfed = value; }
        }
        private String estado_data;
        public String EstadoData
        {
            get { return this.estado_data; }
            set { this.estado_data = value; }
        }
        private int estado_pais_cod;
        public int EstadoPaisCod
        {
            get { return this.estado_pais_cod; }
            set { this.estado_pais_cod = value; }
        }
        private String estado_time;

        public String EstadoTime
        {
            get { return this.estado_time; }
            set { this.estado_time = value; }
        }
        private String estado_status;

        public string EstadoStatus
        {
            get { return this.estado_status; }
            set { this.estado_status = value; }
        }
        //****************************


    }
}
