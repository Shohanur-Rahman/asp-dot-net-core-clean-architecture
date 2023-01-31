using App.Response.Generic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Response.Generic
{
    public class APIOperationResultGeneric<T> : APIOperationResult, IAPIOperationResultGeneric<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIOperationResult{T}"/> class.
        /// </summary>
        /// <param name="succeeded">if set to <c>true</c> [succeeded].</param>
        /// <param name="result">The result.</param>
        /// <param name="errors">The errors.</param>
        [JsonConstructor]
        protected internal APIOperationResultGeneric(bool succeeded, T result, params string[] errors)
            : base(succeeded, errors)
        {
            Result = result;
        }

        internal APIOperationResultGeneric(IBusinessOperationResultGeneric<T> businessResult)
            : base(businessResult)
        {
            if (businessResult == null)
                throw new ArgumentNullException(nameof(businessResult));

            Result = businessResult.Result;
        }

        /// <summary>
        /// Gets the result value returned by the operation.
        /// </summary>
        public T Result { get; private set; }
    }
}
