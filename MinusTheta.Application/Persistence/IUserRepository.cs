﻿using MinusTheta.Domain.Entities;

namespace MinusTheta.Application.Persistence
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        void Add(User user);
    }
}
