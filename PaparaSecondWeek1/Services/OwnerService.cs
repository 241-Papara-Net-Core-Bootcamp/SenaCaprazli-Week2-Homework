using PaparaSecondWeek1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Services
{
    public class OwnerService : IOwnerService
    {


        //public void Add()
        //{
        //    throw new System.Exception("implement edilmedi");
        //}

        //public void Delete()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Get()
        //{
        //    throw new NotImplementedException("owner işlemi için get  yazılmadı");
        //}
        public string Add()
        {
            return "Owner eklendi";
        }

        public bool Delete()
        {
            return true;
        }

        public string Get()
        {

            return "ownerlar getirildi";
        }

        public string GetColorEnum()
        {

            var stringBuilder = new StringBuilder();
            foreach (var color in Enum.GetNames(typeof(ColorEnum)))
            {
                stringBuilder.Append(color + "|");
            }
            return stringBuilder.ToString();
        }


    }
}
