using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    class ConsoleBubble : IComparable<ConsoleBubble>
    {
        int age;
        float weight;
        string name;
        public ConsoleBubble()
        {
            age = 0;
            name = "unknown";
        }

        public ConsoleBubble(string name, float weight, int age)
        {
            this.age = age;
            this.name = name;
            this.weight = weight;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int CompareTo(ConsoleBubble other)
        {
            return age.CompareTo(other.age);
        }

        public static bool operator <(ConsoleBubble C1, ConsoleBubble C2)
        {
            return (C1.age < C2.age);
        }
        public static bool operator >(ConsoleBubble C1, ConsoleBubble C2)
        {
            return (C1.age < C2.age);
        }
        public static bool operator ==(ConsoleBubble C1, ConsoleBubble C2)
        {
            return (C1.age < C2.age);
        }
        public static bool operator !=(ConsoleBubble C1, ConsoleBubble C2)
        {
            return (C1.age < C2.age);
        }
        public static bool operator <=(ConsoleBubble C1, ConsoleBubble C2)
        {
            return (C1.age < C2.age);
        }
        public static bool operator >=(ConsoleBubble C1, ConsoleBubble C2)
        {
            return (C1.age < C2.age);
        }
    }
}
