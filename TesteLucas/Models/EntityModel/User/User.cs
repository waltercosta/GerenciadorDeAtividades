using System.Collections.Generic;
using TesteLucas.Models.EntityModel.Tasks;

namespace TesteLucas.Models.EntityModel.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Task> TaskList { get; set; }
    }
}