using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class GameObjectTypes
    {
        public class GameTypes
        {
            public static readonly EnumX MultiPlayer    = 0;
            public static readonly EnumX SinglePlayer   = 1;
        }
        public class UserTypes
        {
            public static readonly EnumX Player         = 2;
            public static readonly EnumX AI             = 3;
            public static readonly EnumX Spectator      = 4;
        }
        public class ObjectTypes
        {
            public static readonly EnumX Static         = 5;
            public static readonly EnumX Kinetic        = 6;
        }
    }
}
