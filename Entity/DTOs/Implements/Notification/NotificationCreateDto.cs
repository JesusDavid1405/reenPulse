using Entity.DTOs.Base;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.Notification
{
    public class NotificationCreateDto : BaseDto
    {
        public int? UserPlantId { get; set; }

        /// <summary>
        /// Nivel de la notificación (Info, Warning, Critical)
        /// </summary>
        public string Level { get; set; }

        public string Title { get; set; }
        public string Message { get; set; }

        /// <summary>
        /// Fecha y hora en que el usuario leyo la notificación
        /// </summary>
        public DateTime? AcknowledgedAt { get; set; }
    }
}
