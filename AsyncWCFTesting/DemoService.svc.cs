using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWCFTesting
{
    public class DemoService : IDemoService
    {
        public async Task<string> GetStringDataAsync(string name)
        {
            return await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(new Random().Next(1000, 6000));
                return $"The passed name is {name}";
            });
        }
    }
}
