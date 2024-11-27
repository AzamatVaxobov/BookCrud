using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrud.Models;

public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime PublicationDate { get; set; }
    public string Description { get; set; }
    public int PageNumber { get; set; }
    public double Price { get; set; }
    public List<string> AuthorsName { get; set; } = new List<string>();
    public List<string> ReadersName { get; set; } = new List<string>();
}
