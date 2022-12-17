using UygaVazifa.API.Data;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Repositories.Interfaces;

namespace UygaVazifa.API.Repositories;

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
    public CommentRepository(AppDbContext context) : base(context){}
}