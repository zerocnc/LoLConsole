using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLConsole
{
    /***********************************************************************************************
     * Type: Response Classes
     * Return Value: Map[string, MasteryPagesDto]
     * URL: /api/lol/{region}/v1.3/summoner/{summonerIds}/masteries
     * Descriptin: Get's summoner's rune page from server.
     *             
     *      Path Parameters
     *      region - "na", "euw", "eune"
     *      summonerIdseason - long
     *      
     * Returns Respone codes
     * - HTTP Status Code -----------  Reason --------
     *      400                     Bad request
     *      401                     Unauthorized
     *      500                     Internal server error
     *      404                     Summoner not found
     *      503                     Service unavailable
     **********************************************************************************************/
    class summonerProfile
    {
        // Holds the name & dictionary of all Mastery pages for a summoner.
        public Dictionary<string, MasteryPages> summonerMasteryBook { get; set; }
        public summonerRunePage RunePage { get; set; }

        public class MasteryPages
        {
            // List of mastery pages associated with the summoner.
            public List<MasteryPage> pages { get; set; }

            // Summoner Id.
            public long summonerId { get; set; }
        }

        public class MasteryPage
        {
            // Indicates if the mastery page is the current mastery page.
            bool current { get; set; }

            // Mastery page ID.
            long id { get; set; }

            // Mastery page name.
            string name { get; set; }

            // List of mastery page talents associated with the mastery page.
            List<Talent> talents { get; set; }
        }

        public class Talent
        {
            // Talent id.
            int id { get; set; }

            // Talent name.
            string name { get; set; }

            // Talent rank.
            int rank { get; set; }
        }

        public Dictionary<string, summonerRunePage> summonerRuneBook { get; set; }

        public class summonerRunePage
        {
            // Set of rune pages associated with the summoner.
            public List<Page> pages { get; set; }

            // Summoner ID.
            public int summonerId { get; set; }
        }

        public class Rune
        {
            // Rune ID.
            public int id { get; set; }

            // Rune description.
            public string description { get; set; }

            // Rune name.
            public string name { get; set; }

            // Rune tier.
            public int tier { get; set; }
        }

        public class Slot
        {
            // Rune slot ID.
            public int runeSlotId { get; set; }

            // Rune associated with the rune slot.
            public Rune rune { get; set; }
        }

        public class Page
        {
            // Rune page ID.
            public int id { get; set; }

            // List of rune slots associated with the rune page.
            public List<Slot> slots { get; set; }

            // Rune page name.
            public string name { get; set; }

            // Indicates if the page is the current page.
            public bool current { get; set; }
        }
    }
}
