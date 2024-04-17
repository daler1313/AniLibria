using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class CreateAnimeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
     //   public Author Author { get; set; }  

        public int AuthorId { get; set; }
      //  public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public int DateOfSsue { get; set; }
       // public virtual ICollection<Season> Seasons { get; set; }
      //  public virtual ICollection<Vewing> Vewings { get; set; }
    }
}
