/*
 * (c) 2016 Giuseppe Cramarossa
 * This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/.
 */

using System;

namespace CPP_Online_Compiler_Monitor
{
    class VirusFoundException : ApplicationException
    {
        public string VirusDetail { get; set; }
         
        public VirusFoundException()
        {
        }

        public VirusFoundException(string message) : base(message)
        {
            VirusDetail = message;
        }

        public VirusFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
