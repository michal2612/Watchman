﻿using System;

namespace Watchman.DomainModel.Protection
{
    public class ProtectionPunishment
    {
        public ProtectionPunishmentOption Option { get; private set; }
        public TimeSpan? Time { get; private set; }

        public ProtectionPunishment(ProtectionPunishmentOption option, TimeSpan? time = null)
        {
            Option = option;
            Time = time;
        }
    }
}
