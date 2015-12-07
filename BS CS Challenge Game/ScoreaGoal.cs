﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ScoreaGoal : CardInterface
    {
        string thisImage;
        public ScoreaGoal()
        {
            thisImage = "Score a Goal";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 0 && p.getCChip() > 2)
            {
                p.addQPoint(5);
                p.addIChip(1);
                return (p.getPlayerName() + " played " + thisImage + " for 5 Quality Points and 1 integrity chip");
            }
            p.setCurrentRoom(2);
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
