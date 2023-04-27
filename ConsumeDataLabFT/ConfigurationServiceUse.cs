using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT
{
    public class ConfigurationServiceUse
    {
        private static IConfigurationService Service;

        public static void setServiceParameters(IConfigurationService serviceParameter)
        {
            Service = serviceParameter;
        }

        public static IConfigurationService getServiceParameters()
        {
            return Service;
        }
    }
}
