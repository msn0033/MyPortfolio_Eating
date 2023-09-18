using Core;
using Core.Entites;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Seeding
{
    public class Seed
    {
        private readonly Context contex;

        public Seed(Context contex)
        {
            this.contex = contex;
        }
        public static List<Owner> LoadOwner()
        {
            var list = new List<Owner>()
            {
                new Owner{FName="Murad",LName="Salem",Avatar="mu.jpg",Profil=" i have Car"}
            };
            return list;
        }

        public static List<Address> LoadAddress()
        {
            

            var list = new List<Address>()
            {
                new Address{Street="Road Madina", City="jeddah",MainAddress=true,ContactId=null}
            };
            return list;
        }
    }
}
