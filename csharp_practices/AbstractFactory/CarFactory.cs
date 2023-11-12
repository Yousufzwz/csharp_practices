﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory;

public abstract class CarFactory
{
    public abstract ITire CreateTire();
    public abstract IEngine CreateEngine();
    public abstract IHeadLight CreateHeadLight();

}
