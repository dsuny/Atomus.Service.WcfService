using Atomus.Diagnostics;
using System;

namespace Atomus.Service
{
    public class WcfService : IService
    {
        Response IService.Request(ServiceDataSet serviceDataSet)
        {
            //IService service;

            try
            {
                //service = (IService)this.CreateInstance("ServerAdapter");
                //_Service = (IService)Factory.CreateInstance(@"E:\Work\Project\Atomus\Service\ServerAdapter\bin\Debug\Atomus.Service.ServerAdapter.V1.0.0.0.dll", "Atomus.Service.ServerAdapter", true, true);

                return ((IService)this.CreateInstance("ServerAdapter")).Request(serviceDataSet);
            }
            catch (AtomusException exception)
            {
                DiagnosticsTool.MyTrace(exception);
                return (Response)Factory.CreateInstance("Atomus.Service.Response", false, true, exception);
            }
            catch (Exception exception)
            {
                DiagnosticsTool.MyTrace(exception);
                return (Response)Factory.CreateInstance("Atomus.Service.Response", false, true, exception);
            }
        }
    }
}
