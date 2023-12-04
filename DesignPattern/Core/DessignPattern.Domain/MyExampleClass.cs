using DessignPattern.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPattern.Domain
{
    public class MyExampleClass
    {
        private readonly IConfigurationService _configurationService;

        public MyExampleClass(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
            
            var myConnectionString = _configurationService.GetValue("Seq:ServerURL");
            
            Console.WriteLine(myConnectionString);
        }
    }
       
 }

    

