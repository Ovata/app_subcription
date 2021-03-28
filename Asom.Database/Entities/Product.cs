using System;
using System.Collections.Generic;
using System.Text;

namespace Asom.Database.Entities
{
    public class Product : BaseEntity, IEntity
    {
        public string Description { get; set; }
        public string WebsiteUrl { get; set; }
        public string LogoUrl { get; set; }
    }
}
