using Business.Interfaces.IBusinessBasic;
using Entity.DTOs.Implements.SensorReading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Implements
{
    public interface ISensorReadingServices : IBusinessBasic<SensorReadingSelectDto, SensorReadingCreateDto>
    { }
}
