using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CustomModels
{
    public class SettingsStateWithCountry
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public bool? StateActive { get; set; }
        public string CountryName { get; set; }
    }
}
