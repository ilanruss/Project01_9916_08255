﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class HostingUnit
    {
        long HostingUnitKey;
        Host Owner; // the owner of the hosting unit
        string HostingUnitName; // hosting unit
        bool[,] Diary = new bool[12,31];  //matrix, repersent if occupied or vacant
        bool hasPool;
        bool hasJaccuzzi;
        bool hasGarden;
        bool hasChildrensAttractions;
        BEEnum.Area areaOfHOstingUnit;
        int commission;
        #region properties
        public long HostingUnitKey1 { get => HostingUnitKey; set => HostingUnitKey = value; }
        public Host Owner1 { get => Owner; set => Owner = value; }
        public string HostingUnitName1 { get => HostingUnitName; set => HostingUnitName = value; }
        public bool[,] Diary1 { get => Diary; set => Diary = value; }
        public BEEnum.Area AreaOfHostingUnit { get => areaOfHOstingUnit; set => areaOfHOstingUnit = value;}
        public bool hasPool1 { get => hasPool; set => hasPool = value; }
        public bool hasJaccuzzi1 { get => hasJaccuzzi; set => hasJaccuzzi = value; }
        public bool hasGarden1 { get => hasGarden; set => hasGarden = value; }
        public bool hasChildrensAttractions1 { get => hasChildrensAttractions; set => hasChildrensAttractions = value; }
        public int Commission1 { get => commission; set => commission = value; }
        #endregion
        public override string ToString()
        {
            string to = "Hosting unit key: " + Convert.ToString(HostingUnitKey);
            to += "\n Name: " + HostingUnitName;
            ArrayList Date = VacationDates();// calculates the end dates of each function
            for (int i = 0; i < Date.Count; i += 4)
                to+=("Start Date: {0}.{1} , End Date:{2}.{3} ", (int)Date[i] + 1, (int)Date[i + 1] + 1, (int)Date[i + 2] + 1, (int)Date[i + 3] + 1);
            // prints start and end dates for each vacation
            to += "\n Area of the hosting unit: " + areaOfHOstingUnit.ToString();
                if(hasPool)to+="\n There is a pool.";
            if (hasJaccuzzi) to += "\n There is a Jaccuzzi.";
            if (hasGarden1) to += "\n There is a Garden.";
            if (hasChildrensAttractions) to += "\n There are children's attractions.";
            to += "\n------------------------------";
            return to;
        }
        private ArrayList VacationDates()//returns list of dates of occupied days
        {
            bool occupied = false;
            ArrayList Dates = new ArrayList();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (Diary[i, j] != occupied)
                    {
                        Dates.Add(i + 1);
                        Dates.Add(j + 1);
                        occupied = !occupied;
                    }
                }
            }
            return Dates;
        }

    }
}
