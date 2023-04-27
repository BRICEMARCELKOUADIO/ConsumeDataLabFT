using Inexa.DependencyContainer.AutoRegister;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT
{
    [Implement(typeof(IConfigurationService))]
    public class ConfigureService : IConfigurationService
    {

        public string BaseAdresse()
        {
           return ConfigurationManager.AppSettings["BaseAddresse"];
        }
    }
}
