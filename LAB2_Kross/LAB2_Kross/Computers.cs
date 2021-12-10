using System;
using System.Collections.ObjectModel;

namespace LAB2_Kross
{
    [Serializable]
    public class Computers
    {
        public Computers()
        {
            Computerss = new ObservableCollection<Computer>();
        }
        public Computers(ObservableCollection<Computer> computerss)
        {
            Computerss = computerss;
        }
        public ObservableCollection<Computer> Computerss { get; set; }
    }
}