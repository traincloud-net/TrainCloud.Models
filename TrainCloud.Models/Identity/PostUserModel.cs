using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Identity;
public class PostUserModel : IValidatableObject
{    
    public Guid? TenantId { get; set; }

    [Required]
    public string UserName { get; set; }

    [Required]
    public string EMail { get; set; }

    public List<string>? Roles { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        yield return ValidationResult.Success;
    }
}
