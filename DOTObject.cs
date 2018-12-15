using System;

namespace IowaCodeCamp
{
    public class DotObject
    {
        //Whether the light was red, green or red
        public decimal Light_Code { get; set; }
        //County designation
        public int County_No { get; set; }
        //Municipality of accident
        public int Muni_Code { get; set; }
        //Junction designation
        public int Junction_Code { get; set; }
        //Type of collision
        public int Collision_Type_Code { get; set; }
        //Which lane the accident occurred
        public int Lane_Code { get; set; }
        //What type of road (dirt, tarmac)
        public int Rd_Cond_Code { get; set; }
        //What type of divider on the road (concrete, steel, none)
        public int Rd_Div_Code { get; set; }
        //Types of fixed objects on the road
        public int Fix_Obj_Code { get; set; }
        //Report ID
        public string Report_No { get; set; }
        //Description of Accident
        public string Report_Type { get; set; }
        //What date the accident occurred
        public DateTime Acc_Date { get; set; }
        //Time of Accident
        public DateTime Acc_Time { get; set; }
        //Location ID 
        public string Loc_Code { get; set; }
        //Whether a signal was made by the car
        public bool Signal_Flag { get; set; }
        //Whether the zone was valid
        public bool C_M_Zone_Flag { get; set; }
        //Which agency has jurisdiction
        public string Agency_Code { get; set; }
        //Area Code
        public string Area_Code { get; set; }
        //Type of personal injury sustained
        public int Harm_Event_Code1 { get; set; }
        //Second type of personal injury sustained
        public int Harm_Event_Code2 { get; set; }
        //Route number
        public int Rte_No { get; set; }
        //Route number
        public string Route_Type_Code { get; set; }
        //The route suffix
        public char Rte_Suffix { get; set; }
        //Miles logged
        public decimal Log_Mile { get; set; }
        //Type of Miles logged
        public char Logmile_Dir_Flag { get; set; }
        //Name of main road
        public string Mainroad_Name { get; set; }
        //Distance span of accident
        public int Distance { get; set; }
        //Type of distance whether it is feet or miles
        public char Feet_Miles_Flag { get; set; }
        //Direction of accident facing
        public char Distance_Dir_Flag { get; set; }
        //Reference ID
        public int Reference_No { get; set; }
        //Type of reference
        public string Reference_Type_Code { get; set; }
        //Suffix of reference
        public char Reference_Suffix { get; set; }
        //Road name of the reference
        public string Reference_Road_Name { get; set; }
        //Latitude of Accident
        public decimal Latitude { get; set; }
        //Longitude of Accident
        public decimal Longitude { get; set; }
    }
}
