using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Classes;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(1, 0, "Haven", "The ancient Haven of Ubuntu island.", "/Engine;component/Images/Locations/Haven.jpg");
            newWorld.AddLocation(0, 0, "Marketplace", "The Center of Ubuntu island", "/Engine;component/Images/Locations/Marketplace.jpg");
            newWorld.AddLocation(0, -1, "Orchard", "An old Orchard filled with Apple trees.", "/Engine;component/Images/Locations/Orchard.jpg");
            newWorld.AddLocation(0, 1, "Herb garden", "An old herb garden.", "/Engine;component/Images/Locations/HerbGarden.jpg");
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.AddLocation(-1, 0, "Graveyard", "The graveyard of Ubuntu island.", "/Engine;component/Images/Locations/Cemetry.jpg");
            newWorld.AddLocation(-2, 0, "Crypt", "A Dark Crypt with a Grave in the center.", "/Engine;component/Images/Locations/Crypt.jpg");

            return newWorld;
        }
    }
}
