using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzON.Negocio.Modelo;

namespace PizzON.Negocio
{
    public static class MetodosExtension
    {
        public static bool ValidarUsuario(this Usuarios usuario)
        {
            String user = usuario.usuario;
            String pasw = usuario.contrasena;
            if (user.Length < 4)
                return false;
            if (pasw.Length < 8)
                return false;
            if (!Char.IsLetter(pasw[0]))
                return false;
            if (pasw.StartsWith("asd") || pasw.StartsWith("123"))
                return false;
            for (int i = 0; i < user.Length; i++)
            {
                if (!Char.IsLetterOrDigit(user[i]))
                    return false;
            }
            //boleanas de verificacion de contraseña
            bool min, mayus, nr, caracter;
            //Iniciamos a falso todas
            min = mayus = nr = caracter = false;
            for (int i = 0; i < pasw.Length; i++)
            {
                if (Char.IsLetterOrDigit(pasw[i]))
                {
                    if (Char.IsLetter(pasw[i]))
                    {
                        if (Char.IsUpper(pasw[i]))
                            mayus = true;
                        else
                            min = true;
                    }
                    else
                        nr = true;

                }
                else
                    caracter = true;
               
            }
            return min && mayus && nr && caracter;

        }

    }
}
