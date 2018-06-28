using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCollection.Models
{
    class Collection
    {
        private Card _card;
        private int _cardCount;
        private int _collectionId;

        public int CollectionId { get => _collectionId; set => _collectionId = value; }
        public Card Card { get => _card; set => _card = value; }
        public int CardCount { get => _cardCount; set => _cardCount = value; }

        public Collection() { }

        /**
         * Increment card count by one
         **/
        public void incrementCardCount(Collection collection)
        {
            collection.CardCount = collection.CardCount + 1;
        }
    }
}
