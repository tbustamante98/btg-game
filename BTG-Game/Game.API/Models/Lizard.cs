using System.Collections.Generic;

namespace Game.API.Models
{
    public class Lizard : IElement
    {
        public IEnumerable<IElement> WinsFrom => new List<IElement> { new Spock(), new Paper() };
    }
}
