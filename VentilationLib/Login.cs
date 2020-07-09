using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text;

namespace VentilationLib
{
    public class Login
    {

        private string loginName { get; set; }
        public string LOGINNAME
        {
            get => loginName;
            set
            {
                loginName = value;
            }
        }

        public Login()
        {
            loginName = "";
        }
        public bool SignIn()
        {
            string path = @"C:\Users\48570\source\repos\PomiarWentylacjiProjektZaliczeniowy\login.txt";
            string[] readText = File.ReadAllLines(path);
            Console.WriteLine("Witaj, podaj swój login aby się zalogować do systemu");
            loginName = Console.ReadLine();
            bool loginResult = false;
            for (int i = 0; i < readText.Length; i++)
            {
                if (readText[i] == loginName)
                {
                    Console.WriteLine($"Logowanie powiodło się, miło Cię widzieć {loginName}");
                    loginResult = true;
                    break;
                }
                else
                {
                    loginResult = false;
                }
            }
            return loginResult;
        }
    }
}
