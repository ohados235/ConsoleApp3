using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Game
    {
        string gameName;
        int numPlayers;
        bool isWater;

        public Game(string gameName,int numPlayers,bool isWater)
        {
            this.gameName = gameName;
            this.numPlayers = numPlayers;
            this.isWater = isWater;
        }
     
        public void SetGN(string gn)
        {
            this.gameName=gn;

        }
        public void SetNP(int np)
        {
            this.numPlayers = np;

        }
        public void SetN(bool n) 
        {
        this.isWater=n;
        }

        public string GetGN()
        {
            return this.gameName;
        }
        public int NP()
        {
            return this.numPlayers;
        }

        public bool IsWater()
        {
            return this.isWater;
        }

    }




   
   
}
