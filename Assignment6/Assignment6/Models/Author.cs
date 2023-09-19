using System;
using System.Collections.Generic;

namespace Assignment6.Models;

public partial class Author
{
    public int AuthorId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
}
