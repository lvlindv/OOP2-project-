using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class MemberService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        MemberRepository memberRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rFactory"></param>
        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
        }

        /// <summary>
        /// Method that gets all members
        /// </summary>
        /// <returns>A list of members</returns>
        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        /// <summary>
        /// Method that adds a new member
        /// </summary>
        /// <param name="member">A member object</param>
        public void Add(Member member)
        {
            memberRepository.Add(member);
            // TODO: Raise the Updated event.
        }
    }
}
