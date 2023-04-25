using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NLog;
using System.Diagnostics;
using System.Net;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;
        private Stopwatch stopwatch; 
        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            Exception _ex = null;
            string RequestPath = context.Request.Path.Value;
            string jsonResponse = string.Empty;
            Stream originBody = null;
            string apiRequest = string.Empty;

            try
            {

                Stream stream = context.Request.Body;
                originBody = context.Response.Body;
                stopwatch = new Stopwatch();
                stopwatch.Start();
                context.Response.Body = new MemoryStream();
                string _originalContent = new StreamReader(stream).ReadToEnd();
                apiRequest=_originalContent; 

                var requestContent = new StringContent(_originalContent);
                context.Request.Body = await requestContent.ReadAsStreamAsync();
                var newBody = new MemoryStream();
                context.Response.Body = newBody;
                await _next(context);
                if (context.Response.StatusCode != (int)HttpStatusCode.OK)
                {
                    GlobalResponse resp = new GlobalResponse();
                    resp.statusCode = new StatusCode();
                    resp.statusCode.code = 1;
                    resp.statusCode.message = "Server Error";
                    var json = JsonConvert.SerializeObject(resp);
                    jsonResponse = json;
                }
                else
                {
                    var originalResponse = context.Response.Body;
                    originalResponse.Seek(0, SeekOrigin.Begin);
                    jsonResponse = new StreamReader(originalResponse).ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                GlobalResponse resp = new GlobalResponse();
                resp.statusCode = new StatusCode();
                resp.statusCode.code = 1;
                resp.statusCode.message = "Server Error";
                var json = JsonConvert.SerializeObject(resp);
                jsonResponse = json;
            }
            finally
            {
                context.Response.Body = originBody;
                stopwatch.Stop(); 
                if (_ex != null)
                    _logger.LogError($"ERROR: {_ex}");
                else
                    _logger.LogInformation("Request: "+apiRequest+" Response: "+ jsonResponse + " ExecutionTime:"+ stopwatch.ElapsedMilliseconds.ToString());
                await context.Response.WriteAsync(jsonResponse);
            }
        }
    }
}