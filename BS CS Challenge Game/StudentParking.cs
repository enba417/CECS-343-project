﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class StudentParking : CardInterface
    {
        string thisImage;
        public StudentParking()
        {
            thisImage = "Student Parking";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 2)
            {
                p.addCChip(1);
                p.setCurrentRoom(20);
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
