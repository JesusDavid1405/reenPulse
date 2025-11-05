using Data.Interfaces.IDataImplement;
using Data.Repository;
using Entity.Infrastructure.Context;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class SensorDeviceRepository : DataGeneric<SensorDevice>, ISensorDeviceRepository
    {
        public SensorDeviceRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
