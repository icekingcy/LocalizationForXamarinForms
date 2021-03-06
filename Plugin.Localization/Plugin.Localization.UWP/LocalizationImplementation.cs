﻿using System.IO;
using Plugin.Localization.Abstractions;

namespace Plugin.Localization
{
    public partial class LocalizationImplementation : ILocalization
    {
        private string FileLoad(string path)
        {
            return File.ReadAllText(path);
        }
    }
}