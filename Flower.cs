using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project
{
    public class Flower
    {
        
        private string FlowerName;
        private string FlowerDescription;
        
        //get method created
        public string GetFlowerName()
        {
            return FlowerName;
        }
        public string GetFlowerDescription()
        {
            return FlowerDescription;
        }
        
        //set method created 
        public void SetFlowerName(string value)
        {
            FlowerName = value;
        }
        public void SetFlowerDescription(string value)
        {
            FlowerDescription = value;
        }
    }
}