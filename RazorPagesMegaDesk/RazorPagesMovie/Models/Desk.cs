using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDesk.Models
{
    public class Desk
    {

        //enum that holds the Surface material options.
        public enum SurfaceMaterial 
        {

            Laminate = 1,
            Oak = 2,
            Rosewood = 3,
            Veneer = 4,
            Pine = 5
        };
        public int ID { get; set; }
        [Display(Name = "Customer Name")]
        [StringLength(120, MinimumLength = 3)]
        [Required]
        public string name { get; set; }
        [Display(Name = "Width")]
        [Range(24, 96)]
        [Required]
        public double width { get; set; }
        [Display(Name = "Depth")]
        [Range(12, 48)]
        [Required]
        public double depth { get; set; }
        [Display(Name = "Num Drawers")]
        [Range(0, 7)]
        [Required]
        public int numDrawers { get; set; }
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public double price { get; set; }
        [Display(Name = "Surface Material")]
        [Required]
        public string surfaceMat { get; set; }
        [Display(Name = "Rush Order")]
        [Required]
        public string rushOrd { get; set; }
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
