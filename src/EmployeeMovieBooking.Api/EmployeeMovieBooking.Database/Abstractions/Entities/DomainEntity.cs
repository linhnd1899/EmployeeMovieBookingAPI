using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EmployeeMovieBooking.Database.Abstractions.Entities
{

    [ExcludeFromCodeCoverage]
    public abstract class DomainEntity<TKey> : IDomainEntity<TKey>
    {
        public virtual TKey Id { get; set; } = default!;

        protected DomainEntity() { }

        protected DomainEntity(TKey id)
        {
            Id = id;
        }

        /// <summary>
        /// True if domain entity has an identity
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            if (Id == null)
                return false;

            return Id.Equals(default(TKey));
        }
    }
}
