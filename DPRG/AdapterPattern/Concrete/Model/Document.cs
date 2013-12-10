using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete.Model
{
  public class Document
  {
    public int Id { get; set; }
    public string Title { get; set; }   
    public int CategoryId { get; set; }   
    public string Language { get; set; }   
    public string Filename { get; set; }   
    public string Description { get; set; }   
    public bool IsLocal { get; set; }   
    public bool IsSuggestedByMarketing { get; set; }   
    public bool IsHot { get; set; }   
    public bool IsFavorite { get; set; }   
    public int Version { get; set; }   
    public DateTime LastModified { get; set; }   
    public long Size { get; set; }   
    public string MediaType { get; set; }   
    public string SourceUrl { get; set; }
  }
}
