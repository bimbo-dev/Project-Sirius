﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Entity.Entities
{
    public class UserTaskComment : BaseEntity
    {
        public virtual Guid Id { get; set; }
        public virtual Guid UserTaskId { get; set; }
        public virtual string CommenterId { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
