using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class MemberService : IService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        MemberRepository memberRepository;

        public event EventHandler Updated;

        /// <summary>
        /// Method to check subscribers and raise Updated event
        /// </summary>
        /// <param name="e">An eventargs</param>
        protected virtual void OnUpdated(EventArgs e)
        {
            if (Updated != null)
            {
                Updated(this, e);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
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
        /// Method that adds a new member and call OnUpdated to raise Updated event
        /// </summary>
        /// <param name="member">A member object</param>
        public void Add(Member member)
        {
            memberRepository.Add(member);
            OnUpdated(new EventArgs());
        }
    }
}
