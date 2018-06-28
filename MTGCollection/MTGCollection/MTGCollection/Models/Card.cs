using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MTGCollection.Models
{
    class Card
    {
        private int _cardId;
        private string _cardName;
        private string _cardColor;
        private int _cardManaCost;
        private List<Mana> _cardMana;
        private string _cardType;
        private Image _image;

        public int CardId { get => _cardId; set => _cardId = value; }
        public string CardName { get => _cardName; set => _cardName = value; }
        public string CardColor { get => _cardColor; set => _cardColor = value; }
        public int CardManaCost { get => _cardManaCost; set => _cardManaCost = value; }
        public List<Mana> CardMana { get => _cardMana; set => _cardMana = value; }
        public string CardType { get => _cardType; set => _cardType = value; }
        public Image CardImage { get => _image; set => _image = value; }
    }
}
