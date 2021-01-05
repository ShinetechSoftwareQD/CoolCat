﻿using System;

namespace CoolCat.Core.ViewModels
{
    public class PluginListItemViewModel
    {
        public Guid PluginId { get; set; }

        public string UniqueKey { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Version { get; set; }

        public bool Enable { get; set; }
    }
}
