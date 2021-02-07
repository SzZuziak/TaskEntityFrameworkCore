using System;
using System.Linq;

namespace TaskEntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DBMethods db = new DBMethods();

            foreach(var item in db.TeamMembersProp)
            {
                foreach(var team in item.Team)
                Console.WriteLine("{0} {1} Team: {2}", item.FirstName, item.LastName, team.Name);
            }

            db.RemoveTeam(1);

        }
    }
}
