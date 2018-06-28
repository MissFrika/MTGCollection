using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCollection.Models
{
    class Set
    {
        private int _setId;
        private string _setName;
        private string _setBlock;
        private int _setYear;

        public int SetId { get => _setId; set => _setId = value; }
        public string SetName { get => _setName; set => _setName = value; }
        public string SetBlock { get => _setBlock; set => _setBlock = value; }
        public int SetYear { get => _setYear; set => _setYear = value; }

        public Set()
        {

        }

        public Set(int id, string name, string block , int year)
        {
            _setId = id;
            _setName = name;
            _setBlock = block;
            _setYear = year;
        }
    }
}
