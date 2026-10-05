using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeMovieBooking.Database.Abstractions.Entities
{
    public interface IDomainEntity<TKey>
    {
        TKey Id { get; }
    }
}
