using System;

namespace ToDoList
{
    public class ToDo
    {
        private int index;
        private string author;
        private string description;

        public ToDo (string author, string description)
        {
            this.author = author;
            this.description = description;
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
