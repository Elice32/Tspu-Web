using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public class MemoryProvider
    {
        public List<User> Users { get; set; } = new List<User>();
    }
}
