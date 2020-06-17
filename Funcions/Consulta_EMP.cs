using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PassManager.DAL;
using PassManager.ReceiveData;
using System.Windows.Forms;

namespace PassManager.Funcions
{
    class Consulta_EMP
    {

        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public int id;

        public void Consulta_EMPRESA(String dominio, String nomesrv, String nomesrv2, String teamviewer, String teamviewer2,
          int ipsrv, int ipsrv2, String usuariosrv, String usuariosrv2, String senhasrv, String senhasrv2, int portafirewall,
          String usuariofirewall, String senhafirewall, String ipfirewall, String nome_empresa, String nome_resp, String emp_email, String emp_tel, String emp_tel2)
        {
            cmd.CommandText = "select * from tb_DadosLoja (dominio,nomesrv,nomesrv2,teamviewer,teamviewer2,ipsrv,ipsrv2,usuariosrv,usuariosrv2,senhasrv," +
               "senhasrv2,checkfirewall,portafirewall,usuariofirewall,senhafirewall,ipfirewall,nome_empresa,nome_resp,emp_email,emp_tel,emptel2) values (@dominio, @nomesrv, @nomesrv2, @teamviewer,@teamviewer2," +
               "@ipsrv,@ipsrv2,@usuariosrv,@usuariosrv2,@senhasrv,@senhasrv2,@portafirewall,@usuariofirewall,@senhafirewall," +
               " @ipfirewall,@nome_empresa,@nome_resp,@emp_email,@emp_tel,@emp_tel2);" +
               "Select @@identity";

            cmd.Parameters.AddWithValue("@dominio", dominio);
            cmd.Parameters.AddWithValue("@nomesrv", nomesrv);
            cmd.Parameters.AddWithValue("@nomesrv2", nomesrv2);
            cmd.Parameters.AddWithValue("@teamviewer", teamviewer);
            cmd.Parameters.AddWithValue("@teamviewer2", teamviewer2);
            cmd.Parameters.AddWithValue("@ipsrv", ipsrv);
            cmd.Parameters.AddWithValue("@ipsrv2", ipsrv2);
            cmd.Parameters.AddWithValue("@usuariosrv", usuariosrv);
            cmd.Parameters.AddWithValue("@usuariosrv2", usuariosrv2);
            cmd.Parameters.AddWithValue("@senhasrv", senhasrv);
            cmd.Parameters.AddWithValue("@senhasrv2", senhasrv2);
            cmd.Parameters.AddWithValue("@portafirewall", portafirewall);
            cmd.Parameters.AddWithValue("@usuariofirewall", usuariofirewall);
            cmd.Parameters.AddWithValue("@senhafirewall", senhafirewall);
            cmd.Parameters.AddWithValue("@ipfirewall", ipfirewall);
            cmd.Parameters.AddWithValue("@nome_empresa", nome_empresa);
            cmd.Parameters.AddWithValue("@nome_resp", nome_resp);
            cmd.Parameters.AddWithValue("@emp_email", emp_email);
            cmd.Parameters.AddWithValue("@emp_tel", emp_tel);
            cmd.Parameters.AddWithValue("@emp_tel2", emp_tel2);


            cmd.Connection = con.conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();
            MessageBox.Show("Lista consulta DADOS EMPRESA Carregada!");

        }


    }
}

