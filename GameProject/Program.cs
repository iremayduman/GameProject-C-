using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer = new Gamer()
            {
                Id = 1,
                FirstName = "İrem",
                LastName = "Ayduman",
                DateOfBirth = new DateTime(444, 3, 5),
                NationalityId = "444444"
            };
            
            gamerManager.Add(gamer);
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { Id = 1, Discount = 0.80M, CampaignName = " %80 indirim" };
            campaignManager.Add(campaign);
            GameManager gameManager = new GameManager();
            Game game = new Game() { Id = 2, GameName = " Gta V5", Price = 200 };
            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Update(game);
            OrderManager orderManager = new OrderManager();
            orderManager.CampaignOrder(campaign, game, gamer);
            orderManager.Order(game, gamer);
        }
    }
}
