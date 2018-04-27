using System;
using System.Collections.Generic;
using System.Text;

namespace LogInExerciseApp.Models
{
   public class Token
    {
        public int Id { get; set; }
        public string Access_token { get; set; }
        public string Error_description { get; set; }
        public DateTime expire_date { get; set; }
        public int expire_in { get; set; }

        public Token() { }

    }
}
