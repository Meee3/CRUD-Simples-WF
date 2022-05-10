using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAula33_PreProva.domain;

namespace WFAula33_PreProva
{
    internal static class Program
    {
        public static List<Pessoa> cadastrarPessoas = new List<Pessoa>();
        public static List<Pessoa> listaRemovidos = new List<Pessoa>();

     
        //public static Object cadastrosLista = cadastrarPessoas;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
