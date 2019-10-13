using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Tests
{
    class TestParentTasksDbSet : TestDbSet<ParentTask>
    {
        public override ParentTask Find(params object[] keyValues)
        {
            return this.SingleOrDefault(task => task.Parent_Id == (int)keyValues.Single());
        }
    }
}
