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
    public string UserName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string EMail { get; set; } = string.Empty;

    [Required]
    public string Role { get; set; } = string.Empty;

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        yield return ValidationResult.Success;
    }
}
