using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassManager.DAL
{
    class LoginDaoComandos
    {
        public bool tem;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();

        public bool verificarlogin(String login, String senha)
        {
            //Comando SQL para verifiação se tem o login no banco
            /*
            cmd.CommandText = "select *";
            return tem;
      
            PAREI AQUI
    */
        }
       
        public String Cadastrar(String login, String senha, String confSenha)
        {
            return mensagem;
        }
    }
}
