﻿using ChainExpander.Models.Enum;

namespace ChainExpander.Models.Data
{
    public abstract class IMessage
    {
        public abstract DomainEnum? Domain { get; set; }
        public abstract int? ID { get; set; }
        public abstract MessageTypeEnum? MsgType { get; set; }
    }
}