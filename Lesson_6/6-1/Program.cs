using System;
using System.Diagnostics;

namespace lessons
{
    class program
    {

        static void Main(string[] args)
        {
            TaskManager();
            ProcessKill();
        }
        static void TaskManager()
        {
            Console.WriteLine(@"Вы запустили программу Task Manager. Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
        static void ProcessKill()
        {
            bool isWriteChoose = false;
            long processId;
            string processName = "";
            Console.WriteLine($"                PID|                          Name|                                                     Process info|");
            Console.WriteLine($"=====================================================================================================================");
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine($"{processes[i].Id,20}|{processes[i].ProcessName,30}|{processes[i],65}|");
            }
            do
            {
                Console.WriteLine("Введите имя или номер ID процесса который желаете завершить. Для выхода введите exit.");
                var numb = Console.ReadLine();
                if (numb == "exit")
                {
                    break;
                }
                if (long.TryParse(numb, out processId))
                {
                    processId = (long)(long.Parse(numb));
                    for (int i = 0; i < processes.Length; i++)
                    {
                        if (processes[i].Id == processId)
                        {
                            processes[i].Kill();
                            isWriteChoose = true;
                        }
                    }
                }
                else if (numb.GetType() == processName.GetType())
                {
                    processName = numb;
                    for (int i = 0; i < processes.Length; i++)
                    {
                        if (processes[i].ProcessName == processName)
                        {
                            processes[i].Kill();
                            isWriteChoose = true;
                        }
                    }
                }
                else
                {
                    isWriteChoose = false;
                }
            }
            while (!isWriteChoose);
        }
    }
}
