﻿using Mystique.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mystique.Core.Contracts
{
    public interface INotification
    {
        void Handle(string data);
    }
}