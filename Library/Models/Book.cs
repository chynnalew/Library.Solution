using System.Collections.Generic;

namespace Library.Models
{
    public class Book
    {
      public Book()
      {
        this.JoinEntities = new HashSet<BookAuthors>();
      }

      public int BookId { get; set; }

      public string OwnerId { get; set; }
      public string Title { get; set; }
      public string Genre { get; set; }

      public virtual ICollection<BookAuthors> JoinEntities {get;}

      public virtual ICollection<UserBooks> JoinUserBooks {get;}

    }
 
}