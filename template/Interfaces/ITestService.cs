using System.Collections.Generic;


namespace Lomo_Template.Interfaces
{
    public interface ITestService
    {
        int CreatePerson(object test);
        //new
        List<object> GetPeopleAdress();
        //new
        List<object> GetAdressPeople();
        //new
        List<object> GetOnlyAddress();
        List<object> GetPerson();
        //new
        List<object> GetAdress();
        //new
        int CreateAddress(object test);
        object GetPersonById(int id);

    }
}