using UygaVazifa.API.Data;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Repositories.Interfaces;

namespace UygaVazifa.API.Repositories;

public class UserGroupRepository : GenericRepository<UserGroup>, IUserGroupRepository
{
    public UserGroupRepository(AppDbContext context) : base(context){}
}