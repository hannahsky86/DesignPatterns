using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePatternExample1
{
    public class PrototypeBaby
    {
        public Dimentions Dimentions;
        public string Name;
        public string eyeColor;
        public IdInfo IdInfo;

        public PrototypeBaby ShallowCopy()
        {
            return (PrototypeBaby)this.MemberwiseClone();
        }

        public PrototypeBaby DeepCopy()
        {
            PrototypeBaby clone = (PrototypeBaby)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Dimentions = new Dimentions(Dimentions.height, Dimentions.weight);
            clone.eyeColor = String.Copy(eyeColor);
            clone.Name = String.Copy(Name);
            return clone;
        }
    }
}
