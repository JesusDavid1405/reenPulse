using AutoMapper;
using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.IDataBasic;
using Entity.DTOs.Implements.SensorDevice;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SensorDeviceServices : BusinessGeneric<SensorDeviceDto, SensorDeviceDto, SensorDevice>, ISensorDeviceServices
    {
        public SensorDeviceServices(IDataBasic<SensorDevice> data, IMapper mapper)
            : base(data, mapper)
        { }
    }
}
