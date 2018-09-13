using System;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Acessando a Web API, Aguarde um momento...");

            var repositorio = new UsuarioRepositorio();

            var usuariosTask = repositorio.GetUsuariosAsync();

            usuariosTask.ContinueWith(task =>
            {
                var usuarios = task.Result;
                foreach(var u in usuarios)
                    WriteLine(u.ToString());

                Environment.Exit(0);
            },
            TaskContinuationOptions.OnlyOnRanToCompletion
            );

            ReadLine();
        }
    }
}
