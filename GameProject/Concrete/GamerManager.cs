using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
        
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService _gamerCheckService)
        {
            this._gamerCheckService = _gamerCheckService;
        }
        public void Add(Gamer gamer)
        {


            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu sisteme eklendi: "+gamer.FirstName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi: " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer) )
            {
                Console.WriteLine("Oyuncu sisteme eklendi: " + gamer.FirstName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
