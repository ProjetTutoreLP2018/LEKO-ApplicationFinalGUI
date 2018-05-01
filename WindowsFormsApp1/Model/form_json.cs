using System;
using System.Collections.Generic;

using System.Text;

namespace FormTypeForm
{




    public class Image
    {
        public string href { get; set; }
    }

    public class Meta
    {
        public bool allow_indexing { get; set; }
        public Image image { get; set; }
    }





    public class Attachment
    {
        public string type { get; set; }
        public string href { get; set; }
    }



    public class Choice
    {
        public string id { get; set; }
        public string @ref { get; set; }
        public string label { get; set; }
        public Attachment attachment { get; set; }
    }

    public class Labels
    {
        public string left { get; set; }
        public string right { get; set; }
    }

    public class Properties
    {
        public string description { get; set; }
        public bool? randomize { get; set; }
        public bool? allow_multiple_selection { get; set; }
        public bool? allow_other_choice { get; set; }
        public bool? vertical_alignment { get; set; }
        public List<Choice> choices { get; set; }
        public List<Field> fields { get; set; }
        public bool? supersized { get; set; }
        public bool? show_labels { get; set; }
        public bool? hide_marks { get; set; }
        public string button_text { get; set; }
        public string structure { get; set; }
        public string separator { get; set; }
        public int? steps { get; set; }
        public bool? start_at_one { get; set; }
        public Labels labels { get; set; }
        public string shape { get; set; }
    }


    public class Field
    {
        public string id { get; set; }
        public string title { get; set; }
        public string @ref { get; set; }
        public Properties properties { get; set; }
        public Attachment attachment { get; set; }
        public string type { get; set; }
    }



    public class FormObject
    {
        public string id { get; set; }
        public string title { get; set; }
        public List<Field> fields { get; set; }

    }
}