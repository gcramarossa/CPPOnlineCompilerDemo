/*
 * (c) 2016 Giuseppe Cramarossa
 * This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/.
 */

namespace CPP_Online_Compiler_Monitor
{
    /// <summary>
    /// AntivirusLayout Class
    /// </summary>
    class AntivirusLayout : Layout
    {

        /// <summary>
        /// Scan the file
        /// </summary>
        /// <param name="fileName">The file name</param>
        public void ScanFile(string fileName)
        {
            Source = fileName;
            StartProcess(Properties.Settings.Default.ClamAVPath + "clamscan.exe", " -v " + Properties.Settings.Default.EXEPath + Source + ".exe");
            Output = _executeProcess.StandardOutput.ReadToEnd();
        }

        /// <summary>
        /// If there weren't viruses in the file, make the file downloadable 
        /// </summary>
        /// <exception cref="VirusFoundException">Generated when a virus is found</exception>
        public void MakeFileDownloadable()
        {
            if (!Output.Contains("OK"))
            {
                throw new VirusFoundException(Output);
            }
        }


    }
}
