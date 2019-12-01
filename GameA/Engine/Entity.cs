using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameA.Engine
{
    class Entity
    {
        public string Name { get; set; }

        public Sprite sprite;

        public Entity(string name)
        {
            this.Name = name;
        }
    }
}
