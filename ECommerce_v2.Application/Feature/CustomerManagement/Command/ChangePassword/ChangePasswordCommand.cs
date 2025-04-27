using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.CustomerManagement.Command.ChangePassword
{
    public class ChangePasswordCommand: IRequest
    {
        public Guid CustomerId { get; set; }
        public string CurrentPassword { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
        public string ConfirmNewPassword { get; set; } = null!;
    }
}
