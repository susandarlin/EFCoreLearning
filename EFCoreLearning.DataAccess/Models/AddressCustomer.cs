using System;
using System.Collections.Generic;

namespace EFCoreLearning.DataAccess.Models;

public partial class AddressCustomer
{
    public int CustomerId { get; set; }

    public string AddressId { get; set; } = null!;

    public int? Id { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
