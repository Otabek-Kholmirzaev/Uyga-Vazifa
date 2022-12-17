using UygaVazifa.API.Data;
using UygaVazifa.API.Repositories.Interfaces;

namespace UygaVazifa.API.Repositories;

public class StudentAnswer : GenericRepository<StudentAnswer>, IStudentAnswerRepository
{
    public StudentAnswer(AppDbContext context) : base(context){}
}