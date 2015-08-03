using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uno;
using unoidl.com.sun.star.beans;
using unoidl.com.sun.star.document;
using unoidl.com.sun.star.frame;
using unoidl.com.sun.star.lang;
using unoidl.com.sun.star.script.provider;
using unoidl.com.sun.star.uno;

namespace Bicycles
{
    public class OpenOffice
    {
        private XComponentContext context;
        private XMultiServiceFactory service;
        private XComponentLoader desktop;

        public OpenOffice()
        {
            // Start a new instance of OpenOffice.org if it is not running.
            // https://wiki.openoffice.org/wiki/Documentation/DevGuide/ProUNO/CLI/Writing_Client_Programs
            context = uno.util.Bootstrap.bootstrap();

            service = (XMultiServiceFactory)context.getServiceManager();
            desktop = (XComponentLoader)service.createInstance("com.sun.star.frame.Desktop");
        }

        // Converts file path to OpenOffice API readable format.
        // https://wiki.openoffice.org/wiki/URL_Basics
        private string ConvertToURL(string filePath)
        {
            return String.Format("file:///{0}", filePath.Replace(@"\", "/"));
        }

        private void RunMacro(XComponent document, string macroName, string[] macroParam)
        {
            var providerSupplier = (XScriptProviderSupplier)document;
            if (document != null)
            {
                var provider = providerSupplier.getScriptProvider();
                var script = provider.getScript(
                    String.Format("vnd.sun.star.script:{0}?language=Basic&location=document", macroName));
                
                var param = new Any[] {
                    new Any(macroParam.GetType(), macroParam)};

                var outParamIndex = new short[0];
                var outParam = new Any[0];

                script.invoke(param, out outParamIndex, out outParam);
            }
        }

        public XComponent LoadTemplate(string filePath)
        {
            var loadProps = new PropertyValue[2];
            loadProps[0] = new PropertyValue { Name = "AsTemplate", Value = new Any(true) };
            loadProps[1] = new PropertyValue { Name = "MacroExecutionMode", Value = new Any(MacroExecMode.ALWAYS_EXECUTE_NO_WARN) };

            return desktop.loadComponentFromURL(
                ConvertToURL(filePath),
                "_blank", 0,
                loadProps);
        }

        public void ExportToWriter(string filePath, string[] dataToExport)
        {
            var document = LoadTemplate(filePath);
            RunMacro(document, "Standard.Main.LoadData", dataToExport);
        }
    }
}
