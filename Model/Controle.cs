﻿using PassManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassManager.Model
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarlogin(login, senha);
            
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String login, String senha)
        {
            //FUNÇÃO PARA CADASTRO DE USER
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            this.mensagem = LoginDao.cadastrar(login, senha);
            
            return mensagem;
        }
    }
}
