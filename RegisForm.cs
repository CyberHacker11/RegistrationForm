using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm
{
    class RegisForm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string LiveAddress { get; set; }
        public string WorkAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string[] Languages;
        public string[] ProgrammingLanguages;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{FirstName}");
            sb.Append($"{LastName}");
            sb.Append($"{Company}");
            sb.Append($"{Email}");
            sb.Append($"{Phone}");
            sb.Append($"{Gender}");
            sb.Append($"{Country}");
            sb.Append($"{City}");
            sb.Append($"{LiveAddress}");
            sb.Append($"{WorkAddress}");
            sb.Append($"{DateOfBirth}");

            return sb.ToString();
        }
    }
}