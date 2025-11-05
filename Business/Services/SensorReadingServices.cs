using AutoMapper;
using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.IDataBasic;
using Data.Interfaces.IDataImplement;
using Entity.DTOs.Implements.SensorReading;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SensorReadingServices : BusinessGeneric<SensorReadingSelectDto, SensorReadingCreateDto, SensorReading>, ISensorReadingServices
    {
        public SensorReadingServices(IDataBasic<SensorReading> data,IMapper mapper)
            : base(data, mapper)
        { }
    }
}
