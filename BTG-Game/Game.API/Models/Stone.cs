using System.Collections.Generic;

namespace Game.API.Models
{
    public class Stone : IElement
    {
        public IEnumerable<IElement> WinsFrom => new List<IElement> { new Lizard(), new Scissors() };
    }
}
