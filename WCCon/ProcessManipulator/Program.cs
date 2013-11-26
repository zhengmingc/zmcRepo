using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
           //ListAllRunningProcess();
            Console.WriteLine("PID: ");
           // string pID = Console.ReadLine();
          //  int theProcId = int.Parse(pID);

           // EnumThreadsForPid(theProcId);
           // EnumModsForPid(theProcId);
            StartAndKillProcess();
            Console.ReadLine();
        }

        private static void StartAndKillProcess()
        {
            Process ieProc = null;

            try
            {
                //ieProc = Process.Start("IExplore.exe", "www.facebook.com");
                ProcessStartInfo startInfo = 
                    new ProcessStartInfo("IExplore.exe","www.facebook.com");
                startInfo.WindowStyle = ProcessWindowStyle.Normal;

                ieProc = Process.Start(startInfo);
            }
            catch (InvalidOperationException Exception)
            {
                
                Console.WriteLine(Exception.Message);
            }

            Console.ReadLine();


            try
            {
                ieProc.Kill();
            }
            catch (InvalidOperationException Exception)
            {

                Console.WriteLine(Exception.Message);
            }
        }

        private static void EnumModsForPid(int theProcId)
        {
            Process currentProcess = null;
            try
            {
                currentProcess = Process.GetProcessById(theProcId);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Here are mods used by {0}", currentProcess.ProcessName);

            ProcessModuleCollection mods = currentProcess.Modules;

            foreach (ProcessModule mod in mods)
            {
                string info = string.Format("->Name :{0}", mod.ModuleName);
                Console.WriteLine(info);
            }
        }

        private static void EnumThreadsForPid(int theProcId)
        {
            Process currentProcess = null;
            try
            {
                currentProcess=Process.GetProcessById(theProcId);
            }
            catch (ArgumentException ex)
            {
               Console.WriteLine(ex.Message);
            }
           
            Console.WriteLine("Here are threads used by {0}", currentProcess.ProcessName);

            ProcessThreadCollection theThreads = currentProcess.Threads;

            foreach (ProcessThread theThread in theThreads)
            {
             string info = String.Format("-> Thread ID :{0}\t startTime :{1}\t priority :{2}",
                 theThread.Id, theThread.StartTime.ToShortTimeString(),theThread.PriorityLevel);   
            
                Console.WriteLine(info);
            
            }

        }

        private static void ListAllRunningProcess()
        {
            var processes = from proc in Process.GetProcesses(".")
                orderby proc.Id
                select proc;

            foreach (var process in processes)
            {
                string info = string.Format("->PID :{0}\tName: {1}", process.Id, process.ProcessName);
                Console.WriteLine(info);
            }

        }
    }
}
