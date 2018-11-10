using CalvinJerilNicdao.System.Web.Controllers.Helpers;
using CalvinJerilNicdao.System.Web.Controllers.Infrastracture.Data.Enums;
using System;

namespace CalvinJerilNicdao.System.Web.Models
{
    public class Users : BaseModels
    {
        internal string RequestId;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {

                return this.FirstName + " " + this.LastName;
            }
        }

        public Gender Gender { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public LoginStatus LoginStatus { get; set; }

        public string RegistrationCode { get; set; }

        public int LoginTrials { get; set; }

    }
}