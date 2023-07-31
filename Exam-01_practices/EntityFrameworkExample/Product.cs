using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Tag { get; set; }
    public bool IsActive { get; set; }
}
