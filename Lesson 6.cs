using System;
using System.Collections;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;

namespace Work
{
    class Program
    {

        static void Main(string[] args)
        {

            Process[] processes = Process.GetProcesses();

            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine(processes[i].ProcessName);

            }

            Console.WriteLine("Для того, что бы завершить процесс по имени файла нажмите 1, что бы завершить процесс по ID нажмите 2");

            int n = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (n == 1)
                {
                    Console.WriteLine("Введите имя процесса который хотите закрыть");

                    string name = Console.ReadLine();

                    Process[] LocalName = Process.GetProcessesByName(name);

                    foreach (Process Name in LocalName)
                    {
                        Name.Kill();
                    }
                }
                else if (n == 2)
                {
                    Console.WriteLine("Введите имя процесса который хотите закрыть");

                    int ID = Convert.ToInt32(Console.ReadLine());

                    Process LocalID = Process.GetProcessById(ID);

                    LocalID.Kill();

                }
            }
            catch
            {
                Console.WriteLine("Неверно введено название процесса или ID");
            }



        }




    }

}
