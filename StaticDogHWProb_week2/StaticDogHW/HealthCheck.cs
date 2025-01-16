using System;
using System.Collections.Generic;
using System.Text;

namespace StaticDogHW
{
    internal static class HealthCheck
    {
        public static bool IsHealthy(Dog dog)
        {
            float health = dog.Weight/dog.Height;
            if (health > 2)
            {
                return false;
            }
            else 
            {
                return true; 
            }
        }
    }
}
