using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //objeto usuário
    public class UsuarioModelo
    {
        //atritubos aplicados no bd
        public int idusuario;
        public string nome;
        public string senha;
        public int idperfil;
        //construtor da classe modelo usuario
        public UsuarioModelo()
        {
            nome = null;
            senha = null;
            idperfil = 0;
        }
    }
}