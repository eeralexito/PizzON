using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzON.Negocio.API;

namespace PizzON.Shared.Validators
{
    public static class Validators
    {
        public static Control RequieredValidator(this Control ctrl, ErrorProvider errProvider, string mensajeError = null, Control controlDestinoMensaje = null)
        {
            ctrl.Validating += (c, e) =>
            {
                if (controlDestinoMensaje == null)
                {
                    controlDestinoMensaje = (Control)c;
                }

                if (String.IsNullOrEmpty(mensajeError))
                {
                    mensajeError = "Campo obligatorio!";
                }

                var t = c as Control;

                if (t.Text.Length <= 0 || t.Text == null)
                {
                    errProvider.SetError(controlDestinoMensaje, mensajeError);
                    //e.Cancel = true;
                }
                else
                {
                    if (errProvider.GetError(controlDestinoMensaje) == mensajeError)
                    {
                        errProvider.SetError(controlDestinoMensaje, string.Empty);
                    }
                }
            };
            return ctrl;

        }

        public static Control NewUserValidator(this Control ctrl,ErrorProvider errProvider, string mensajeError = null, Control controlDestinoMensaje = null)
        {
            ctrl.Validating += (c, e) =>
            {
                if (controlDestinoMensaje == null)
                {
                    controlDestinoMensaje = (Control)c;
                }

                if (String.IsNullOrEmpty(mensajeError))
                {
                    mensajeError = "Usuario existe ya!";
                }
                var t = c as Control;


            };
            return ctrl;
        }
    }
}
