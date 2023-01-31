﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Response.Interfaces;

namespace App.Response.Generic.Interfaces
{
    public interface IAPIOperationResultGeneric<out T> : IAPIOperationResult
    {
        /// <summary>
        /// Gets the result returned by the operation.
        /// </summary>
        T Result { get; }
    }
}
