using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TESTEAPI.Models
{
    public class Customer
    {
        [Key]
        public int idCustomer { get; set; }
        public string dsName { get; set; }
        public string dsCPFCNPJ { get; set; }
        public string dsEmail { get; set; }
        public DateTime dtBirthDate { get; set; }
    }
}
