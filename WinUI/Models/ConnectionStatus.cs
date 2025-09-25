using System;

namespace WinUI.Models;

/// <summary>
/// Identifies the connection source whose health is being tracked.
/// </summary>
public enum ConnectionComponent
{
    Plc,
    SaisApi
}

/// <summary>
/// Represents the health of a remote dependency.
/// </summary>
public enum ConnectionState
{
    Unknown,
    Connected,
    NotConfigured,
    NoAccess,
    Unreachable
}

/// <summary>
/// Event payload published when the connection status of a component changes.
/// </summary>
public sealed class ConnectionStatusChangedEventArgs : EventArgs
{
    public ConnectionStatusChangedEventArgs(ConnectionComponent component, ConnectionState state, string? message)
    {
        Component = component;
        State = state;
        Message = message;
    }

    public ConnectionComponent Component { get; }

    public ConnectionState State { get; }

    public string? Message { get; }
}
