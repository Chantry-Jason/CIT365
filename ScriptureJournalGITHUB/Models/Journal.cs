using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScriptureJournal.Models
{
    public class Journal
    {
        public int ID { get; set; }



        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }
        [Range(1, 150)]
        [Required]
        public int Chapter { get; set; }
        [Range(1, 150)]
        [Required]
        public int Verse { get; set; }
        [StringLength(254)]
        [Required]
        public string Note { get; set; }

        [Display(Name = "Date Added")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }


        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        //[Required]
        //[StringLength(30)]
        //public string Genre { get; set; }

        
        //[Range(1, 100)]
        //[DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal Price { get; set; }
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")] //must start with one or more capital letters and follow with zero or more letters, 
        //                                                    //numbers, single or double quotes, whitespace characters, or dashes
        //[StringLength(5)]
        //[Required]
        //public string Rating { get; set; }
    }
}
