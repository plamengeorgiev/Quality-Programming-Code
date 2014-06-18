using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen;

namespace Kitchen
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);
            if (potato != null)
            {
                if (potato.IsPeeled && potato.IsNotRotten)
                {
                    Cook(potato);
                }
            }
            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);
            Bowl bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }



        private void Peel(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }
        public Potato GetPotato()
        {
            throw new NotImplementedException();
        }
        public Carrot GetCarrot()
        {
            throw new NotImplementedException();
        }
        public Bowl GetBowl()
        {
            throw new NotImplementedException();
        }
        private void Cut(Vegetable potato)
        {
            throw new NotImplementedException();
        }

        private void Cook(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }
    }

}
