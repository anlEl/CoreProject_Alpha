using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public struct EnumX
    {
        public int Value { get; set; }

        public static implicit operator EnumX(int value) { return new EnumX { Value = value }; }
        public static implicit operator int(EnumX value) { return value.Value; }
    }
}
