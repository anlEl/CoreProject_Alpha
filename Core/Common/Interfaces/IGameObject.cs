using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal interface IGameObject
    {
        long                ID          { get; }
        EnumX               Type        { get; }
        //IGameObjectBehavior Behavior    { get; }
		string				ColorCode	{ get; }
		string				ImagePath	{ get; }
    }
}
