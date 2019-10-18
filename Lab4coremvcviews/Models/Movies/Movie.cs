 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models.Movies
{
    public class Movie
    {
        [Display(Name="Id")]
        public int Id{get;set;}
        [Display(Name="Name of the film")]
        public string Name{get;set;}
        [Display(Name="Name of the Author")]
        public string Author{get;set;}
        [Display(Name="Fill the genres")]
        public string Genre{get;set;}
        [Display(Name="path to poster")]
        public string Poster{get;set;}
        [Display(Name="Release date")]
        public DateTime CreatedAt{get;set;}
    }
}
