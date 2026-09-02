using Microsoft.AspNetCore.Mvc;
using GameAchievementTracker.WebAPI.Models;

namespace GameAchievementTracker.WebAPI.Controllers
{
    [Route("api/gameswebapi")]
    [ApiController]
    public class GamesWebAPIController : ControllerBase
    {
        private static readonly List<Game> Games = new()
        {
            new Game
            {
                Id = 1,
                GameName = "God of War Ragnarök",
                Genre = "Action Adventure",
                HoursPlayed = 45.5,
                AchievementsEarned = 48,
                TotalAchievements = 48,
                IsCompleted = true
            },
            new Game
            {
                Id = 2,
                GameName = "Elden Ring",
                Genre = "Action RPG",
                HoursPlayed = 72.0,
                AchievementsEarned = 32,
                TotalAchievements = 42,
                IsCompleted = false
            },
            new Game
            {
                Id = 3,
                GameName = "Minecraft",
                Genre = "Sandbox",
                HoursPlayed = 120.5,
                AchievementsEarned = 75,
                TotalAchievements = 100,
                IsCompleted = false
            }
        };

        // GET: api/gameswebapi
        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetGames()
        {
            return Ok(Games);
        }

        // GET: api/gameswebapi/{id}
        [HttpGet("{id}")]
        public ActionResult<Game> GetGame(int id)
        {
            var game = Games.FirstOrDefault(g => g.Id == id);

            if (game == null)
            {
                return NotFound();
            }

            return Ok(game);
        }

        // POST: api/gameswebapi
        [HttpPost]
        public ActionResult<Game> CreateGame(Game game)
        {
            if (game == null)
            {
                return BadRequest();
            }

            game.Id = Games.Count > 0
                ? Games.Max(g => g.Id) + 1
                : 1;

            Games.Add(game);

            return CreatedAtAction(
                nameof(GetGame),
                new { id = game.Id },
                game
            );
        }

        // PUT: api/gameswebapi/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateGame(int id, Game updatedGame)
        {
            if (updatedGame == null)
            {
                return BadRequest();
            }

            if (id != updatedGame.Id)
            {
                return BadRequest("The ID in the URL does not match the ID in the request body.");
            }

            var game = Games.FirstOrDefault(g => g.Id == id);

            if (game == null)
            {
                return NotFound();
            }

            game.GameName = updatedGame.GameName;
            game.Genre = updatedGame.Genre;
            game.HoursPlayed = updatedGame.HoursPlayed;
            game.AchievementsEarned = updatedGame.AchievementsEarned;
            game.TotalAchievements = updatedGame.TotalAchievements;
            game.IsCompleted = updatedGame.IsCompleted;

            return NoContent();
        }

        // DELETE: api/gameswebapi/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteGame(int id)
        {
            var game = Games.FirstOrDefault(g => g.Id == id);

            if (game == null)
            {
                return NotFound();
            }

            Games.Remove(game);

            return NoContent();
        }
    }
}