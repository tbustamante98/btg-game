using System.Collections.Generic;

namespace Game.API.Models
{
    public interface IElement
    {
        IEnumerable<IElement> WinsFrom { get; }
    }
}
