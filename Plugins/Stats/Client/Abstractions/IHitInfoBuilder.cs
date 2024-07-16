﻿using Data.Models;
using IW4MAdmin.Plugins.Stats.Client.Game;
using SharedLibraryCore.Interfaces;

namespace IW4MAdmin.Plugins.Stats.Client.Abstractions
{
    public interface IHitInfoBuilder
    {
        HitInfo Build(string[] log, ParserRegex parserRegex, int entityId, bool isSelf, bool isVictim, Reference.Game gameName);
    }
}
