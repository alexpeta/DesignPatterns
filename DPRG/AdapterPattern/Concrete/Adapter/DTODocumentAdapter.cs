using AdapterPattern.Concrete.DTO;
using AdapterPattern.Concrete.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete.Adapter
{
  public class DTODocumentAdapter : Document
  {

    private DTODocument Origin { get; private set; }

    public DTODocumentAdapter(DTODocument origin) 
    {
      Origin = origin;
    }

  }
}
