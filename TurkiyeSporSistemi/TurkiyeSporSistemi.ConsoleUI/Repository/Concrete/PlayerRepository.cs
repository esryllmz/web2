using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkiyeSporSistemi.ConsoleUI.Models;
using TurkiyeSporSistemi.ConsoleUI.Repository.Abstarcts;

namespace TurkiyeSporSistemi.ConsoleUI.Repository.Concrete
{
    public class PlayerRepository : IRepository<Player, int>
    {
        public Player Add(Player created)
        {
            BaseRepository.Players.Add(created);
            return created;
        }

        public Player? Delete(int id)
        {
            Player player = GetById(id);

            BaseRepository.Players.Remove(player);
            return player;
        }

        List<Player> IRepository<Player, int>.GetAll()
        {
            return BaseRepository.Players;
        }

        public Player? GetById(int id)
        {
           Player? player=BaseRepository
                .Players
                .SingleOrDefault(p => p.Id == id);

            if (player is null)
            {
                throw new Exception($"Aradığınız Id ye göre oyuncu bulunamadı : {id}");
            }
            return player;

        }

        public Player? Update(int id, Player entity)
        {
            Player? player = GetById(id);
            int index=BaseRepository.Players.IndexOf(player);
           
            BaseRepository.Players.Remove(player);
            BaseRepository .Players.Insert(index, entity);
            BaseRepository.Players.ForEach(x => Console.WriteLine(x));

            return player;
        }

      
    }
}
