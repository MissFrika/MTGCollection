using System;
using System.Collections.Generic;
using System.Text;
using MTGCollection.Models;

namespace MTGCollection.ViewModels
{
    class CardDetailViewModel : BaseViewModel
    {
    public Card Card { get; set; }

        public CardDetailViewModel(Card card = null)
        {
            Title = card?.CardName;
            Card = card;
        }
    }
}
