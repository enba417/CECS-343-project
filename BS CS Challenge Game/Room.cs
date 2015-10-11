﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
namespace BS_CS_Challenge_Game
{
    class Room
    {
        private String name;
        private Button button1;
        private Button button2;
        private Button button3;
        private LinkedList<int> nextTo;
        public Room(String n, Button b1, Button b2, Button b3)
        {
            name = n;
            button1 = b1;
            button2 = b2;
            button3 = b3;
            nextTo = new LinkedList<int>();
        }
        public String getRoomName()
        {
            return name;
        }

        public void addNextTo(int  r)
        {
            nextTo.AddLast(r);
        }
        public LinkedList<int> getNextTo()
        {
            return nextTo;
        }
        public void MoveTo(String playerName)
        {
            if (button1.Visible.Equals(false))
            {
                button1.Name = playerName;
                button1.Visible = true;
            }
            else if (button2.Visible.Equals(false))
            {
                button1.Name = playerName;
                button1.Visible = true;
            }
            else if (button3.Visible.Equals(false))
            {
                button3.Name = playerName;
                button3.Visible = true;
            }
        }
        public void MoveOut(String playerName)
        {
            if (button1.Name.Equals(playerName))
                button1.Visible = false;
            else if (button2.Name.Equals(playerName))
                button1.Visible = false;
            else if (button3.Name.Equals(playerName))
                button1.Visible = false;
        }
    }
}
