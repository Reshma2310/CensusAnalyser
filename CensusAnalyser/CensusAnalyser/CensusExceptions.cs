﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusAnalyser
{
    public class CensusExceptions : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_DELIMITER, INCORRECT_HEADER, INVALID_FILE
        }
        ExceptionType Type;
        public CensusExceptions(ExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
