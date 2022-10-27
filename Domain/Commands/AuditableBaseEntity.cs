using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public abstract class AuditableBaseEntity
    {
        public virtual int Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifieBy { get; set; }
        public DateTime? LastModified { get; set; }


    }
}
