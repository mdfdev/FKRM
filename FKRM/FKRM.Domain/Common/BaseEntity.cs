using System;

namespace FKRM.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime AddedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        public virtual string IPAddress { get; set; }
    }
}
