using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Random_Object_Generation.Data
{
    public abstract class RandomObject
    {
        protected int Count;
        public bool IsEnable;
        public double PreferredPercentage;

        private static int TotalGenerated;
        private static int TotalRandomObjects;
        public string LastGeneratedObject;
        public abstract bool GenerateNext();

        public string Type = string.Empty;
        public RandomObject(double PreferredPercentage)
        {
            Count = 0;
            TotalGenerated = 0;
            IsEnable = true;
            this.PreferredPercentage = PreferredPercentage;
            LastGeneratedObject = null;
            TotalRandomObjects++;
        }
        protected bool HasCrossedLimit()
        {
            double currentPercentage = GetCurrentPercentage();
            return currentPercentage > PreferredPercentage;
        }

        protected void Icrement()
        {
            Count++;
            TotalGenerated++;
        }
        public int GetTotalObjectGeneratedCount()
        {
            return TotalGenerated;
        }
        public int GetThisObjectGeneratedCount()
        {
            return Count;
        }

        public double GetCurrentPercentage()
        {
            return Count * 100.0 / (TotalGenerated + TotalRandomObjects);
        }
    }
}
