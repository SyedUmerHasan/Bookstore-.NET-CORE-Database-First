using System;
using System.Collections.Generic;

namespace BookStore_.NET_Core_Database_First.Models
{
    public partial class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string RollNumber { get; set; }
    }
}
