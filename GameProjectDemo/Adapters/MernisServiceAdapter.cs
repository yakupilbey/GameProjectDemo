using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameProjectDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;


          
        }
    }
}
