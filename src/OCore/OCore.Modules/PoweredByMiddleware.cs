using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace OCore.Modules
{
    /// <summary>
    /// Adds the X-Powered-By header with values OCore.
    /// 该中间件提供自定义 HTTP 请求头（header ）的X-Powered-By值功能，默认值为"OCore"
    /// </summary>
    internal class PoweredByMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IPoweredByMiddlewareOptions _options;

        public PoweredByMiddleware(RequestDelegate next, IPoweredByMiddlewareOptions options)
        {
            _next = next;
            _options = options;
        }

        public Task Invoke(HttpContext httpContext)
        {
            if (_options.Enabled)
            {
                httpContext.Response.Headers[_options.HeaderName] = _options.HeaderValue;
            }
            
            return _next.Invoke(httpContext);
        }
    }
    
    public interface IPoweredByMiddlewareOptions
    {
        bool Enabled { get; set; }
        string HeaderName { get; }
        string HeaderValue { get; set; }
    }

    class PoweredByMiddlewareOptions: IPoweredByMiddlewareOptions
    {
        const string PoweredByHeaderName = "X-Powered-By";
        const string PoweredByHeaderValue = "OCore";

        public string HeaderName => PoweredByHeaderName;
        public string HeaderValue { get; set; } = PoweredByHeaderValue;

        public bool Enabled { get; set; } = true;
    }
}
