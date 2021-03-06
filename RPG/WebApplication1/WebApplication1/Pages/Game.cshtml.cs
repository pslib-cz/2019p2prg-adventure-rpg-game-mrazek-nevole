using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;
namespace WebApplication1.Pages
{
    public class GameModel : PageModel
    {
        private GameService _gs;

        public GameModel(GameService gs)
        {
            _gs = gs;
        }

        public Location Location { get; set; }
        public int clickPercentage = 70;
        public GameState State { get; set; }
        public List<Connection> Targets { get; set; }
        public Random RandomGen = new Random();
        public void OnGet(Room id)
        {
            _gs.FetchData();

            _gs.State.Location = id;

            _gs.Store();
            Location = _gs.Location;
            Targets = _gs.Targets;
            State = _gs.State;
        }
    }
}