using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defense
{
    public class Tower
    {
        public int ShotSpeed, Damage;

        public Tower(int _ShotSpeed, int _Damage)
        {
            ShotSpeed = _ShotSpeed;
            Damage = _Damage;
        }
    }
    
}
