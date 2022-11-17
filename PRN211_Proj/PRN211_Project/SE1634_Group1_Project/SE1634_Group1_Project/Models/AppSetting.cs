using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1634_Group1_Project.Models
{
    public class AppSetting
    {
        private readonly IConfigurationRoot _config;
        public AppSetting()
        {
            _config = new ConfigurationBuilder().SetBasePath(Environment.CurrentDirectory).AddJsonFile("appsettings.json").Build();
        }
        public string getString(string name)
        {
            return _config[name];
        }
        public string getConnectionString(string connect)
        {
            return _config.GetConnectionString(connect);
        }
    }
}
