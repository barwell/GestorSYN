/*
 *WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 04/01/2016
 *Data da Ultima Revisão: 
 *
 * Descrição: Classe utilizada para preencher a tabela
 * de contatos do banco de dados.
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
    public class ModeloContato
    {
         //Construtor de variáveis
        public ModeloContato()
        {
            this.ContatoCod = 0;
            this.ContatoData = "";
            this.ContatoNome = "";
            this.ContatoEmail = "";
            this.ContatoTelefone = "";
            this.ContatoCel1 = "";
            this.ContatoCel2 = "";
            this.ContatoCel1Oper = 0;
            this.ContatoCel2Oper = 0;
            this.ContatoCep = "";
            this.ContatoEndereco = "";
            this.ContatoForCod = 0;
            this.ContatoCliCod = 0;
            this.ContatoCityCod = 0;
            this.ContatoEstadoCod = 0;
            this.ContatoPaisCod = 0;
            this.ContatoStatus = "";
            this.ContatoTime = "";
        }

        public ModeloContato(int contatocod, string contatonome, string contatodata, string contatoemail, string contatotelefone, string contatocel1, string contatocel2,
            int contatocel1oper, int contatocel2oper, string contatoendereco, int contatoforcod, int contatoclicod, int contatocitycod, int contatoestadocod, 
            int contatopaiscod, string contatocep, string contatotime, string contatostatus)
        {
            this.ContatoCod = contatocod;
            this.ContatoData = contatodata;
            this.ContatoNome = contatonome;
            this.ContatoEmail = contatoemail;
            this.ContatoTelefone = contatotelefone;
            this.ContatoCel1 = contatocel1;
            this.ContatoCel2 = contatocel2;
            this.ContatoCel1Oper = contatocel1oper;
            this.ContatoCel2Oper = contatocel2oper;
            this.ContatoCep = contatocep;
            this.ContatoEndereco = contatoendereco;
            this.ContatoForCod = contatoforcod;
            this.ContatoCliCod = contatoclicod;
            this.ContatoCityCod = contatocitycod;
            this.ContatoEstadoCod = contatoestadocod;
            this.ContatoPaisCod = contatopaiscod;
            this.ContatoStatus = contatostatus;
            this.ContatoTime = contatotime;
        }

        //*******************************
        //Variáveis
        private int contato_cod;
        public int ContatoCod
        {
            get { return this.contato_cod; }
            set { this.contato_cod = value; }
        }
        private String contato_nome;
        public String ContatoNome
        {
            get { return this.contato_nome; }
            set { this.contato_nome = value; }
        }
        private string contato_email;
        public string ContatoEmail
        {
            get { return this.contato_email; }
            set { this.contato_email = value; }
        }
        private string contato_telefone;
        public string ContatoTelefone
        {
            get { return this.contato_telefone; }
            set { this.contato_telefone = value; }
        }
        private string contato_cel1;
        public string ContatoCel1
        {
            get { return this.contato_cel1; }
            set { this.contato_cel1 = value; }
        }
        private string contato_cel2;
        public string ContatoCel2
        {
            get { return this.contato_cel2; }
            set { this.contato_cel2 = value; }
        }
        private int contato_cel1oper;
        public int ContatoCel1Oper
        {
            get { return this.contato_cel1oper; }
            set { this.contato_cel1oper = value; }
        }
        private int contato_cel2oper;
        public int ContatoCel2Oper
        {
            get { return this.contato_cel2oper; }
            set { this.contato_cel2oper = value; }
        }
        private string contato_cep;
        public string ContatoCep
        {
            get { return this.contato_cep; }
            set { this.contato_cep = value; }
        }
        private string contato_endereco;
        public string ContatoEndereco
        {
            get { return this.contato_endereco; }
            set { this.contato_endereco = value; }
        }
        private int contato_forcod;
        public int ContatoForCod
        {
            get { return this.contato_forcod; }
            set { this.contato_forcod = value; }
        }
        private int contato_clicod;
        public int ContatoCliCod
        {
            get { return this.contato_clicod; }
            set { this.contato_clicod = value; }
        }
        private int contato_citycod;
        public int ContatoCityCod
        {
            get { return this.contato_citycod; }
            set { this.contato_citycod = value; }
        }
        private int contato_estadocod;
        public int ContatoEstadoCod
        {
            get { return this.contato_estadocod; }
            set { this.contato_estadocod = value; }
        }
        private int contato_paiscod;
        public int ContatoPaisCod
        {
            get { return this.contato_paiscod; }
            set { this.contato_paiscod = value; }
        }
        private String contato_data;
        public String ContatoData
        {
            get { return this.contato_data; }
            set { this.contato_data = value; }
        }
        
        private String contato_time;

        public String ContatoTime
        {
            get { return this.contato_time; }
            set { this.contato_time = value; }
        }
        private String contato_status;

        public string ContatoStatus
        {
            get { return this.contato_status; }
            set { this.contato_status = value; }
        }
        //****************************
    }
}
