/*
 * (c) 2016 Giuseppe Cramarossa
 * This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/.
 */

using System;
using System.IO;
using System.Net;

namespace CPP_Online_Compiler_Monitor
{
    /// <summary>
    /// Website handler
    /// </summary>
    class WebsiteLayout : Layout
    {
        /// <summary>
        /// Object that permits to connect to a webserver
        /// </summary>
        private WebClient _client = new WebClient();

        /// <summary>
        /// 
        /// </summary>
        private EventHandler sourceDownloaded;

        /// <summary>
        /// Generated when the source is downloaded
        /// </summary>
        public event EventHandler SourceDownloaded
        {
            add
            {
                sourceDownloaded += value;
            }
            remove
            {
                sourceDownloaded -= value;
            }
        }


        public WebsiteLayout()
        {
            Source = "";
        }

        /// <summary>
        /// Download data from an API
        /// </summary>
        /// <param name="APIName">API name</param>
        /// <returns>a string containing the downloaded data</returns>
        private string DownloadFileData(string APIName)
        {
            string data = "";
            byte[] downloadedData = _client.DownloadData(Properties.Settings.Default.Website + "api/" + APIName);
            for (int i = 0; i < downloadedData.Length; i++)
            {
                data += "" + (char) downloadedData[i];
            }
            return data;
        }
        
        /// <summary>
        /// Save a source file 
        /// </summary>
        public void SaveSource()
        {
            string sourceFile = DownloadFileData("loadSource.php");
            if (sourceFile != "")
            {
                sourceDownloaded(this, EventArgs.Empty);
                char[] splitter = { '\n' };

                string[] lines = sourceFile.Split(splitter);
                // The first line contains the source id
                Source = lines[0];
                // The second line contains the entire source
                StreamWriter writer = File.CreateText(Properties.Settings.Default.SourcePath + Source + ".cpp");

                for (int i = 1; i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                }

                writer.Close();
            } 
        }

        /// <summary>
        /// Send a message to the website
        /// </summary>
        /// <param name="message">The message to show</param>
        /// <param name="errorType">the error type. It can be 'i', 'v', 'c' or 'l'</param>
        /// <param name="source">the source id</param>
        public void SaveMessage(string message, char errorType, string source)
        {
            DownloadFileData("saveErrors.php?sourceID=" + source + "&errorType=" + errorType + "&message=" + @message);
        }
    }
}
