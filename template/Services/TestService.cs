using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lomo_Template.Dao;
using Lomo_Template.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Lomo_Template.Services
{
    public class TestService : BaseServices, ITestService
    {
        private readonly TestDao _dao;
        public TestService(IConfiguration config) : base(config)
        {
            _dao = new TestDao(GetConnectionString());
        }
        public List<object> GetPerson()
        {
            return _dao.GetPerson();
        }
        //new
        public List <object> GetPeopleAdress()
        {
            return _dao.GetPeopleAdress();
        }
        //new
        public List <object> GetAdressPeople()
        {
            return _dao.GetAdressPeople();
        }
        //new
        public List <object> GetOnlyAddress()
        {
            return _dao.GetOnlyAddress();
        }
        //new
        public List<object> GetAdress()
        {
            return _dao.GetAdress();
        }
        //new
        public int CreateAddress(object test)
        {
            return _dao.CreateAddress(test);
        }
        public int CreatePerson(object test)
        {
            return _dao.CreatePerson(test);
        }
        public object GetPersonById(int id)
        {
            return _dao.GetTestById(id);
        }
    }
}
