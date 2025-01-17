﻿using System.ComponentModel.DataAnnotations;

namespace ILA3_0110.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public int? ClassroomId { get; set; }  // Optional, um Flexibilität zu ermöglichen
    }


}