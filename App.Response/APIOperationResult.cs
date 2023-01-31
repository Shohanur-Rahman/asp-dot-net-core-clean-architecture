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
    public class APIOperationResult : IAPIOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIOperationResult"/> class.
        /// </summary>
        private APIOperationResult()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIOperationResult"/> class.
        /// </summary>
        /// <param name="succeeded">if set to <c>true</c> [succeeded].</param>
        /// <param name="errors">The errors.</param>
        [JsonConstructor]
        protected internal APIOperationResult(bool succeeded, params string[] errors)
        {
            Succeeded = succeeded;
            SetErrors(errors?.ToList());
        }

        internal APIOperationResult(IBusinessOperationResult businessResult)
        {
            if (businessResult == null)
                throw new ArgumentNullException(nameof(businessResult));

            Succeeded = businessResult.Succeeded;
            SetErrors(businessResult.Errors);
        }
        /// <summary>
        /// Gets a value indicating whether this instance has errors.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has errors; otherwise, <c>false</c>.
        /// </value>
        public bool HasErrors { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the API operation succeeded.
        /// </summary>
        public bool Succeeded { get; private set; }

        /// <summary>
        /// Gets the errors generated during the API operation.
        /// </summary>
        public IEnumerable<string> Errors { get; private set; } = Enumerable.Empty<string>();

        #region Static Factory Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns>APIOperationResult.</returns>
        public static APIOperationResult Success()
        {
            return new APIOperationResult(true);
        }

        /// <summary>
        /// Successes the specified errors.
        /// </summary>
        /// <param name="errors">The errors.</param>
        /// <returns></returns>
        public static APIOperationResult Success(params string[] errors)
        {
            return new APIOperationResult(true, errors);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="errors">The errors.</param>
        /// <returns>APIOperationResult.</returns>
        public static APIOperationResult Failure(params string[] errors)
        {
            return new APIOperationResult(false, errors);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">The result.</param>
        /// <returns>APIOperationResult&lt;T&gt;.</returns>
        public static APIOperationResultGeneric<T> Success<T>(T result)
        {
            return new APIOperationResultGeneric<T>(true, result);
        }

        /// <summary>
        /// Successes the specified result.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">The result.</param>
        /// <param name="errors">The errors.</param>
        /// <returns></returns>
        public static APIOperationResultGeneric<T> Success<T>(T result, params string[] errors)
        {
            return new APIOperationResultGeneric<T>(true, result, errors);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="errors">The errors.</param>
        /// <returns>APIOperationResult&lt;T&gt;.</returns>
        public static APIOperationResultGeneric<T> Failure<T>(params string[] errors)
        {
            return new APIOperationResultGeneric<T>(false, default(T), errors);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">The result.</param>
        /// <param name="errors">The errors.</param>
        /// <returns>APIOperationResult&lt;T&gt;.</returns>
        public static APIOperationResultGeneric<T> FailureWithResult<T>(T result, params string[] errors)
        {
            return new APIOperationResultGeneric<T>(false, result, errors);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Sets the errors.
        /// </summary>
        /// <param name="errors">The errors.</param>
        private void SetErrors(IEnumerable<string> errors)
        {
            Errors = errors?.ToList() ?? Enumerable.Empty<string>();
            HasErrors = Errors.Any();
        }

        #endregion
    }
}
