using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Identity;
public class UserModel
{
    public Guid Id { get; set; }
    
    public Guid? TenantId { get; set; }

    public string UserName { get; set; }

    public string EMail { get; set; }
    
    public bool EMailConfirmed{ get; set; }

    public List<string>? Roles { get; set; }

    public DateTimeOffset SignUpDate { get; set; }
}
