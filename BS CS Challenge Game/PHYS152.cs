﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class PHYS152 : CardInterface
    {
        private string thisImage;

        public PHYS152()
        {
            thisImage = "PHYS152";
        }

        public override string getImage()
        {
            return thisImage;
        }

        public override string Play(Player p)
        {
            /*if (p.getCurrentRoom() == 14)
            {
                p.addLChip(1);
                return (p.getPlayerName() + " played Professor Murgolo's CECS 174 Class for 1 learning chip");
            }*/
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}