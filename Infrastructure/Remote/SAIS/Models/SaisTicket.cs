namespace Infrastructure.Remote.SAIS.Models;

public sealed record SaisTicket(string TicketId, DateTimeOffset ExpiresAt);
