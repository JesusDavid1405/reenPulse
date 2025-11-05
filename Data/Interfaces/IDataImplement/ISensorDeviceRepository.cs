using Data.Interfaces.IDataBasic;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces.IDataImplement
{
    public interface ISensorDeviceRepository : IDataBasic<SensorDevice>
    {
    }
}
