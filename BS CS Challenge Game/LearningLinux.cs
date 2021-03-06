﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class LearningLinux : CardInterface
    {
        string thisImage;
        public LearningLinux()
        {
            thisImage = "Learning Linux";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 11 && p.getIChip() > 2 && p.getCChip() > 1)
            {
                p.addQPoint(3);
                choseChip chose = new choseChip(1, 1, 1, p);
                p.addChipChosen(chose.getChoice());
                return (p.getPlayerName() + " played " + thisImage + " for 3 Quality Points and " + chose.getChoice());
            }
            p.addQPoint(-1);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
