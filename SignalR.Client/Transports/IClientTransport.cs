﻿using System.Threading.Tasks;
using System.Threading;

namespace SignalR.Client.Transports
{
    public interface IClientTransport
    {
        Task<NegotiationResponse> Negotiate(IConnection connection);
        Task Start(IConnection connection, string data);
        Task<T> Send<T>(IConnection connection, string data);
        void Stop(IConnection connection);

        void LostConnection(IConnection connection);
        bool SupportsKeepAlive();
        void MonitorKeepAlive(IConnection connection);
        void StopMonitoringKeepAlive();
    }
}
