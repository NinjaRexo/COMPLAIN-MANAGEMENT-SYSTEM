using System;
using System.ComponentModel.DataAnnotations;

namespace Capstone.Sample.ComplainApp
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Block { get; set; }
        public string Subject { get; set; }
        public string ContactNo { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
        public bool Resolved { get; set; }
    }
}
