﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class LunchatBratwurstHall : CardInterface
    {
        string thisImage;
        public LunchatBratwurstHall()
        {
            thisImage = "Lunch at Bratwurst Hall";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 17)
            {
                p.addCChip(1);
                return (p.getPlayerName() + " played " + thisImage + " for 1 craft chip");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
