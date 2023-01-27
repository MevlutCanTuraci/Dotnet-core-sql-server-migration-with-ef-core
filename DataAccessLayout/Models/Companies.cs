using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayout.Models
{
    public class Companies
    {
        [Key]
        public int id { get; set; }

        
        [StringLength(100)]
        public string companyName { get; set; }


        [DataType(DataType.Date)]
        public DateTime createdAt { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime updatedAt { get; set; }


        public ICollection<CompanyUsers> _CompanyUsers { get; set; }

    }
}
