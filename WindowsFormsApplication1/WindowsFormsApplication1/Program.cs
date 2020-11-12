using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //[STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Console.WriteLine("Executar el proceso de python 1");
            //Exec_Procesos();


        }

        //static void Exec_Procesos()
        //{
        //1) crear informacion del proceso
        //var psi = new ProcessStartInfo();
        //psi.FileName = @"C:\Users\sebastian\AppData\Local\Programs\Python\Python37\Python.exe";

        //2) entregar el script py y argumentos
        //var script = @"C:\Users\sebastian\Desktop\string.py";

        //psi.Arguments = $"\"{script}\"";

        //3) Configuracion de procesos
        //psi.UseShellExecute = false;
        //psi.CreateNoWindow = true;
        //psi.RedirectStandardOutput = true;
        //psi.RedirectStandardError = true;

        //4)Executar proceso y obtener parametros de salida
        //var errors = "";
        //var results = "";

        //    using (var process = Process.Start(psi))
        //    {
        //errors = process.StandardError.ReadToEnd();
        //results = process.StandardOutput.ReadToEnd();

        //}

        //5) Lanzar las salidas
        //Console.WriteLine("ERRORS:");
        //    Console.WriteLine(errors);
        //    Console.WriteLine();
        //    Console.WriteLine("RESULTS:");
            //Console.WriteLine(results);


        //}

    }
}
