/*
 * (c) 2016 Giuseppe Cramarossa
 * This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/.
 */
 
using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace CPP_Online_Compiler_Monitor
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start a new Thread when a source is downloaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Website_SourceDownloaded(object sender, EventArgs e)
        {
            Thread compiler = new Thread(StartCompiler);
            compiler.Start();
        }

        /// <summary>
        /// Generated when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateInputs();
        }

        /// <summary>
        /// Start the compiler
        /// </summary>
        private void StartCompiler()
        {
            CompilerLayout compiler = new CompilerLayout();
            WebsiteLayout website = new WebsiteLayout();
            AntivirusLayout antivirus = new AntivirusLayout();
            website.SourceDownloaded += Website_SourceDownloaded;
            bool compilerEnabled = false;
            while (!compilerEnabled)
            {
                try
                {
                    website.SaveSource();
                    website.SaveMessage("Compiling...", 'i', website.Source);
                    compiler.CompileSource(website.Source);
                    // Delete the source file
                    File.Delete(Properties.Settings.Default.SourcePath + website.Source + ".cpp");
                    website.SaveMessage("Compiling complete. Linking...", 'i', website.Source);
                    compiler.GenerateExecutable();
                    if (EICARVirusGenerator.Checked)
                    {
                        EICARGenerator(website.Source);
                    }
                    // Delete the object file
                    File.Delete(Properties.Settings.Default.OBJPath + website.Source + ".o");
                    compiler.FinishLayer();
                    website.SaveMessage("Linking complete. Antivirus file scanning...", 'i', website.Source);
                    antivirus.ScanFile(website.Source);
                    antivirus.MakeFileDownloadable();
                    website.SaveMessage("Antivirus scanning complete. No Viruses found. You can download the generated file " + website.Source, 'i', website.Source);
                    compilerEnabled = true;
                }
                catch (CompilerException compilerException)
                {
                    website.SaveMessage(compilerException.Message, compilerException.ErrorType, website.Source);
                }
                catch (VirusFoundException virusFound)
                {
                    website.SaveMessage(virusFound.VirusDetail, 'v', website.Source);
                    // Delete the executable file
                    File.Delete(Properties.Settings.Default.EXEPath + website.Source + ".exe");
                }
                catch (FileNotFoundException fileNotFound)
                {
                }
                catch (NotSupportedException notSupported)
                {
                }
                catch (WebException web)
                {

                }

                /*
                website.Source = "";
                compiler.Source = "";
                antivirus.Source = "";
                */
            }
        }

        /// <summary>
        /// Update all textboxes in the main form
        /// </summary>
        private void UpdateInputs()
        {
            websiteName.Text = Properties.Settings.Default.Website;
            mingwPath.Text = Properties.Settings.Default.MinGWPath;
            exePath.Text = Properties.Settings.Default.EXEPath;
            clamAVPath.Text = Properties.Settings.Default.ClamAVPath;
            objPath.Text = Properties.Settings.Default.OBJPath;
            sourcePath.Text = Properties.Settings.Default.SourcePath;
        }

        /// <summary>
        /// Change the path in the textbox
        /// </summary>
        /// <param name="input">The textbox to change</param>
        private void ChangePath(TextBox input)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "")
            {
                input.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        /// <summary>
        /// Change the path in a textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pathClicker(object sender, EventArgs e)
        {
            ChangePath((TextBox) sender);
            Properties.Settings.Default.MinGWPath = mingwPath.Text;
            Properties.Settings.Default.EXEPath = exePath.Text;
            Properties.Settings.Default.ClamAVPath = clamAVPath.Text;
            Properties.Settings.Default.OBJPath = objPath.Text;
            Properties.Settings.Default.SourcePath = sourcePath.Text;
            UpdateInputs();
        }

        /// <summary>
        /// Create a file that contains the EICAR test virus
        /// </summary>
        /// <param name="source">The source</param>
        private void EICARGenerator(string source)
        {
            string EICARString = @"X5O!P%@AP[4\PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H+H*";
            File.WriteAllText(Properties.Settings.Default.EXEPath + source + ".exe", EICARString);
        }

        /// <summary>
        /// Generated when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Generated when a button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Thread compiler = new Thread(StartCompiler);
            compiler.Start();
        }

        /// <summary>
        /// Generated when the website textbox is left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateWebsite(object sender, EventArgs e)
        {
            Properties.Settings.Default.Website = websiteName.Text;
        }
    }
}
