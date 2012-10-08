using System;
using System.ComponentModel.DataAnnotations;
using MvcSourceCodeLearning.Core.Attributes;

namespace MvcSourceCodeLearning.Models
{
    public class Employee
    {
        [DisplayText]
        public string Name { get; set; }
        [DisplayText]
        public string Gender { get; set; }
        [DisplayText]
        [DataType(DataType.Date)]
        public DateTime DateBirth { get; set; }
        [DisplayText]
        public string Department { get; set; }
    }
}