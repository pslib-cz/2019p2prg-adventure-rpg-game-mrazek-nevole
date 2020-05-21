using WebApplication1.Models;
using WebApplication1.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1
{
    public class LocationProvider : ILocationProvider
    {
        private Dictionary<Room, ILocation> _locations;
        private List<Connection> _map;

        public LocationProvider()
        {
            _locations = new Dictionary<Room, ILocation>();
            _map = new List<Connection>();

            _locations.Add(Room.Zacatek, new Location { ID = 0, Title = "Zacatek", Description = "Jsi v první místnosti" });
            _locations.Add(Room.Zluta, new Location { ID = 1, Title = "Zluta", Description = "Jsi ve Žluté místonosti" });
            _locations.Add(Room.Modra, new Location { ID = 2, Title = "Modra", Description = "Modra" });
            _locations.Add(Room.Ruzova, new Location { ID = 3, Title = "Ruzova", Description = "Ruzova" });
            _locations.Add(Room.Cervena, new Location { ID = 4, Title = "Cervena", Description = "Cervena" });
            _locations.Add(Room.Oranzova, new Location { ID = 5, Title = "Oranzova", Description = "Oranzova" });
            _locations.Add(Room.Fialova, new Location { ID = 6, Title = "Fialova", Description = "Fialova" });
            _locations.Add(Room.Zelena, new Location { ID = 7, Title = "Zelena", Description = "Zelena" });
            _locations.Add(Room.zluta2, new Location { ID = 8, Title = "Zluta", Description = "Zluta" });
            _locations.Add(Room.cervena2, new Location { ID = 9, Title = "Cervena", Description = "Cervena" });
            _locations.Add(Room.Seda, new Location { ID = 10, Title = "Seda", Description = "Seda" });
            _locations.Add(Room.oranzova2, new Location { ID = 11, Title = "Oranzova", Description = "Oranzova" });
            _locations.Add(Room.ruzova2, new Location { ID = 12, Title = "Ruzova", Description = "Ruzova" });
            _locations.Add(Room.modra2, new Location { ID = 13, Title = "Modra", Description = "Modra" });
            _locations.Add(Room.Svetlemodra, new Location { ID = 14, Title = "Vetle Modra", Description = "Svetle Modra" });
            _locations.Add(Room.fialova2, new Location { ID = 15, Title = "Fialova", Description = "Fialova" });
            _locations.Add(Room.Oranzova_, new Location { ID = 16, Title = "Oranzova", Description = "Oranzova" });
            _locations.Add(Room.Hneda, new Location { ID = 17, Title = "Hneda", Description = "Hneda" });
            _locations.Add(Room.Fialova_, new Location { ID = 18, Title = "Fialova", Description = "Fialova" });
            _locations.Add(Room.zelena2, new Location { ID = 19, Title = "Zelena", Description = "Zelena" });
            _locations.Add(Room.cil, new Location { ID = 20, Title = "cíl", Description = "Zelena" });
            _locations.Add(Room.zelena_, new Location { ID = 21, Title = "Zelena", Description = "Zelena" });



            _map.Add(new Connection(Room.Zacatek, Room.Zluta, "Zluta"));

            _map.Add(new Connection(Room.Zluta, Room.Modra, "Modra"));
            _map.Add(new Connection(Room.Zluta, Room.Ruzova, "Ruzova"));
            _map.Add(new Connection(Room.Zluta, Room.Cervena, "Cervena"));
            _map.Add(new Connection(Room.Zluta, Room.Zacatek, "Zacatek"));

            _map.Add(new Connection(Room.Modra, Room.Oranzova, "Oranzova"));
            _map.Add(new Connection(Room.Modra, Room.Fialova, "Fialova"));
            _map.Add(new Connection(Room.Modra, Room.Zluta, "Zluta"));

            _map.Add(new Connection(Room.Ruzova, Room.Oranzova, "Oranzova"));
            _map.Add(new Connection(Room.Ruzova, Room.Seda, "Seda"));
            _map.Add(new Connection(Room.Ruzova, Room.Zluta, "Zluta"));
            _map.Add(new Connection(Room.Ruzova, Room.cervena2, "Cervena"));

            _map.Add(new Connection(Room.Oranzova, Room.Modra, "Modra"));
            _map.Add(new Connection(Room.Oranzova, Room.Ruzova, "Ruzova"));
            _map.Add(new Connection(Room.Oranzova, Room.Zelena, "Zelena"));

            _map.Add(new Connection(Room.Fialova, Room.Modra, "Modra"));

            _map.Add(new Connection(Room.Zelena, Room.oranzova2, "Oranzova"));
            _map.Add(new Connection(Room.Zelena, Room.Oranzova, "Oranzova"));
            _map.Add(new Connection(Room.Zelena, Room.ruzova2, "Ruzova"));

            _map.Add(new Connection(Room.ruzova2, Room.zluta2, "Zluta"));
            _map.Add(new Connection(Room.ruzova2, Room.Zelena, "Zelena"));

            _map.Add(new Connection(Room.oranzova2, Room.Zelena, "Zelena"));
            _map.Add(new Connection(Room.oranzova2, Room.zluta2, "Zluta"));

            _map.Add(new Connection(Room.zluta2, Room.oranzova2, "Oranzova"));
            _map.Add(new Connection(Room.zluta2, Room.ruzova2, "Ruzova"));
            _map.Add(new Connection(Room.zluta2, Room.Seda, "Seda"));
            _map.Add(new Connection(Room.zluta2, Room.modra2, "Modra"));

            _map.Add(new Connection(Room.modra2, Room.zluta2, "Zluta"));

            _map.Add(new Connection(Room.Seda, Room.Ruzova, "Ruzova"));
            _map.Add(new Connection(Room.Seda, Room.zluta2, "Zluta"));

            _map.Add(new Connection(Room.Cervena, Room.Zluta, "Zluta"));
            _map.Add(new Connection(Room.Cervena, Room.Oranzova_, "Oranzova"));

            _map.Add(new Connection(Room.cervena2, Room.Ruzova, "Ruzova"));
            _map.Add(new Connection(Room.cervena2, Room.Svetlemodra, "Světle Modrá"));

            _map.Add(new Connection(Room.Svetlemodra, Room.cervena2, "cervena"));
            _map.Add(new Connection(Room.Svetlemodra, Room.Oranzova_, "Oranzova"));
            _map.Add(new Connection(Room.Svetlemodra, Room.fialova2, "Fialova"));

            _map.Add(new Connection(Room.fialova2, Room.Svetlemodra, "Světle Modrá"));

            _map.Add(new Connection(Room.Oranzova_, Room.Cervena, "Cervena"));
            _map.Add(new Connection(Room.Oranzova_, Room.Svetlemodra, "Světle Modrá"));
            _map.Add(new Connection(Room.Oranzova_, Room.Hneda, "Hneda"));
            _map.Add(new Connection(Room.Oranzova_, Room.Fialova_, "Fialova"));

            _map.Add(new Connection(Room.Hneda, Room.Oranzova_, "Oranzova"));

            _map.Add(new Connection(Room.Fialova_, Room.zelena2, "Zelena"));
            _map.Add(new Connection(Room.Fialova_, Room.cil, "Zelena"));
            _map.Add(new Connection(Room.Fialova_, Room.zelena_, "Zelena"));
            _map.Add(new Connection(Room.Fialova_, Room.Oranzova_, "Oranzova"));

            _map.Add(new Connection(Room.zelena2, Room.Fialova_, "Fialova"));

            _map.Add(new Connection(Room.zelena_, Room.Fialova_, "Fialova"));
        }



        public bool ExistsLocation(Room id)
        {
            return _locations.ContainsKey(id);
        }

        public List<Connection> GetConnectionsFrom(Room id)
        {
            if (ExistsLocation(id))
            {
                return _map.Where(m => m.From == id).ToList();
            }
            throw new InvalidLocation();
        }

        public List<Connection> GetConnectionsTo(Room id)
        {
            throw new NotImplementedException();
        }

        public Location GetLocation(Room id)
        {
            if (ExistsLocation(id))
            {
                return (Location)_locations[id];
            }
            throw new InvalidLocation();
        }

        public bool IsNavigationLegitimate(Room from, Room to, GameState state)
        {
            throw new NotImplementedException();
        }
    }
}
