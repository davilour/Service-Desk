using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Service_Desk
{
    class ClassUsuario
    {
        public int codigo;
        public string nome;
        public string cpf;
        public string telefone;
        public string endereco;
        public string senha;
        public bool logado;
        public string perfil;

        public void usuario()
        {
            this.codigo = 0;
            this.nome = "";
            this.cpf = "";
            this.telefone = "";
            this.endereco = "";
            this.perfil = "";
        }

        public void Editar()
        {

        }



        public string getMD5hash(string senha)
        {
            System.Security.Cryptography.MD5 mds = System.Security.Cryptography.MD5.Create();
            byte[] imputBytes = System.Text.Encoding.ASCII.GetBytes(senha);
            byte[] hash = mds.ComputeHash(imputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        
    }
}
