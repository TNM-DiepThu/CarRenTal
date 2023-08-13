using CarRenTal.View.MainView;
using CarRenTal.View.ViewLogin;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarRenTal
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
            //       Application.Run(new View._1.ChoThueXe.ChoThueXeForm(new Dal.Modal.NhanVien() { Id = Guid.Parse("BC8C0A62-8157-475F-BB06-598569ACE162") }));
            //   Application.Run(new View.QuanLyChoThueXe.QLCTXView());
              Application.Run(new View.ViewLogin.MainLoginForm() );
        //    Application.Run(new View.LoginTest.LoginAcc());
            //Application.Run(new View.ViewLogin.MainLoginForm());


        }
    }
}
