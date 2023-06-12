using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.cs;

internal abstract class LibraryMember
{
   internal int masterFee;
   internal string Name { get; set; }
   internal int PupilFee
    {
        get { return MasterFee; }
        set { MasterFee = value; }
    }
    public int MasterFee
    {
        get
        {
            if (masterFee < 0)
            {
                return 0;
            }
            else
            {
                return masterFee;
            }
        }
        set
        {
            if (value >= 0)
            {
                masterFee = value;
            }
            else
            {
                throw new NotImplementedException("Membership fee cannot be negative!");
            }
        }

    }



}
