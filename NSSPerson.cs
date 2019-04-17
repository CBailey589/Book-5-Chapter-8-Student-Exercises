using System;
using System.Collections.Generic;

namespace myApp
{
    public class NSSPerson
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _slackHandle { get; set; }
        private string _cohort { get; set; }

        public string FirstName
        {
            set { _firstName = value; }
            get { return _firstName; }
        }
        public string LastName
        {
            set { _lastName = value; }
            get { return _lastName; }
        }
        public string SlackHandle
        {
            set { _slackHandle = value; }
            get { return _slackHandle; }
        }
        public string Cohort
        {
            set { _cohort = value; }
            get { return _cohort; }
        }

    }
}