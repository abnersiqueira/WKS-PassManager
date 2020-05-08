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
        public bool tem = false;
        public String mensagem = ""; //tudo ok

        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

                
        //Comandos SQL para verificação no banco dos acessos
        public bool verificarlogin(String login, String senha)
        {
            cmd.CommandText = "select * from tb_logon where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //se foi encontrado
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }

            return tem;
        }



        //public String SalvaResp(String txbNomeEmpresa, String txbRespEmpresa,
        //    String txbEmailEmpresa, String txbTelefoneEmpresa,
        //    String txbTelefoneEmpresa2, String txbCelEmpresa, String txbCelEmpresa2)
        //{

        //}
        //{
        //    cmd.CommandText = "insert into tb_loja values (@nEmpresa @rEmpresa @eEmpresa @tEmpresa @eEmpresa2 @cEmpresa @cEmpresa2);";
        //    cmd.Parameters.AddWithValue("@nEmpresa", txbNomeEmpresa);
        //    cmd.Parameters.AddWithValue("@rEmpresa", txbRespEmpresa);
        //    cmd.Parameters.AddWithValue("@eEmpresa",txbEmailEmpresa);
        //    cmd.Parameters.AddWithValue("@tEmpresa",txbTelefoneEmpresa);
        //    cmd.Parameters.AddWithValue("@eEmpresa2",txbTelefoneEmpresa2);
        //    cmd.Parameters.AddWithValue("@cEmpresa",txbCelEmpresa);
        //    cmd.Parameters.AddWithValue("@cEmpresa2",txbCelEmpresa2);
        //}

        //Validação de cadastro em banco

        public String cadastrar(String login, String senha)
        {

            //FUNÇÃO RESPONSÁVEL PARA CADASTRO DE USUÁRIOS SISTEMA
            return mensagem;
        }
    }
}
