using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskEntityFrameworkCore.Model;

namespace TaskEntityFrameworkCore
{
    class DBMethods
    {
        TeamContext db;

        private Lazy<List<TeamMember>> TeamMembers;
        public DBMethods()
        {
            db = new TeamContext();
            TeamMembers = new Lazy<List<TeamMember>>(() => GetTeamMembers());
        }
        
        public List<TeamMember> TeamMembersProp { get { return TeamMembers.Value; } }

        public List<TeamMember> GetTeamMembers()
        {
            List<TeamMember> teamlist = new List<TeamMember>();
            teamlist = db.TeamMembers.Include("Team").ToList(); 
            return teamlist;
        }

        public void RemoveTeam(int id)
        {
            db.TeamMembers.Remove(db.TeamMembers.Where(x => x.Id == id).FirstOrDefault());
            db.SaveChanges();
        }
    }
}
