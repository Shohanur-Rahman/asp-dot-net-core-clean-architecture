using App.Application.IRepositories;
using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
    public class TestRepository: ITestRepository
    {
        public List<Test> tests;
        public TestRepository() {
            tests = Enumerable.Range(1, 30).Select(x => new Test
            {
                Id = x,
                Name = $"Test {x}"
            }).ToList();
        }

        public List<Test> GetAllTests()
        {
            return tests;
        }
    }
}
