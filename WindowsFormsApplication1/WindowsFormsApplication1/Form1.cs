using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string Exec_Procesos(string var1)
        {
            //1) crear informacion del proceso
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\sebastian\AppData\Local\Programs\Python\Python37\Python.exe";

            //2) entregar el script py y argumentos
            var script = @"C:\Users\sebastian\Desktop\string.py";
            var start = var1;

            psi.Arguments = $"\"{script}\" \"{start}\"";
             
            //3) Configuracion de procesos
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            //4)Executar proceso y obtener parametros de salida
            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();

            }

            //5) Lanzar las salidas
            Console.WriteLine("ERRORS:");
            Console.WriteLine(errors);
            Console.WriteLine();
            Console.WriteLine("RESULTS:");
            Console.WriteLine(results);

            return results;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);

            string resultado = Exec_Procesos(textBox1.Text);
            MessageBox.Show(resultado);
        }
    }
}
