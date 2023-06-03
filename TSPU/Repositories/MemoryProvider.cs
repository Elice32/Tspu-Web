using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public class MemoryProvider
    {
        public List<dbProducts> product { get; set; } = new List<dbProducts>();
    }
}
