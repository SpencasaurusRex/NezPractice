using Nez;

namespace NezPractice.Components
{
    public class Card : Component
    {

        public CardSelected Selected;
        public CardLocation Location;
        public int Index;
    }

    public enum CardSelected
    {
        None,
        Left,
        Right
    }

    public enum CardLocation
    {
        Deck,
        Slot
    }
}
