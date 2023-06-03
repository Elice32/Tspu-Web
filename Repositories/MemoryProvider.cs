using TspuWeb.Contracts;
using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public class MemoryProvider
    {
        public List<DbUser> Users { get; set; } = new List<DbUser>();
    }
}
