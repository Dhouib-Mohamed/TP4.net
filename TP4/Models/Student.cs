﻿using System.ComponentModel.DataAnnotations;

namespace TP4.Models
{
    public class Student
    {
        [Key] public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone_number { get; set; }
        public string university { get; set; }
        public DateTime timestamp { get; set; }
        public string course { get; set; }

        public Student (int id, string first_name, string last_name, string phone_number, string university, DateTime timestamp, string course)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.phone_number = phone_number;
            this.university = university;
            this.timestamp = timestamp;
            this.course = course;
        }
    }
}
