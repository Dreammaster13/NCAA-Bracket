using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCAABrackets
{
    class Program
    {
        public static List<Team>SouthRegion = new List<Team>();
        public static List<Team> WestRegion = new List<Team>();
        public static List<Team> EastRegion = new List<Team>();
        public static List<Team> MidwestRegion = new List<Team>();

        public class Team
        {
            public string TeamName { get; set; }
            public int Region { get; set; }
            public int Rank { get; set; }

            public Team(string t, int r, int r2)
            {
                TeamName = t;
                Region = r;
                Rank = r2;
            }

            public override string ToString()
            {
                return TeamName;
            }
        }

        public static void setTeams()
        {
            //South Regional
            //SouthRegion.Add(new Team("", 1));
            SouthRegion.Add(new Team("Kansas", 1, 1));
            SouthRegion.Add(new Team("Georgetown", 1, 2));
            SouthRegion.Add(new Team("Florida", 1, 3));
            SouthRegion.Add(new Team("Michigan", 1, 4));
            SouthRegion.Add(new Team("VCU", 1, 5));
            SouthRegion.Add(new Team("UCLA", 1, 6));
            SouthRegion.Add(new Team("San Diego State", 1, 7));
            SouthRegion.Add(new Team("North Carolina", 1, 8));
            SouthRegion.Add(new Team("Villanova", 1, 9));
            SouthRegion.Add(new Team("Oklahoma", 1, 10));
            SouthRegion.Add(new Team("Minnesota", 1, 11));
            SouthRegion.Add(new Team("Akron", 1, 12));
            SouthRegion.Add(new Team("South Dakota State", 1, 13));
            SouthRegion.Add(new Team("Northwestern State", 1, 14));
            SouthRegion.Add(new Team("Florida Gulf Coast", 1, 15));
            SouthRegion.Add(new Team("Western Kentucky", 1, 16));

            //West Regional
            //WestRegion.Add(new Team("", 2));
            WestRegion.Add(new Team("Gonzaga", 2, 1));
            WestRegion.Add(new Team("Ohio State", 2, 2));
            WestRegion.Add(new Team("New Mexico", 2, 3));
            WestRegion.Add(new Team("Kansas State", 2, 4));
            WestRegion.Add(new Team("Wisconsin", 2, 5));
            WestRegion.Add(new Team("Arizona", 2, 6));
            WestRegion.Add(new Team("Notre Dame", 2, 7));
            WestRegion.Add(new Team("Pittsburgh", 2, 8));
            WestRegion.Add(new Team("Wichita State", 2, 9));
            WestRegion.Add(new Team("Iowa State", 2, 10));
            WestRegion.Add(new Team("Belmont", 2, 11));
            WestRegion.Add(new Team("Mississippi", 2, 12));
            WestRegion.Add(new Team("La Salle", 2, 13));
            WestRegion.Add(new Team("Harvard", 2, 14));
            WestRegion.Add(new Team("Iona", 2, 15));
            WestRegion.Add(new Team("Southern", 2, 16));

            //East Regional
            //EastRegion.Add(new Team("", 3));
            EastRegion.Add(new Team("Indiana", 3, 1));
            EastRegion.Add(new Team("Miami", 3, 2));
            EastRegion.Add(new Team("Marquette", 3, 3));
            EastRegion.Add(new Team("Syracuse", 3, 4));
            EastRegion.Add(new Team("UNLV", 3, 5));
            EastRegion.Add(new Team("Butler", 3, 6));
            EastRegion.Add(new Team("Illinois", 3, 7));
            EastRegion.Add(new Team("NC State", 3, 8));
            EastRegion.Add(new Team("Temple", 3, 9));
            EastRegion.Add(new Team("Colorado", 3, 10));
            EastRegion.Add(new Team("Bucknell", 3, 11));
            EastRegion.Add(new Team("California", 3, 12));
            EastRegion.Add(new Team("Montana", 3, 13));
            EastRegion.Add(new Team("Davidson", 3, 14));
            EastRegion.Add(new Team("Pacific", 3, 15));
            EastRegion.Add(new Team("James Madison", 3, 16));


            //Midwest Regional
            //MidwestRegion.Add(new Team("", 4));
            MidwestRegion.Add(new Team("Louisville", 4, 1));
            MidwestRegion.Add(new Team("Duke", 4, 2));
            MidwestRegion.Add(new Team("Michigan State", 4, 3));
            MidwestRegion.Add(new Team("Saint Louis", 4, 4));
            MidwestRegion.Add(new Team("Oklahoma State", 4, 5));
            MidwestRegion.Add(new Team("Memphis", 4, 6));
            MidwestRegion.Add(new Team("Creighton", 4, 7));
            MidwestRegion.Add(new Team("Colorado State", 4, 8));
            MidwestRegion.Add(new Team("Missouri", 4, 9));
            MidwestRegion.Add(new Team("Cincinnati", 4, 10));
            MidwestRegion.Add(new Team("Saint Mary's (CA)", 4, 11));
            MidwestRegion.Add(new Team("Oregon", 4, 12));
            MidwestRegion.Add(new Team("New Mexico State", 4, 13));
            MidwestRegion.Add(new Team("Valparaiso", 4, 14));
            MidwestRegion.Add(new Team("Albany", 4, 15));
            MidwestRegion.Add(new Team("North Carolina A&T", 4, 16));
            
        }

        static void Main(string[] args)
        {
            //for (int i = 0; i < 256; i++)
                //Console.WriteLine(Convert.ToString(i, 2).PadLeft(8, '0') );

            //Console.Read();

            DateTime StartTime = DateTime.Now;
            DateTime EndTime = DateTime.MinValue;

            setTeams();
            string line = "";

            int iteration = 0;
            /*
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\bracket.txt", false))
            {
                //SOUTH
                for (int iSouth = 0; iSouth < 256; iSouth++)
                {
                    string sSouth = Convert.ToString(iSouth, 2);

                    int[] bitsSouth = sSouth.PadLeft(8, '0') // Add 0's from left
                             .Select(c => int.Parse(c.ToString())) // convert each char to int
                             .ToArray(); // Convert IEnumerable from select to Array

                    int[] SouthWinner = new int[] {
                        Convert.ToBoolean(bitsSouth[0] ? 16 : 1,
                        Convert.ToBoolean(bitsSouth[1] ? 15 : 2,
                        Convert.ToBoolean(bitsSouth[2] ? 14 : 3,
                        Convert.ToBoolean(bitsSouth[3] ? 13 : 4,
                        Convert.ToBoolean(bitsSouth[4] ? 12 : 5,
                        Convert.ToBoolean(bitsSouth[5] ? 11 : 6,
                        Convert.ToBoolean(bitsSouth[6] ? 10 : 7,
                        Convert.ToBoolean(bitsSouth[7] ? 9 : 8,
                    };

                    for (int SouthResults = 0; SouthResults < SouthWinner.Length; SouthResults++)
                    {
                        line += SouthRegion.Find(x => x.Rank == SouthWinner[SouthResults] + ", ";
                    }
                    file.WriteLine(line);


                    //WEST
                    for (int iWest = 0; iWest < 256; iWest++)
                    {
                        string sWest = Convert.ToString(iWest, 2);

                        int[] bitsWest = sWest.PadLeft(8, '0') // Add 0's from left
                                 .Select(c => int.Parse(c.ToString())) // convert each char to int
                                 .ToArray(); // Convert IEnumerable from select to Array

                        int[] WestWinner = new int[] {
                            Convert.ToBoolean(bitsWest[0] ? 16 : 1,
                            Convert.ToBoolean(bitsWest[1] ? 15 : 2,
                            Convert.ToBoolean(bitsWest[2] ? 14 : 3,
                            Convert.ToBoolean(bitsWest[3] ? 13 : 4,
                            Convert.ToBoolean(bitsWest[4] ? 12 : 5,
                            Convert.ToBoolean(bitsWest[5] ? 11 : 6,
                            Convert.ToBoolean(bitsWest[6] ? 10 : 7,
                            Convert.ToBoolean(bitsWest[7] ? 9 : 8,
                        };

                        for (int WestResults = 0; WestResults < WestWinner.Length; WestResults++)
                        {
                            line += WestRegion.Find(x => x.Rank == WestWinner[WestResults] + ", ";
                        }
                        file.WriteLine(line);
                        Console.WriteLine(iteration);
                        iteration++;

                    }

                }
            }*/


            string WINNING_LINE =
            "10111011" +
            "11000100" +
            "11110110" +
            "11110111";

            int WINNING_ITERATION = 0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\bracket2.txt", false))
            {
                /*
                //SOUTH - 2^8
                for (int iSouth = 0; iSouth < 256; iSouth++)
                {
                    //WEST - 2^16
                    for (int iWest = 0; iWest < 256; iWest++)
                    {
                        //EAST - 2^24
                        for (int iEast = 0; iEast < 256; iEast++)
                        {
                            //MIDWEST - 2^32
                            for (int iMidwest = 0; iMidwest < 256; iMidwest++)
                            {
                                
                                //Round of 32, 4 games per region, or 8 games per two regions added together, like i'm doing.
                                //SouthAndWest - 2^40
                                for (int iSouthAndWest = 0; iSouthAndWest < 256; iSouthAndWest++)
                                {
                                    //SouthAndWest - 2^48
                                    for (int iEastAndMidwest = 0; iEastAndMidwest < 256; iEastAndMidwest++)
                                    {
                                        //Sweet 16 - 2^56
                                        for (int iSweet16 = 0; iSweet16 < 256; iSweet16++)
                                        {
                                            //Elite 8 - 2^60
                                            for (int iElite8 = 0; iElite8 < 16; iElite8++)
                                            {
                                                //Final Four - 2^62
                                                for (int iFinalFour = 0; iFinalFour < 4; iFinalFour++)
                                                {
                                                    //Championship - 2^63
                                                    for (int iChampionship = 0; iChampionship < 2; iChampionship++)
                                                    {
                                                        string sSouth = Convert.ToString(iSouth, 2).PadLeft(8, '0');
                                                        string sWest = Convert.ToString(iWest, 2).PadLeft(8, '0');
                                                        string sEast = Convert.ToString(iEast, 2).PadLeft(8, '0');
                                                        string sMidwest = Convert.ToString(iMidwest, 2).PadLeft(8, '0');

                                                        string sSouthAndWest = Convert.ToString(iSouthAndWest, 2).PadLeft(8, '0');
                                                        string sEastAndMidwest = Convert.ToString(iEastAndMidwest, 2).PadLeft(8, '0');

                                                        string sSweet16 = Convert.ToString(iSweet16, 2).PadLeft(8, '0');
                                                        string sElite8 = Convert.ToString(iElite8, 2).PadLeft(4, '0');
                                                        string sFinalFour = Convert.ToString(iFinalFour, 2).PadLeft(2, '0');
                                                        string sChampionship = Convert.ToString(iChampionship, 2).PadLeft(1, '0');

                                                        line = "";
                                                        line += sSouth + sWest + sEast + sMidwest;

                                                        //file.WriteLine(line);
                                                        Console.WriteLine(iteration + " - " + line);
                                                        
                                                        line = "".PadLeft(32, ' ');
                                                        line += sSouthAndWest + sEastAndMidwest;
                                                        Console.WriteLine(iteration + " - " + line);

                                                        line = "".PadLeft(48, ' ');
                                                        line += sSweet16;
                                                        Console.WriteLine(iteration + " - " + line);

                                                        line = "".PadLeft(56, ' ');
                                                        line += sElite8;
                                                        Console.WriteLine(iteration + " - " + line);

                                                        line = "".PadLeft(60, ' ');
                                                        line += sFinalFour;
                                                        Console.WriteLine(iteration + " - " + line);

                                                        line = "".PadLeft(62, ' ');
                                                        line += sChampionship;
                                                        Console.WriteLine(iteration + " - " + line);


                                                        if (line.Equals(WINNING_LINE))
                                                        {
                                                            WINNING_ITERATION = iteration;
                                                        }


                                                        iteration++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }

                */

                /*
                 * OOOOORRRRRR
                 * */

                for (int iNCAA = 0; iNCAA <= Math.Pow(2, 63); iNCAA++)
                {
                    string sNCAA = Convert.ToString(iNCAA, 2).PadLeft(63, '0');
                    Console.WriteLine(iNCAA + " - " + sNCAA);

                    string sSouth = sNCAA.Substring(0, 8);
                    string sWest = sNCAA.Substring(8, 8);
                    string sEast = sNCAA.Substring(16, 8);
                    string sMidwest = sNCAA.Substring(24, 8);

                    string sSouthAndWest = sNCAA.Substring(32, 8);
                    string sEastAndMidwest = sNCAA.Substring(40, 8);

                    string sSweet16 = sNCAA.Substring(48, 8);
                    string sElite8 = sNCAA.Substring(56, 4);
                    string sFinalFour = sNCAA.Substring(60, 2);
                    string sChampionship = sNCAA.Substring(62, 1);


                    line = "";
                    line += sSouth + sWest + sEast + sMidwest;

                    //file.WriteLine(line);
                    Console.WriteLine(iNCAA + " - " + line);

                    line = "".PadLeft(32, ' ');
                    line += sSouthAndWest + sEastAndMidwest;
                    Console.WriteLine(iNCAA + " - " + line);

                    line = "".PadLeft(48, ' ');
                    line += sSweet16;
                    Console.WriteLine(iNCAA + " - " + line);

                    line = "".PadLeft(56, ' ');
                    line += sElite8;
                    Console.WriteLine(iNCAA + " - " + line);

                    line = "".PadLeft(60, ' ');
                    line += sFinalFour;
                    Console.WriteLine(iNCAA + " - " + line);

                    line = "".PadLeft(62, ' ');
                    line += sChampionship;
                    Console.WriteLine(iNCAA + " - " + line);

                }
                
            }

            EndTime = DateTime.Now;
            Console.WriteLine("BracketProcess() started at: " + StartTime + " ended at: " + EndTime + " total time: " + (EndTime - StartTime));
            Console.WriteLine("winning iteration: " + WINNING_ITERATION);
            Console.Read();
        }
    }
}
