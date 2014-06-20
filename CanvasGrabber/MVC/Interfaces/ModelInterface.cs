﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasGrabber.MVC.Interfaces
{
    interface ModelInterface
    {
        void NotifyListeners();
        void AddListener(ViewInterface view);
    }
}
