using System;
using System.Collections.Generic;
using System.Text;

namespace TaskPad
{
    public class Task
    {
        public int Id;
        public int Priority;
        public string Title;
        public string Description;
        public DateTime Start;
        public DateTime Deadline;
        public Status Status;
    }
}
