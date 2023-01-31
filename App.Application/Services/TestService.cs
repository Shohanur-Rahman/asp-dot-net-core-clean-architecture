using App.Application.IRepositories;
using App.Application.Services.Interfaces;
using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;
        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public List<Test> GetAllTests()
        {
            return _testRepository.GetAllTests();
        }
    }
}
