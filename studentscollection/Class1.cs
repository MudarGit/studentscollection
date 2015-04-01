using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentscollection
{
    // Student acheivement exercise for .net class
    public class Students
    {
        public int studentLevel = 0;
        public Rank studentRank = Rank.Beginner;
        public int Level = 0;
        public int PeerLevel = 0;
        public int TotalPeer = 0;
        public int TotalProgram = 0;


        public void Student()
        {
            this.studentLevel = 0;
            this.studentRank = Rank.Beginner;
            this.Level = 0;
            this.PeerLevel = 0;
            this.TotalPeer = 0;
            this.TotalProgram = 0;

        }

        public void CompleteProgram()
        {
            Level += 1;
            studentLevel += 1;
            if (studentLevel >= 5)
            {
                studentRank = studentRank + 1;
                studentLevel = studentLevel - 5;
            }

        }

        public void HelpAPeer()
        {
            PeerLevel += 1;
            studentLevel += 2;
            if (studentLevel >= 5)
            {
                studentRank = studentRank + 1;
                studentLevel = studentLevel - 5;
            }

        }
        public void Totals()
        {
            TotalProgram = Level;
            TotalPeer = PeerLevel;
        }        
               
    }



    public enum Rank
    {
        Beginner,
        Grasshopper,
        Journeyman,
        RockStar,
        Ninja,
        Jedi
    }

}
