using prySistemaDePrestamosDeLibro.Clases;
using prySistemaDePrestamosDeLibro.Formularios;

namespace prySistemaDePrestamosDeLibro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLectores());
            //cuando terminen de editar dejen el formulario FrmInicioSesion como new FrmInicioSesion()
        }
    }
}