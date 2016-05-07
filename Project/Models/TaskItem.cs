using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class TaskItem
    {
        public string id;

        public string title { get; set; }

        public string description { get; set; }

        public bool? completed { get; set; }

        public DateTime datetime { get; set; }

        //public BitmapImage bitmapImage { get; set; }

        public string filepath { get; set; }

        public string user { get; set; }

        public TaskItem(string id, string title, string description, DateTime datetime, string filepath)
        {
            this.id = id; //生成id
            this.title = title;
            this.description = description;
            this.user = "null";
            this.datetime = datetime;
            //this.bitmapImage = bitmapimage;
            completed = false; //默认为未完成
            this.filepath = filepath;
        }
    }
}