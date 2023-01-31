using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.IRepositories
{
    public interface ITestRepository
    {
        List<Test> GetAllTests();
    }
}
