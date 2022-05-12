﻿using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.DataAccess.Interfaces
{
    public interface IUserDal : IGenericDal<User>
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> LoginAsync(User user);
    }
}
