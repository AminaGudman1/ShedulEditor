using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheduleEditor_Amina
{
    class Cabinets
    {
        public int Number { get; set; }
        public int AComputer { get; set; }
        public bool Board { get; set; }
        public int CountOfSeats { get; set; }
        public int CountOfTables { get; set; }
        public bool Projector { get; set; }
        public Cabinets(int number, int aComputer, bool board, int countOfSeats, int countOfTables, bool projector)
        {
            Number = number;
            AComputer = aComputer;
            Board = board;
            CountOfSeats = countOfSeats;
            CountOfTables = countOfTables;
            Projector = projector;
        }
        public override string ToString()
        {
            return Number + " кабинет:" + " кoмпьютеров: " + AComputer + ", доска: " + Board
                + ", посадочные места: " + CountOfSeats + ", кол-во парт: " + CountOfTables +
                ", проектор: " + Projector;
        }
    }
    class Group
    {
        public int Number { get; set; }
        public string Weekday { get; set; }
        public int Pair { get; set; }
        public int Cabinet { get; set; }

        public Group(int number, string weekday, int pair, int cabinet)
        {
            Number = number;
            Weekday = weekday;
            Pair = pair;
            Cabinet = cabinet;

        }
        public override string ToString()
        {
            return Number + " группа. " + Weekday + ", " + Pair
                + " пара в " + Cabinet + " кабинете.";
        }
    }
    //class ListGroups
    //{
    //    List<Group> listGroup = new List<Group>();
    //    public void Add(Group gr)
    //    {
    //        listGroup.Add(gr);
    //    }
    //    public void SaveToFile()
    //    {
    //        var agJson = JsonConvert.SerializeObject(listGroup);
    //        using (StreamWriter sw = new StreamWriter("listGroup.json"))
    //            sw.WriteLine(agJson);
    //    }
    //    public void LoadFromFile()
    //    {
    //        using (StreamReader sr = new StreamReader("listGroup.json"))
    //        {
    //            listGroup = JsonConvert.DeserializeObject<List<Group>>(sr.ReadToEnd());
    //        }
    //    }
       
    //}
}
