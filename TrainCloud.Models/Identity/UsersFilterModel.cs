using System.ComponentModel.DataAnnotations;

namespace TrainCloud.Models.Identity;

public class UsersFilterModel : AbstractFilterModel, IFilterModel
{
    public Guid? TenantId { get; set; }
}

