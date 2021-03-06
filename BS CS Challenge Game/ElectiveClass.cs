﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ElectiveClass : CardInterface
    {
        string thisImage;
        public ElectiveClass()
        {
            thisImage = "Elective Class";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 7 && p.getLChip() > 1)
            {
                p.addLChip(1);
                p.addExtraCard();
                return (p.getPlayerName() + " played " + thisImage + " for 1 learning chip and 1 game card");
            }
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
