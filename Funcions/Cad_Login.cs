using PassManager.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassManager.Funcions
{
    class Cad_Login
    {

        public class CadastroUsuario
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            public String mensagem = "";

            public CadastroUsuario(String login, String senha)
            {
                cmd.CommandText = "insert into tb_logon (login, senha) values (@login, @senha)";

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    //Conecta com o banco -- CONEXÃO
                    cmd.Connection = conexao.conectar();
                    //Excutar comando SQL
                    cmd.ExecuteNonQuery();
                    //Desconectar
                    conexao.desconectar();

                    //Mostrar mensagem de erro ou sucesso --Variavel
                    this.mensagem = "Cadastro realizado!";
                }
                catch (Exception)
                {
                    this.mensagem = "Erro de conexão com banco";
                }

            }


        }
    }
}