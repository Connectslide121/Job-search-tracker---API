using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum Interest
    {
        low,
        medium,
        high
    }

    public enum Status
    {
        sent,
        declined,
        approved
    }

    public class Job
    {
        [Key] public int Id { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public Interest Interest { get; set; }
        public Status Status { get; set; }
        public DateTime AppliedAt { get; set; }

    }
}
