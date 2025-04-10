using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnit
{
    public class SettlerUnit : Unit
    {
        //override do cost para 5
        public override float Cost => 5;
        public SettlerUnit() : base (1, 3)
        {
            
        }
        
    } 



}
