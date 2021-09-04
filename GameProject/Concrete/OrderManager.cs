using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void CampaignOrder(Campaign campaign, Game game, Gamer gamer)
        {
            decimal indirimOranı = game.Price - (game.Price * campaign.Discount);
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" "+campaign.CampaignName+" kampanyasi ile "+game.GameName+" oyununu "+indirimOranı+" TL' ye satın aldınız.");
        }

        public void Order(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.GameName + " oyununu "  +game.Price+ " TL' ye satın aldınız.");
        }
    }
}
