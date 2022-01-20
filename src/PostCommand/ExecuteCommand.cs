using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;



namespace PostCommand
{
    public static class ExecuteCommand 
    {
        public static string BaseProgram { get; } = "/bin/bash";
        public static string ExecCmdOption { get; } = "-c";




        public static void CaptureCommandOutput(string command)
        {
            var proc = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = BaseProgram,
                    Arguments = $"{ExecCmdOption} \"{command}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();



        }
    }
}
