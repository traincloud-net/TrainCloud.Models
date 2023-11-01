using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Identity;
public class PostChangePasswordModel
{
    [Required]
    [MinLength(6)]
    [MaxLength(64)]
    public string OldPassword { get; set; } = string.Empty;

    [Required]
    [MinLength(6)]
    [MaxLength(64)]
    public string NewPassword { get; set; } = string.Empty;

    [Required]
    [MinLength(6)]
    [MaxLength(64)]
    public string ConfirmNewPassword { get; set; } = string.Empty;
}
