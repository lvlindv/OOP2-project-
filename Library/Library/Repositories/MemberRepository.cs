using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class MemberRepository : IRepository<Member, int>
    {
        /// <summary>
        /// Instantiates library context
        /// </summary>
        LibraryContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">A library context</param>
        public MemberRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Method to get all members from db
        /// </summary>
        /// <returns>A list of members</returns>
        public IEnumerable<Member> All()
        {
            return context.Members;
        } 

        /// <summary>
        /// Method to add a member to db
        /// </summary>
        /// <param name="member">Takes a member object</param>
        public void Add(Member member)
        {
            context.Members.Add(member);
            context.SaveChanges();
        }

        public void Remove(Member item)
        {
            throw new NotImplementedException();
        }

        public Member Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Member item)
        {
            throw new NotImplementedException();
        }
    }
}
