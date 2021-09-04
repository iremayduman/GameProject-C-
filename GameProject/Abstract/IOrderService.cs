using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void Order(Game game, Gamer gamer);
        void CampaignOrder(Campaign campaign, Game game, Gamer gamer);
    }
}
