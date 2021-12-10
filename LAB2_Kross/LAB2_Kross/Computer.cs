using System;
using System.Xml.Serialization;

namespace LAB2_Kross
{
    [Serializable]
    public class Computer
    {
        
        public Computer()
        {
            Name = String.Empty;
            RAM_Count = 0;
            GPU_Name = String.Empty;
            CPU_Name = String.Empty;
        }
        public Computer(string name, int ramCount, string gpuName, string cpuName)
        {
            Name = name;
            RAM_Count = ramCount;
            GPU_Name = gpuName;
            CPU_Name = cpuName;
        }
        [XmlElement("COMPUTER")]
        public System.String Name { get; set; }
        public System.Int32 RAM_Count { get; set; }
        public System.String GPU_Name { get; set; }
        public System.String CPU_Name { get; set; }

      
    }
}