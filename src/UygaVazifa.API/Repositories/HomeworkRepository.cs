using UygaVazifa.API.Data;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Repositories.Interfaces;

namespace UygaVazifa.API.Repositories;

public class HomeworkRepository : GenericRepository<Homework> , IHomeworkRepository
{
    public HomeworkRepository(AppDbContext context) : base(context){}
}