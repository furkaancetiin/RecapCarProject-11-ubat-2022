﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:DataResult
    {
        public ErrorResult(string message):base(false,message)
        {

        }

        public ErrorResult():base(false)
        {

        }
    }
}
