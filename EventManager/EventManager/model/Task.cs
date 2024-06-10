using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.model
{
    public enum TaskType
    {
        Work,
        Family,
        Entertainment,
        Health,
        Sport
    }

    public enum TaskPriority
    {
        High,
        Medium,
        Low
    }
    public class Task
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TaskType Type { get; set; }
        public TaskPriority Priority { get; set; }

        public Task(string title, string description, DateTime date, TaskType type, TaskPriority priority)
        {
            Title = title;
            Description = description;
            Date = date;
            Type = type;
            Priority = priority;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Description: {Description}, Date: {Date}, Type: {Type}, Priority: {Priority}";
        }
    }
}
