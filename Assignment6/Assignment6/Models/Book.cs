using System;
using System.Collections.Generic;

namespace Assignment6.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public int? CategoryId { get; set; }

    public int? PublisherId { get; set; }

    public virtual ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();

    public virtual BookCategory? Category { get; set; }

    public virtual Publisher? Publisher { get; set; }
}
