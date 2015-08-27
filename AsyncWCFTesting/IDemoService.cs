using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace AsyncWCFTesting
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDemoService" in both code and config file together.
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        Task<string> GetStringDataAsync(string name);

    }

}
