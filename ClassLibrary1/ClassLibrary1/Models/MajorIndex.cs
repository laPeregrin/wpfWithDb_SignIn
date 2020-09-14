using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public enum MajorIndexType
    {
        DownJones,
        Nasdaq,
        SP500
    }
    public class MajorIndex
    {
        public double Prise { get; set; }
        public double Changes { get; set; }
        public MajorIndexType Type { get; set; }
    }
}
