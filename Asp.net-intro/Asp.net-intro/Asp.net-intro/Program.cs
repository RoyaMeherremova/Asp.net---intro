namespace Asp.net_intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //menim proyektim MVC proyekt olacaq o mentiqde isleyeceq
            builder.Services.AddControllersWithViews();




            var app = builder.Build();
            //menim proyektim controller action rootuynan isleyecek
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
             //id?-null ola biler! 
            app.Run();

           //Build yazdiqimiz kodlari cevirir asemblere



          



        }
    }
}