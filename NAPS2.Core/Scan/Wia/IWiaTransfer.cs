﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WIA;

namespace NAPS2.Scan.Wia
{
    public interface IWiaTransfer
    {
        Stream Transfer(int pageNumber, Device device, Item item, string format);
    }
}
