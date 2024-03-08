using System.Text.Json;
using System.Text.Json.Serialization;

namespace Student.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public override string ToString() =>
        JsonSerializer.Serialize<Student>(this);
    }
}
