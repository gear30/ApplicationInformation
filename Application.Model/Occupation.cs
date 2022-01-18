using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Model
{
    public class Occupation
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string OccupationCode { get; set; }
        public string JobTitle { get; set; }
        public string BusinessType { get; set; }

    }
}
