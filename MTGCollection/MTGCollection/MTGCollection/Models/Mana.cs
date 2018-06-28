using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MTGCollection.Models
{
    class Mana
    {
        private int _manaId;
        private string _manaType;
        private Image _manaIcon;

        public int ManaId { get => _manaId; set => _manaId = value; }
        public string ManaType { get => _manaType; set => _manaType = value; }
        public Image ManaIcon { get => _manaIcon; set => _manaIcon = value; }
    }
}
