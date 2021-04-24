using System;
using System.ComponentModel.DataAnnotations;

namespace Capstone.Sample.ComplainApp
{
    public class CommentModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }

        [Required]
        public string Comment { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}"
            , ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string UserName { get; set; }
    }
}
