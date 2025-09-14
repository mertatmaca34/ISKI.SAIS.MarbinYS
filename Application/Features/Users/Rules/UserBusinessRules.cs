using Application.Features.Users.Constants;

namespace Application.Features.Users.Rules;

public static class UserBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(UserMessages.NotFound);
    }
}

