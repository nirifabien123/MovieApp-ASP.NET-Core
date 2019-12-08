
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MovieApp.Models
{
    public class Movie
    {           [Key]
                public int Id { get; set; }
                
                public string Title { get; set; }
        
                [DataType(DataType.Date)]
                public DateTime ReleaseDate { get; set; }
                public int CategoryId { get; set; }
                public string Poster { get; set; }
                public decimal Price { get; set; }
                public Category Category { get; set; }
                public string Category1 { get; set; }
               // public Category Category { get; set; }
               
               
               
                
               
    }
}