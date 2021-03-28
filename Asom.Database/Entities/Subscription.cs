using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Asom.Database.Entities
{
    public class Subscription : BaseEntity, IEntity
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        //public Money Price { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }


        public virtual List<AppFeatures> Features { get; set; }
    }
}
