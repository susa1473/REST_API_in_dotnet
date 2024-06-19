using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace myRESTAPI.Models
{
    public class ProgrammingLanguageModel
    {
        [Required]
        public int  Id { get; set; }

        [Required]
        [StringLength(1)]
        public required string Name {get; set;}

        public string? Info {get; set;}

        public int Released_year {get; set;}

        public int Githut_rank {get; set;}

        [Required]
        public DateTime Created_at {get; set;}
        
        [Required]
        public DateTime Updated_at {get; set;}
        
    }
}
