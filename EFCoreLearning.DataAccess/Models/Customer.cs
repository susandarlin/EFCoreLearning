using System;
using System.Collections.Generic;

namespace EFCoreLearning.DataAccess.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? Age { get; set; }

    public int CustomerRankId { get; set; }

    public virtual CustomerRank CustomerRank { get; set; } = null!;

    public virtual ICollection<AddressCustomer> AddressCustomers { get; set; }
}
