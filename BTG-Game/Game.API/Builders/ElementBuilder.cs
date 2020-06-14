using Game.API.Models;
using System;

namespace Game.API.Builders
{
    public class ElementBuilder
    {
        public IElement BuildElementByName(string elementName)
        {
            switch (elementName)
            {
                case "pedra":
                    return new Stone();
                case "papel":
                    return new Paper();
                case "tesoura":
                    return new Scissors();
                case "spock":
                    return new Spock();
                case "lagarto":
                    return new Lizard();
                default:
                    throw new ArgumentException("O elemento informado é inválido.");
            }
        }
    }
}
