using System;

namespace WinUI.Models;

public record CreateStationCommand(string StationName, Guid StationId);

