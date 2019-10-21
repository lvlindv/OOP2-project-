using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Domain object "Member"
    /// </summary>
    public class Member
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int MemberId { get; set; } //Primary key
        public int PersonalId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfMembership { get; set; }
        public IEnumerable<Loan> Loans { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Member(int personalId, string name, DateTime dateofMembership)
        {
            //Set values of properties
            this.PersonalId = personalId;
            this.Name = name;
            this.DateOfMembership = dateofMembership;

            List<Loan> loanList = new List<Loan>();
            this.Loans = loanList;
        }
    }
}
