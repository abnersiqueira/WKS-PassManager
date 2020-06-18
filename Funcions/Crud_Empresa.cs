using PassManager.DAL;
using PassManager.ReceiveData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager.Funcions
{

    class Crud_Empresa       
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public int id;

      
        public void Cad_Empresa(String dominio, String nomesrv, String nomesrv2, String teamviewer, String teamviewer2,
            String ipsrv, String ipsrv2, String usuariosrv, String usuariosrv2, String senhasrv, String senhasrv2, String ipfirewall, int portafirewall,
            String usuariofirewall, String senhafirewall, String nome_empresa, String nome_resp, String emp_email, String emp_tel, String emp_tel2,
            String emp_cel, String emp_cel2)
        {
            cmd.CommandText = "insert into tb_DadosLoja (dominio,nomesrv,nomesrv2,teamviewer,teamviewer2,ipsrv,ipsrv2,usuariosrv,usuariosrv2,senhasrv," +
                "senhasrv2,ipfirewall,portafirewall,usuariofirewall,senhafirewall,nome_empresa, nome_resp, emp_email, emp_tel, emp_tel2, emp_cel, emp_cel2) " +
                "values" +
                " (@dominio, @nomesrv, @nomesrv2, @teamviewer,@teamviewer2,"+
                "@ipsrv,@ipsrv2,@usuariosrv,@usuariosrv2,@senhasrv,@senhasrv2,@ipfirewall,@portafirewall,@usuariofirewall,@senhafirewall" +
                ",@nome_empresa, @nome_resp, @emp_email, @emp_tel, @emp_tel2, @emp_cel, @emp_cel2);" +
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
            cmd.Parameters.AddWithValue("@ipfirewall", ipfirewall);
            cmd.Parameters.AddWithValue("@portafirewall", portafirewall);
            cmd.Parameters.AddWithValue("@usuariofirewall", usuariofirewall);
            cmd.Parameters.AddWithValue("@senhafirewall", senhafirewall);
            cmd.Parameters.AddWithValue("@nome_empresa", nome_empresa);
            cmd.Parameters.AddWithValue("@nome_resp", nome_resp);
            cmd.Parameters.AddWithValue("@emp_email", emp_email);
            cmd.Parameters.AddWithValue("@emp_tel", emp_tel);
            cmd.Parameters.AddWithValue("@emp_tel2", emp_tel2);
            cmd.Parameters.AddWithValue("@emp_cel", emp_cel);
            cmd.Parameters.AddWithValue("@emp_cel2", emp_cel2);

            cmd.Connection = con.conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();
            MessageBox.Show ("Cadastro efetuado!");
        }


        public Dados_Empresa Carregar (int IdLoja)
        {
            id = IdLoja;
            Dados_Empresa dados = new Dados_Empresa();
            cmd.Connection = con.conectar();
            cmd.CommandText = "Select * from tb_DadosLoja where id_DadosLoja =" + IdLoja.ToString();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            { 
                rd.Read();
                dados.id = Convert.ToInt32(rd["id_DadosLoja"]);
                dados.dominio = Convert.ToString(rd["dominio"]);
                dados.nomesrv = Convert.ToString(rd["nomesrv"]);
                dados.nomesrv2 = Convert.ToString(rd["nomesrv2"]);
                dados.teamviewer = Convert.ToString(rd["teamviewer"]);
                dados.teamviewer2 = Convert.ToString(rd["teamviewer2"]);
                dados.ipsrv = Convert.ToString(rd["ipsrv"]);
                dados.ipsrv2 = Convert.ToString(rd["ipsrv2"]);
                dados.usuariosrv = Convert.ToString(rd["usuariosrv"]);
                dados.usuariosrv2 = Convert.ToString(rd["usuariosrv2"]);
                dados.senhasrv = Convert.ToString(rd["senhasrv"]);
                dados.senhasrv2 = Convert.ToString(rd["senhasrv2"]);
                dados.ipfirewall = Convert.ToString(rd["ipfirewall"]);
                dados.portafirewall = Convert.ToInt32(rd["portafirewall"]);
                dados.usuariofirewall = Convert.ToString(rd["usuariofirewall"]);
                dados.senhafirewall = Convert.ToString(rd["senhafirewall"]);
                dados.nome_empresa = Convert.ToString(rd["nome_empresa"]);
                dados.nome_resp = Convert.ToString(rd["nome_resp"]);
                dados.emp_email = Convert.ToString(rd["emp_email"]);
                dados.emp_tel = Convert.ToString(rd["emp_tel"]);
                dados.emp_tel2 = Convert.ToString(rd["emp_tel2"]);
                dados.emp_cel = Convert.ToString(rd["emp_cel"]);
                dados.emp_cel2 = Convert.ToString(rd["emp_cel2"]);

            }
            con.desconectar();
            return dados;
        }
    }
}
