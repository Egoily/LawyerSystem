using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.ls.Models
{
    public class SystemConfiguration
    {
        public OperationConfig OperationConfig { get; set; }
        public SystemConfiguration()
        {
            OperationConfig = new OperationConfig();
        }
    }

    public class OperationConfig
    {
        public Dictionary<int, string> OperationMappings { get; set; }
        public OperationConfig()
        {
            OperationMappings = new Dictionary<int, string>();
        }
    }
}
