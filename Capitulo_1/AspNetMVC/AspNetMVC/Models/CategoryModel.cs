using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMVC.Models
{
    public class CategoryModel
    {
        #region Variables and Properties

        public long CategoryId { get; set; }
        public string Name { get; set; }

        #endregion

        #region Functions

        public override string ToString() => $"{CategoryId} >> {Name}";

        #endregion
    }
}
