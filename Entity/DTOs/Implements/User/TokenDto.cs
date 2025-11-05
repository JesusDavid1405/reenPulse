using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.User
{
    public class TokenDto
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public string CsrfToken { get; set; } = string.Empty;
        public DateTime ExpiresAt { get; set; }   // 🔹 Opcional, útil para frontend
    }
}
