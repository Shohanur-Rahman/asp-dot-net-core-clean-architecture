using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services.Interfaces
{
    public interface ITestService
    {
        List<Test> GetAllTests();
    }
}
