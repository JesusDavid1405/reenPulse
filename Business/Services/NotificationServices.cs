using AutoMapper;
using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.IDataBasic;
using Entity.DTOs.Implements.Notification;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class NotificationServices : BusinessGeneric<NotificationSelectDto, NotificationCreateDto, Notification>, INotificationServices
    {
        public NotificationServices(IDataBasic<Notification> data, IMapper mapper)
            : base(data, mapper)
        { }
    }
}
