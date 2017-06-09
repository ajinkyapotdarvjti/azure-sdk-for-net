// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.IotHub;
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with ErrorDetails information.
    /// </summary>
    public class ErrorDetailsException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public ErrorDetails Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the ErrorDetailsException class.
        /// </summary>
        public ErrorDetailsException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetailsException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ErrorDetailsException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetailsException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public ErrorDetailsException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}