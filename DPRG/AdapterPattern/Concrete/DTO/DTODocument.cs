using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using AdapterPattern.Concrete.Model;

namespace AdapterPattern.Concrete.DTO
{
  public class DTODocument
  {
    public class SyncDocument
    {
      public int Id { get; set; }
      public Category Category { get; set; }
      public string Title { get; set; }
      public string Language { get; set; }
      public string Filename { get; set; }
      public string Description { get; set; }
      public int Version { get; set; }
      public DateTime LastModified { get; set; }
      public long Size { get; set; }
      public string MediaType { get; set; }
      public string SourceUrl { get; set; }
      public List<DTOTag> Tags { get; set; }
    }
  }
}
