using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Androsova.Models
{
    internal class Note
    {
        public string NotesText { get; } = "Welcome to .NET MAUI!";
        public string Text { get; set; } = string.Empty;
        public string FilePath { get; }



        public Note()
        {
            string _filename = Path.Combine(FileSystem.AppDataDirectory);
            FilePath = Path.Combine(_filename, "note.txt");
        }
    }
}
