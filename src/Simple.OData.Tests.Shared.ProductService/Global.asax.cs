using System.Web.Http;
using Simple.OData.Tests.Shared.ProductService.App_Start;

namespace Simple.OData.Tests.Shared.ProductService;

public class WebApiApplication : System.Web.HttpApplication
{
	protected static void Application_Start()
	{
		GlobalConfiguration.Configure(WebApiConfig.Register);
	}
}
