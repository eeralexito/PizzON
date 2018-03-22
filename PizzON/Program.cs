using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using PizzON.Ninject;

namespace PizzON
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = NinjectKernel.Get<formLogIn>();
            //form.FormClosed += MainForm_Closed;
            //form.Show();
           Application.Run(form);

        }
        public static StandardKernel NinjectKernel = new StandardKernel(new DIModule());


        //private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        //{
        //    ((Form)sender).FormClosed -= MainForm_Closed;

        //    if (Application.OpenForms.Count == 0)
        //    {
        //        Application.ExitThread();
        //    }
        //    else
        //    {
        //        Application.OpenForms[0].FormClosed += MainForm_Closed;
        //    }
        //}
    }
}
