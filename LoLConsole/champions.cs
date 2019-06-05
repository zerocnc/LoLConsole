
using System.Data.SQLite;
using System.Net;
using System.IO;

// User Defined - Imported
using Newtonsoft;

namespace LoLConsole
{
    // SQL Database - Use to make and store through paramazitation
    class champions: API_Call
    {
        // Champion ID Key
        public int  id = 0;
        // 
        public int  rank = 0;
        public int  championID = 0;
        public string name;
        public string cost;
        public string cooldown;
        public string iconPath;
        public string videoPath;
        public string range;
        public string effect;
        public string description;
        public string hotkey;


        /**************************************************************
         * Name: GetListAPI()
         * Arguments: None
         * Function: Gets current champions in game and puts them into as list.
         **************************************************************/
        void GetListAPI()
        {
 
        }

    }
}
