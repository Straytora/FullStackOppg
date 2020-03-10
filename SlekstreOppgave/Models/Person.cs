using System;
using System.Collections.Generic;

namespace SlekstreOppgave.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Birthyear { get; set; }
        public string Children { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
    }
}
