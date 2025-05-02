using System;
using System.Collections.Generic;

namespace EFCoreLearning.DataAccess.Models;

public partial class CustomerRank
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
