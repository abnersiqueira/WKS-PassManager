using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager.ReceiveData
{
    class Dados_Empresa
    {
        public Dados_Empresa()
        {

            //-------Atribuindo um valor vazio a VAR
            this.id = 0;
            this.dominio = "";
            this.nomesrv = "";
            this.nomesrv2 = "";
            this.teamviewer = "";
            this.teamviewer2 = "";
            this.ipsrv = 0;
            this.ipsrv2 = 0;
            this.usuariosrv = "";
            this.usuariosrv2 = "";
            this.senhasrv = "";
            this.senhasrv2 = "";
            this.ipfirewall = "";
            this.portafirewall = 0;
            this.usuariofirewall = "";
            this.senhafirewall = "";
            this.nome_empresa = "";
            this.nome_resp = "";
            this.emp_email = "";
            this.emp_tel = "";
            this.emp_tel2 = "";
            this.emp_cel = "";
            this.emp_cel2 = "";


        }
        public Dados_Empresa(int id, String dominio, String nomesrv, String nomesrv2, String teamviewer, String teamviewer2,
            int ipsrv, int ipsrv2, String usuariosrv, String usuariosrv2, String senhasrv, String senhasrv2, String ipfirewall,int portafirewall,
            String usuariofirewall, String senhafirewall, String nome_empresa, String nome_resp, String emp_email, String emp_tel, String emp_tel2,
            String emp_cel, String emp_cel2)
        {
            this.id = id;
            this.dominio = dominio;
            this.nomesrv = nomesrv;
            this.nomesrv2 = nomesrv2;
            this.teamviewer = teamviewer;
            this.teamviewer2 = teamviewer2;
            this.ipsrv = ipsrv;
            this.ipsrv2 = ipsrv2;
            this.usuariosrv = usuariosrv;
            this.usuariosrv2 = usuariosrv2;
            this.senhasrv = senhasrv;
            this.senhasrv2 = senhasrv2;
            this.ipfirewall = ipfirewall;
            this.portafirewall = portafirewall;
            this.usuariofirewall = usuariofirewall;
            this.senhafirewall = senhafirewall;
            this.nome_empresa = nome_empresa;
            this.nome_resp = nome_resp;
            this.emp_email = emp_email;
            this.emp_tel = emp_tel;
            this.emp_tel2 = emp_tel2;
            this.emp_cel = emp_cel;
            this.emp_cel2 = emp_cel2;

        }
        int id_Empresa;
        String dominio_Empresa;
        String nomesrv_Empresa;
        String nomesrv2_Empresa;
        String teamviewer_Empresa;
        String teamviewer2_Empresa;
        int ipsrv_Empresa;
        int ipsrv2_Empresa;
        String usuariosrv_Empresa;
        String usuariosrv2_Empresa;
        String senhasrv_Empresa;
        String senhasrv2_Empresa;
        String ipfirewall_Empresa;
        int portafirewall_Empresa;
        String usuariofirewall_Empresa;
        String senhafirewall_Empresa;
        String NOME_EMP;
        String EMP_RESP;
        String EMAIL_EMP;
        String EMP_TEL;
        String EMP_TEL2;
        String EMP_CEL;
        String EMP_CEL2;


        public int id { get {return id_Empresa; } set {this.id_Empresa = value; } }
        public String dominio { get { return dominio_Empresa; } set { this.dominio_Empresa = value; } }
        public String nomesrv { get { return nomesrv_Empresa; } set { this.nomesrv_Empresa = value; } }
        public String nomesrv2 { get { return nomesrv2_Empresa; } set { this.nomesrv2_Empresa = value; } }
        public String teamviewer { get { return teamviewer_Empresa; } set { this.teamviewer_Empresa = value; } }
        public String teamviewer2 { get { return teamviewer2_Empresa; } set { this.teamviewer2_Empresa = value; } }
        public int ipsrv { get { return ipsrv_Empresa; } set { this.ipsrv_Empresa = value; } }
        public int ipsrv2 { get { return ipsrv2_Empresa; } set { this.ipsrv2_Empresa = value; } }
        public String usuariosrv { get { return usuariosrv_Empresa; } set { this.usuariosrv_Empresa = value; } }
        public String usuariosrv2 { get { return usuariosrv2_Empresa; } set { this.usuariosrv2_Empresa = value; } }
        public String senhasrv { get { return senhasrv_Empresa; } set { this.senhasrv_Empresa = value; } }
        public String senhasrv2 { get { return senhasrv2_Empresa; } set { this.senhasrv2_Empresa = value; } }
        public String ipfirewall { get { return ipfirewall_Empresa; } set { this.ipfirewall_Empresa = value; } }
        public int portafirewall { get { return portafirewall_Empresa; } set { this.portafirewall_Empresa = value; } }
        public String usuariofirewall { get { return usuariofirewall_Empresa; } set { this.usuariofirewall_Empresa = value; } }
        public String senhafirewall { get { return senhafirewall_Empresa; } set { this.senhafirewall_Empresa = value; } }
        public String nome_empresa { get { return NOME_EMP; } set { this.NOME_EMP = value; } }
        public String nome_resp { get { return EMP_RESP; } set { this.EMP_RESP = value; } }
        public String emp_email { get { return EMAIL_EMP; } set { this.EMAIL_EMP = value; } }
        public String emp_tel { get { return EMP_TEL; } set { this.EMP_TEL = value; } }
        public String emp_tel2 { get { return EMP_TEL2; } set { this.EMP_TEL2 = value; } }
        public String emp_cel { get { return EMP_CEL; } set { this.EMP_CEL = value; } }
        public String emp_cel2 { get { return EMP_CEL2; } set { this.EMP_CEL2 = value; } }
    }


}
