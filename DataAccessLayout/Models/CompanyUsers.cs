using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayout.Models
{
    public class CompanyUsers
    {
        [Key]
        public int id { get; set; }

        
        [ForeignKey("Companies")]
        public int companyId { get; set; }
        public Companies Companies { get; set; }


        [StringLength(150)]
        public string nameSurname { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime createdAt { get; set; }
        
        
        [DataType(DataType.Date)]
        public DateTime updatedAt { get; set; }

    }
}
