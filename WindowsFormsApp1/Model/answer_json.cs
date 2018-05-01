using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerTypeForm
{
    public class Metadata
    {
        public string user_agent { get; set; }
        public string platform { get; set; }
        public string referer { get; set; }
        public string network_id { get; set; }
        public string browser { get; set; }
    }

    public class Field
    {
        public string id { get; set; }
        public string type { get; set; }
        public string @ref { get; set; }
    }

    public class Choices
    {
        public List<string> labels { get; set; }
    }

    public class Choice
    {
        public string label { get; set; }
    }

    public class Answer
    {
        public Field field { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public bool? boolean { get; set; }
        public string email { get; set; }

        public string url { get; set; }
        public int? number { get; set; }
        public Choices choices { get; set; }
        public DateTime? date { get; set; }
        public Choice choice { get; set; }
        public string file_url { get; set; }
    }

    public class Hidden
    {
    }

    public class Calculated
    {
        public int score { get; set; }
    }

    public class Item
    {
        public string landing_id { get; set; }
        public string token { get; set; }
        public DateTime landed_at { get; set; }
        public DateTime submitted_at { get; set; }
        public Metadata metadata { get; set; }
        public List<Answer> answers { get; set; }
        public Hidden hidden { get; set; }
        public Calculated calculated { get; set; }
    }

    public class AnswerObject
    {
        public int total_items { get; set; }
        public int page_count { get; set; }
        public List<Item> items { get; set; }
    }
}