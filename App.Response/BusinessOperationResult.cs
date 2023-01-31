using App.Response.Generic;
using App.Response.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Response
{
    public class BusinessOperationResult : IBusinessOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessOperationResult"/> class.
        /// </summary>
        private BusinessOperationResult()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessOperationResult" /> class.
        /// </summary>
        /// <param name="succeeded">if set to <c>true</c> [succeeded].</param>
        /// <param name="errors">The errors.</param>
        [JsonConstructor]
        protected internal BusinessOperationResult(bool succeeded, params string[] errors)
        {
            Succeeded = succeeded;
            Errors = errors?.ToList() ?? Enumerable.Empty<string>();
        }

        /// <summary>
        /// Gets a value indicating whether the API operation succeeded.
        /// </summary>
        public bool Succeeded { get; private set; }

        /// <summary>
        /// Gets the errors generated during the API operation.
        /// </summary>
        public IEnumerable<string> Errors { get; private set; } = Enumerable.Empty<string>();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>BusinessOperationResult.</returns>
        public static BusinessOperationResult Success()
        {
            return new BusinessOperationResult(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="errors">The errors.</param>
        /// <returns>BusinessOperationResult.</returns>
        public static BusinessOperationResult Failure(params string[] errors)
        {
            return new BusinessOperationResult(false, errors);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">The result.</param>
        /// <returns>BusinessOperationResult&lt;T&gt;.</returns>
        public static BusinessOperationResultGeneric<T> Success<T>(T result)
        {
            return new BusinessOperationResultGeneric<T>(true, result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="errors"></param>
        /// <returns></returns>
        public static BusinessOperationResultGeneric<T> Failure<T>(params string[] errors)
        {
            return new BusinessOperationResultGeneric<T>(false, default(T), errors);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">The result.</param>
        /// <param name="errors">The errors.</param>
        /// <returns>BusinessOperationResult&lt;T&gt;.</returns>
        public static BusinessOperationResultGeneric<T> FailureWithResult<T>(T result, params string[] errors)
        {
            return new BusinessOperationResultGeneric<T>(false, result, errors);
        }

    }
}
