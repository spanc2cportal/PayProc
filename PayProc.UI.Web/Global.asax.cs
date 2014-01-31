namespace PayProc.UI.Web
{
    using System;
    using System.Configuration;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using Castle.Windsor;
    using PayProc.Utilities;

    public class MvcApplication : System.Web.HttpApplication
    {
        private static IWindsorContainer container=null;
 
        protected void Application_Start()
        {
            string conVal = ConfigurationManager.ConnectionStrings["PayProcConnection"].ToString();
            TDesEncryptDecryptUtil decMgr = new TDesEncryptDecryptUtil();
            AppDomain.CurrentDomain.SetData("ConStrKey", ConfigEncryptDecryptUtil.DecryptConVal(conVal, decMgr));

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            BaseConfig.SetContainer(container);
        }

        protected void Application_End()
        {
            if (container != null)
            {
                container.Dispose();
            }
        }
    }
}