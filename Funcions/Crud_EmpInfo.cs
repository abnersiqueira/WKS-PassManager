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
    class Crud_EmpInfo
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public int id;
        public void Cad_EmpInfo(String nome_empresa, String nome_resp, String emp_email, String emp_tel, String emp_tel2,
            String emp_cel, String emp_cel2)
        {
            cmd.CommandText = "insert into tb_InfoEmp (nome_empresa, nome_resp, emp_email, emp_tel, emp_tel2, emp_cel, emp_cel2) values " +
                "(@nome_empresa, @nome_resp, @emp_email, @emp_tel, @emp_tel2, @emp_cel, emp_cel2);"+
                "Select @@identity";

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

        }

        public Dados_EmpInfo Carregar (int idLoja)
        {
            id = idLoja;
            Dados_EmpInfo DadosInfo = new Dados_EmpInfo();
            cmd.Connection = con.conectar();
            cmd.CommandText = "Select * from tb_EmpInfo where PK_IDinfo =" + idLoja.ToString();
            SqlDataReader rd = cmd.ExecuteReader();

            if(rd.HasRows)
            {
                rd.Read();
                DadosInfo.PK_IDinfo = Convert.ToInt32(rd["PK_IDinfo"]);
                DadosInfo.nome_empresa = Convert.ToString(rd["nome_empresa"]);
                DadosInfo.nome_resp = Convert.ToString(rd["nome_resp"]);
                DadosInfo.emp_email = Convert.ToString(rd["emp_email"]);
                DadosInfo.emp_tel = Convert.ToString(rd["emp_tel"]);
                DadosInfo.emp_tel2 = Convert.ToString(rd["emp_tel2"]);
                DadosInfo.emp_cel = Convert.ToString(rd["emp_cel"]);
                DadosInfo.emp_cel2 = Convert.ToString(rd["emp_cel2"]);

            }
            con.desconectar();
            return DadosInfo;
        }
    }
}
