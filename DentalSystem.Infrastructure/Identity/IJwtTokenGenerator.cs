﻿namespace DentalSystem.Infrastructure.Identity
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
