/*
 * (c) 2016 Giuseppe Cramarossa
 * This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/.
 */

using System.IO;

namespace CPP_Online_Compiler_Monitor
{
    /// <summary>
    /// CompilerLayout class
    /// </summary>
    class CompilerLayout : Layout
    {
        /// <summary>
        /// Compile a source file and generate the object file
        /// </summary>
        /// <param name="fileName">The file name to copile</param>
        /// <exception cref="FileNotFoundException" ></exception>
        public void CompileSource(string fileName)
        {
            if (fileName == "")
            {
                throw new FileNotFoundException("Source file not found", fileName + ".cpp");
            }

            Source = fileName;
            StartProcess(Properties.Settings.Default.MinGWPath + @"g++.exe", "-Wall -fexceptions -g -c " + Properties.Settings.Default.SourcePath + Source + ".cpp -o " + Properties.Settings.Default.OBJPath + Source + ".o");
            Output = _executeProcess.StandardError.ReadToEnd();
        }

        /// <summary>
        /// Generate an executable file
        /// </summary>
        public void GenerateExecutable()
        {
            if (Output != "")
            {
                throw new CompilerException(Output, CompilerException.COMPILERERROR);
            }

            StartProcess(Properties.Settings.Default.MinGWPath + @"g++.exe", " -Wall -o " + Properties.Settings.Default.EXEPath + Source + ".exe " + Properties.Settings.Default.OBJPath + Source + ".o");
            Output = _executeProcess.StandardError.ReadToEnd();
        }

        /// <summary>
        /// Check if there weren't errors during the linking 
        /// </summary>
        public void FinishLayer()
        {
            if (Output != "")
            {
                throw new CompilerException(Output, 'l');
            }
        }
    }
}
