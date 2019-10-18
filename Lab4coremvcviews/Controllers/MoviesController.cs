using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab2.Models.Movies;
namespace Lab2.Controllers
{
public class MoviesController : Controller
{
    static List<Movie> movies = new List<Movie>
    {
        new Movie {
                Author="Todd Phillips",
                Genre="Criminal, Drama,Thriller",
                Name="Joker",
                Poster="https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/joker_dabf394a-d4f2-4b68-90e2-011ed6b54012_poster.png?d=270x360&q=20",
                CreatedAt=new DateTime(2019,10,3)
            },
            new Movie{
                Author="Tobey Maguire",
                Genre="Superhero, Drama, Sci-FI",
                Name="Spider-man",
                Poster="http://www.gstatic.com/tv/thumb/v22vodart/29821/p29821_v_v8_ae.jpg",
                CreatedAt=new DateTime(2002,04,5)
            },
            new Movie{
                Author="Rober Dawney Jr",
                Genre="Superhero,Drama,Sci-FI, Fantasy, Action",
                Name="Iron man",
                Poster="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ4mi0mHK2Yz9yXZ4poPAc0mRmVe8KtPfrhjXPOQL1dEw6C4qIZaA&s",
                CreatedAt=new DateTime(2008,3,14)
            },
            new Movie { 
                Author = "Joachim Rønning",
                Genre = "Adventure , Family , Fantasy", 
                Name = "Maleficent: Mistress of Evil",
                Poster = "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/maleficent-mistress-of-evil_c8507e61-a6b3-404d-b8c5-df6f74bc62be_poster.png?d=270x360&q=20",
                CreatedAt = new DateTime(2019,10,18)
            },
            new Movie { 
                Author = "Jon Favreau", 
                Genre = "Adventure , Animation , Drama , Family , Musical", 
                Name = "The Lion King",
                Poster = "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/the-lion-king_3904aadc-3a07-4836-892f-763b2dfdeea3_poster.png?d=270x360&q=20",
                CreatedAt = new DateTime(2019,7,19)
            }
    };
    public IActionResult Index()
    {
        
        return View(movies);
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Movie movie)
    {
        movies.Add(movie);
        return View("Index",movies);
    }
    
    
    public IActionResult Search(string text)
    {
        text=text.ToLower();
        var searchedMovies=movies.Where(movie =>movie.Name.ToLower().Contains(text)
                                              ||movie.Genre.ToLower().Contains(text)
                                              ||movie.Author.ToLower().Contains(text)).ToList();
        return View("Index",searchedMovies);
    }
}
}