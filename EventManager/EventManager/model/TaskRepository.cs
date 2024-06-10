using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace EventManager.model
{
    public class TaskRepository
    {
        private string filePath;

        public TaskRepository(string filePath)
        {
            this.filePath = filePath;
        }

        public void Save(List<Task> tasks)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, tasks);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while saving tasks: " + ex.Message);
            }
        }

        public List<Task> Load()
        {
            List<Task> tasks = new List<Task>();
            try
            {
                if (File.Exists(filePath))
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        tasks = (List<Task>)binaryFormatter.Deserialize(fileStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while loading tasks: " + ex.Message);
            }
            return tasks;
        }
    }
}
