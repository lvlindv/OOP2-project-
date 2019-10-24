using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public int MemberId { get; set; }
        public int PersonalId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfMembership { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="personalId"></param>
        /// <param name="name"></param>
        /// <param name="dateofMembership"></param>
        public Member(int personalId, string name, DateTime dateofMembership)
        {
            this.PersonalId = personalId;
            this.Name = name;
            this.DateOfMembership = dateofMembership;

            this.Loans = new List<Loan>();
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Member()
        {
            this.Loans = new List<Loan>();
        }

        public override string ToString()
        {
            return String.Format("{0} -- {1} -- {2}", this.PersonalId, this.Name, this.DateOfMembership);
        }
    }
}
