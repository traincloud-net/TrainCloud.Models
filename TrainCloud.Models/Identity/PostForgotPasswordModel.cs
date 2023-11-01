using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Identity;
public class PostForgotPasswordModel
{
    [Required]
    [EmailAddress]
    public string EMail { get; set; } = string.Empty;
}
