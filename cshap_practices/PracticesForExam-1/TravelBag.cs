using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineOrder.io;

namespace PracticesForExam_1;


internal class TravelBag : Garments
{
    public string Name { get; set; }
    public string ID { get; set; }

    public TravelBag(string name, string id)
    {
        Name = name;
        ID = id;
    }
}