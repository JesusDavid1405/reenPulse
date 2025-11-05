using Business.Interfaces.IBusinessBasic;
using Entity.DTOs.Implements.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Implements
{
    public interface INotificationServices : IBusinessBasic<NotificationSelectDto, NotificationCreateDto>
    {
    }
}
