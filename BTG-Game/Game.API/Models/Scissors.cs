using System.Collections.Generic;

namespace Game.API.Models
{
    public class Scissors : IElement
    {
        public IEnumerable<IElement> WinsFrom => new List<IElement> { new Paper(), new Lizard() };
    }
}
