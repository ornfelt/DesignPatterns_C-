using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Testing
{
    class Fighter
    {
        public int Health = 100;
        public string Name;
        private Move _move;

        public string MoveName
        {
            get
            {
                return _move.Name;
            }
        }
        public int MoveDamage
        {
            get
            {
                return _move.Damage;
            }
        }

        public Fighter(string name, Move defaultMove)
        {
            Name = name;
            _move = defaultMove;
        }

        public void Attack(Fighter defendant)
        {
            if (_move != null)
                _move.Attack(defendant);
        }

        public void SetMove(Move move)
        {
            if (move != null)
                _move = move;
        }
    }
}
