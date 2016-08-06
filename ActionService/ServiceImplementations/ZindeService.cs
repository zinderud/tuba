using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ZindeService.ServiceContracts;

namespace ZindeService.ServiceImplementations
{
       [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]

    public partial class ZindeService : IZindeService
    {
    }
}
