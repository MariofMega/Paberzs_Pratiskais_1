using System;
using System.Collections.Generic;
using System.Text;

namespace Paberzs_Pratiskais_1.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }
    }
}
