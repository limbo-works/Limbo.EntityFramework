﻿using System.Net;

namespace Limbo.EntityFramework.Services.Models {
    /// <summary>
    /// A default respose wrapper for a service
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IServiceResponse<T> where T : class {
        /// <summary>
        /// The value of an action
        /// </summary>
        T? ResponseValue { get; set; }

        /// <summary>
        /// The associated http status code
        /// </summary>
        HttpStatusCode StatusCode { get; set; }
    }
}
