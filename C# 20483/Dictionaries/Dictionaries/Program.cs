using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> Party = new Dictionary<string, Person>(); // creating a dictionary listing of characters called PARTY

            Party.Add("King", new Person() {Name="King", PhoneNumber= 0001231235}); // can use a delegate to run this portion so it isn't implimented like this... or just a nested function
            // CreateParty()
                // optional custom party
                // party limit
                // boosted chance
                // Asks for options, name, type, etc.
                    // stat rolls occur
                        // vars passed to Party.Add(name, new Hero(), type, etc. ^_^)
                // InitialEquimentGen()
                    // Party.name - issue is knowing the name to call for iterating... its easier with a list. can use enums
                    // Dict limits access by requiring a key... so maybe its useful when expecting a key and using that key for the params in code. should I store char keys? how will it save? 
                    // Will data work better with Dict vs List...
                    // Entering the data is easy in the forms. it gets pulled in the data form correctly for a list. Is it the same with a Dict? 
                    // ... with a search function, it shows based on entry matching vs a full listing. as expected. 
                    
            // if (Party.ContainsKey(name)) or "king" - only uses the key.
            // {
                // Console.WriteLine(Party[name].Name + " " + Party[name].attributes);
            // }
                    
            // Dicts can be iterated w/ 
            //
            // forach(var person in Party.Keys)
            // {
                // check health first > check speed > ... (player chooses actions, but how is order decided?)// choices add to an action queue / sortedlist > check for health again before action
                // Logic Argument here //PlayerTurn(Party[person]) -> pass player to func to fill options & stats vs enemy
            //
            // }

            // be carefule with CASE matching in key names

        }
    }
}
