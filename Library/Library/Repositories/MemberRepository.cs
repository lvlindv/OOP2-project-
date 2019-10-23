using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class MemberRepository
    {
        LibraryContext context;

        public MemberRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<Member> All()
        {
            return context.Members;
        } 

        public void Add(Member member)
        {
            context.Members.Add(member);
            context.SaveChanges();
        }

    }
}
