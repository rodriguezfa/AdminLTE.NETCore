using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.NETCore.Models
{
    public interface IControllerInformationRepository
    {
        List<ControllerInfo> GetAll();
    }
}
