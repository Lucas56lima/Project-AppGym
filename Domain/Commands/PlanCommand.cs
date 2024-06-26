using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public class PlanCommand
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Double Value { get; set; }
        public required int Duration { get; set; }
        public bool Active = true;

    }
}