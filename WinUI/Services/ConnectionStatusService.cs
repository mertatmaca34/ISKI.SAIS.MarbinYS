using WinUI.Models;

namespace WinUI.Services;

public interface IConnectionStatusService
{
    event EventHandler<ConnectionStatusChangedEventArgs>? StatusChanged;

    ConnectionState GetStatus(ConnectionComponent component);

    void ReportStatus(ConnectionComponent component, ConnectionState state, string? message = null);
}

/// <summary>
/// Thread-safe component that keeps track of the connection state of the PLC and SAIS API.
/// </summary>
public sealed class ConnectionStatusService : IConnectionStatusService
{
    private readonly object _syncRoot = new();
    private readonly Dictionary<ConnectionComponent, (ConnectionState State, string? Message)> _states = new();

    public event EventHandler<ConnectionStatusChangedEventArgs>? StatusChanged;

    public ConnectionState GetStatus(ConnectionComponent component)
    {
        lock (_syncRoot)
        {
            return _states.TryGetValue(component, out var entry) ? entry.State : ConnectionState.Unknown;
        }
    }

    public void ReportStatus(ConnectionComponent component, ConnectionState state, string? message = null)
    {
        bool hasChanged = false;
        lock (_syncRoot)
        {
            if (_states.TryGetValue(component, out var existing) &&
                existing.State == state &&
                string.Equals(existing.Message, message, StringComparison.Ordinal))
            {
                return;
            }

            _states[component] = (state, message);
            hasChanged = true;
        }

        if (hasChanged)
        {
            StatusChanged?.Invoke(this, new ConnectionStatusChangedEventArgs(component, state, message));
        }
    }
}
