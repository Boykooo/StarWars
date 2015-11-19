﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars
{
    interface IForm
    {
        Size sizeForm { get; set; }
        void Invalidate(Bitmap bt);
        void ChangeResources(int food, int titanium, int iridium, int gold);
    }
}
