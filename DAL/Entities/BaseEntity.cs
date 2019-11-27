using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class BaseEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedTime  { get; set; }
        public DateTime EditedTime { get; set; }
        public int CreatedBy { get; set; }
        public int EditedBy { get; set; }
    }
}
