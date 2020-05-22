using PassManager.DAL;
using PassManager.ReceiveData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassManager.Funcions
{

    class Crud_Empresa       
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public int id;
        public void Cad_Empresa(String dominio, String nomesrv, String nomesrv2, String teamviewer, String teamviewer2,
            int ipsrv, int ipsrv2, String usuariosrv, String usuariosrv2, String senhasrv, String senhasrv2, bool checkfirewall, int portafirewall,
            String usuariofirewall, String senhafirewall)
        {
            cmd.CommandText = "insert into tb_LojaCliente (dominio,nomesrv,nomesrv2,teamviewer,teamviewer2,ipsrv,ipsvr2,usuariosrv,usuariosrv2,senhasrv," +
                "senhasrv2,checkfirewall,portafirewall,usuariofirewall,senhafirewall) values (@dominio, @nomesrv, @nomesrv2, @teamviewer,@teamviewer2,"+
                "@ipsrv,@ipsrv2,@usuariosrv,@usuariosrv2,@senhasrv,@senhasrv2,@checkfirewall,@portafirewall,@usuariofirewall,@senhafirewall);" +
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
            cmd.Parameters.AddWithValue("@checkfirewall", checkfirewall);
            cmd.Parameters.AddWithValue("@portafirewall", portafirewall);
            cmd.Parameters.AddWithValue("@usuariofirewall", usuariofirewall);
            cmd.Parameters.AddWithValue("@senhafirewall", senhafirewall);

            cmd.Connection = con.conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();
        }


        public Dados_Empresa Carregar (int IdLoja)
        {
            id = IdLoja;
            Dados_Empresa dados = new Dados_Empresa();
            cmd.Connection = con.conectar();
            cmd.CommandText = "Select * from tb_LojaCliente where id_LojaCliente =" + IdLoja.ToString();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            { 
                rd.Read();
                dados.id = Convert.ToInt32(rd["id_LojaCliente"]);
                dados.dominio = Convert.ToString(rd["dominio"]);
                dados.nomesrv = Convert.ToString(rd["nomesrv"]);
                dados.nomesrv2 = Convert.ToString(rd["nomesrv2"]);
                dados.teamviewer = Convert.ToString(rd["teamviewer"]);
                dados.teamviewer2 = Convert.ToString(rd["teamviewer2"]);
                dados.ipsrv = Convert.ToInt32(rd["ipsrv"]);
                dados.ipsrv2 = Convert.ToInt32(rd["ipsrv2"]);
                dados.usuariosrv = Convert.ToString(rd["usuariosrv"]);
                dados.usuariosrv2 = Convert.ToString(rd["usuariosrv2"]);
                dados.senhasrv = Convert.ToString(rd["senhasrv"]);
                dados.senhasrv2 = Convert.ToString(rd["senhasrv2"]);
                dados.checkfirewall = Convert.ToBoolean(rd["checkfirewall"]);
                dados.portafirewall = Convert.ToInt32(rd["portafirewall"]);
                dados.usuariofirewall = Convert.ToString(rd["usuariofirewall"]);
                dados.senhafirewall = Convert.ToString(rd["senhafirewall"]);
                
            }
            con.desconectar();
            return dados;
        }
    }
}
