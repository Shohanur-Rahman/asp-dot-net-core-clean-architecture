using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Response.Interfaces
{
    /// <summary>
    /// Interface for an API operation result.
    /// </summary>
    public interface IAPIOperationResult
    {
        /// <summary>
        /// Gets a value indicating whether this instance has errors.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has errors; otherwise, <c>false</c>.
        /// </value>
        bool HasErrors { get; }

        /// <summary>
        /// Gets a value indicating whether the API operation succeeded.
        /// </summary>
        bool Succeeded { get; }

        /// <summary>
        /// Gets the errors generated during the API operation.
        /// </summary>
        IEnumerable<string> Errors { get; }
    }
}
