using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using SoapCore;
using SoapCore.Extensibility;
using SoapCore.ServiceModel;

namespace WebSoap
{
    public class TunerService : IServiceOperationTuner
    {
        public void Tune(HttpContext httpContext, object serviceInstance, OperationDescription operation)
        {
            string result = string.Empty;

            StringValues paramValue;

            // Read Header.
            if(httpContext.Request.Headers.TryGetValue("username",out paramValue))
            {
                result = paramValue[0];
            }

            // Do Something With The Result.
        }
    }
}
