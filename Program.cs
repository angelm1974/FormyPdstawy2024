using System.ComponentModel;

namespace FormyPdstawy
{
    internal static class Program
    {
        public static BindingList<Kolarz> listaKolarzy = new BindingList<Kolarz>();  
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        static void Zaladujdane()
        {

        }
    }
}