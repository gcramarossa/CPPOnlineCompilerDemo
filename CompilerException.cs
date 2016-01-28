/*
 * (c) 2016 Giuseppe Cramarossa
 * This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/.
 */

using System;

namespace CPP_Online_Compiler_Monitor
{
    class CompilerException : ApplicationException
    {
        private char _errorType;

        /// <summary>
        /// Defines a compiler error
        /// </summary>
        public const char COMPILERERROR = 'c';

        /// <summary>
        /// Defines a linker error
        /// </summary>
        public const char LINKERERROR = 'l';

        public char ErrorType
        {
            get
            {
                return _errorType;
            }               
        }

        public CompilerException()
        {
        }

        public CompilerException(string message) : base(message)
        {
        }

        public CompilerException (string message, char errorType) : base(message)
        {
                    
            _errorType = errorType;
        }

        public CompilerException(string message, Exception inner) : base(message, inner)
        {
        }

    }
}
