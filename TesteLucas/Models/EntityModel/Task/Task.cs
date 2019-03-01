using System;
using TesteLucas.Models.EntityModel.Users;

namespace TesteLucas.Models.EntityModel.Tasks
{
    public class Task
    {
        public int IdTask { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
    }
}