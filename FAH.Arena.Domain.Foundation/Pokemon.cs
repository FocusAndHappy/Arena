using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAH.Arena.Domain.Foundation
{
    public class Pokemon
    {
        private int _level;

        private string _nickname;

        private 

        public Pokemon() { }

        public int Id { get; }

        public string Name { get; }

        public string Description { get; }

        public float Height { get; }

        public float Weight { get; }

        public float GenderRatio { get; }

        public int BaseFriendship { get; }
    }
}
