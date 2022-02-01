using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Sin_Dolor.Formas;

namespace Sin_Dolor
{
    static class Program
    {
        public static String PacienteNombre;
        public static String PacienteNombreCompleto;
        public static String PacienteApellidoP;
        public static String PacienteApellidoM;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            //builder.Server = "localhost";
            //builder.Database = "bd_sin_dolor";
            //builder.UserID = "root";
            //builder.Password = "";
            //builder.ApplicationName = "app";
            //builder.Port = 3306;
            //Console.WriteLine(builder.ConnectionString);

            Application.Run(new Inicio());
        }
    }
}
