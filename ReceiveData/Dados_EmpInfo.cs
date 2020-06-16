using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager.ReceiveData
{
    class Dados_EmpInfo
    {
            public Dados_EmpInfo()
            {
            //Atribuindo valores vazios

     
                this.PK_IDinfo = 0;
                this.nome_empresa = "";
                this.nome_resp = "";
                this.emp_email = "";
                this.emp_tel = "";
                this.emp_tel2 = "";
                this.emp_cel = "";
                this.emp_cel2 = "";
            
            }

            public Dados_EmpInfo (int PK_IDinfo, String nome_empresa, String nome_resp, String emp_email, String emp_tel, String emp_tel2,
                String emp_cel, String emp_cel2)
            {
               
                this.PK_IDinfo = PK_IDinfo;
                this.nome_empresa = nome_empresa;
                this.nome_resp = nome_resp;
                this.emp_email = emp_email;
                this.emp_tel = emp_tel;
                this.emp_tel2 = emp_tel2;
                this.emp_cel = emp_cel;
                this.emp_cel2 = emp_cel2;

            }

        int ID_EMP;
        String NOME_EMP;
        String EMP_RESP;
        String EMAIL_EMP;
        String EMP_TEL;
        String EMP_TEL2;
        String EMP_CEL;
        String EMP_CEL2;


        public int PK_IDinfo { get { return ID_EMP; } set { this.ID_EMP = value; } }
        public String nome_empresa { get { return NOME_EMP; } set { this.NOME_EMP = value; } }
        public String nome_resp { get { return EMP_RESP; } set { this.EMP_RESP = value; } }
        public String emp_email { get { return EMAIL_EMP; } set { this.EMAIL_EMP = value; } }
        public String emp_tel { get { return EMP_TEL; } set { this.EMP_TEL = value; } }
        public String emp_tel2 { get { return EMP_TEL2; } set { this.EMP_TEL2 = value; } }
        public String emp_cel { get { return EMP_CEL; } set { this.EMP_CEL = value; } }
        public String emp_cel2 { get { return EMP_CEL2; } set { this.EMP_CEL2 = value; } }
    }
}
