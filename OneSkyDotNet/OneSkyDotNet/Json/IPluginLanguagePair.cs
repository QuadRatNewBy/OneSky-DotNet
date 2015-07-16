﻿namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IPluginLanguagePair
    {
        IOneSkyResponse<IMeta, IEnumerable<ILocale>> GetLanguagePairs(string fromLocale);
    }
}