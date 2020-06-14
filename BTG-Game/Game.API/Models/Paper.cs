using System.Collections.Generic;

namespace Game.API.Models
{
    public class Paper : IElement
    {
        public IEnumerable<IElement> WinsFrom => new List<IElement> { new Stone(), new Spock() };
    }
}
