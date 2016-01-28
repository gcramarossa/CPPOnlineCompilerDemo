/*
 * (c) 2016 Giuseppe Cramarossa
 * This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/.
 */

using System.Diagnostics;

namespace CPP_Online_Compiler_Monitor
{
    /// <summary>
    /// Layout class
    /// </summary>
    class Layout
    {
        /// <summary>
        /// Describes the process to start
        /// </summary>
        protected Process _executeProcess = new Process();

        /// <summary>
        /// Get or set the name of the file
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Contains all compiler errors
        /// </summary>
        protected string Output;

        /// <summary>
        /// Layout Constructor
        /// </summary>
        public Layout()
        {
            _executeProcess.StartInfo.UseShellExecute = false;
            _executeProcess.StartInfo.CreateNoWindow = true;
            _executeProcess.StartInfo.RedirectStandardInput = true;
            _executeProcess.StartInfo.RedirectStandardOutput = true;
            _executeProcess.StartInfo.RedirectStandardError = true;
            _executeProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            _executeProcess.StartInfo.FileName = "cmd.exe";
        }

        /// <summary>
        /// Start a process
        /// </summary>
        /// <param name="fileName">the file name</param>
        /// <param name="arguments">arguments</param>
        public void StartProcess(string fileName, string arguments)
        {
            _executeProcess.StartInfo.FileName = fileName;
            _executeProcess.StartInfo.Arguments = arguments;
            _executeProcess.Start();
        }
    }
}
