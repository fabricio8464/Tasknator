using Microsoft.EntityFrameworkCore;
using Tasknator.Entities;
using Tasknator.Helper;


namespace Tasknator.Routing
{
    public class TaskRoute
    {
        public async static Task<List<TaskEntity>> GetTasks(AppDbContext db) {
            return await db.TaskEntity.ToListAsync();
        }
    }
}
