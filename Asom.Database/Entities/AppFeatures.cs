using System;
using System.Collections.Generic;
using System.Text;

namespace Asom.Database.Entities
{
    public class AppFeatures : BaseEntity, IEntity
    {
        public bool IsAvailable { get; set; }
    }
}
