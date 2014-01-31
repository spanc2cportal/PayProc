namespace PayProc.UI.Web
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Castle.Windsor;
    using Castle.Windsor.Installer;

    public class BaseConfig
    {
        public static void SetContainer(IWindsorContainer container)
        {
            container = new WindsorContainer().Install(FromAssembly.This());
            var controllerFactory = new WindsorControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
 
    }
}