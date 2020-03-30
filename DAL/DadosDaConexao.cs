/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 24/11/2015
 *Data da Ultima Revisão: 24/11/2015
 *
 * Descrição: Classe utilizada para informar os dados de 
 * conexão ao banco de dados, retorna a string de conexão.
 *
 * Modificações da Revisão: Nenhuma
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
       /* public static String servidor = @"WELL";
        public static String banco = "gestorsyn";
        public static String usuario = "wseletrica";
        public static String senha = "123456";*/

        public static String servidor = "";
        public static String banco = "";
        public static String usuario = "";
        public static String senha = "";
        public static String pasta_backup = "";
        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
               // return "Data Source=WELL;Initial Catalog=gestorsyn;Integrated Security=True";
            }
        }
    }
}
