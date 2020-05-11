using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=wks.ct8ezavef84l.sa-east-1.rds.amazonaws.com;Initial Catalog=wks;User ID=admin;Password=$Rv#passmanager";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }


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

        public class CadastroResp
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            public String mensagem = "";

            //Fazer função CadastroResp
            public CadastroResp(String login, String senha)
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

            //Função Cadastro Loja






            //Cadastro Firewall

            //Altera Usuario do sistema
            //Altera CadastroResp
            //Altera Cadastro Loja
            //Altera Cadastro Firewall


            ///Exlui Usuario do sistema
            //public ExcluiUser(String login, String senha)
            //{
            //    cmd.CommandText = "delete where tb_logon (login, senha) values (@login, @senha)";

            //    cmd.Parameters.AddWithValue("@login", login);
            //    cmd.Parameters.AddWithValue("@senha", senha);

            //    try
            //    {
            //        //Conecta com o banco -- CONEXÃO
            //        cmd.Connection = conexao.conectar();
            //        //Excutar comando SQL
            //        cmd.ExecuteNonQuery();
            //        //Desconectar
            //        conexao.desconectar();

            //        //Mostrar mensagem de erro ou sucesso --Variavel
            //        this.mensagem = "Cadastro realizado!";
            //    }
            //    catch (Exception)
            //    {
            //        this.mensagem = "Erro de conexão com banco";
            //    }

            }

            ///Exlui CadastroResp
            ///Exlui Cadastro Loja
            //Exlui Cadastro Firewall



    }


}
