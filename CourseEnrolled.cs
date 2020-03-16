using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace stream_aggregator
{
  public class CourseEnrolled
  {
    public int CourseId { get; set; }
    [JsonIgnore]
    public int PersonId { get; set; }
    public Person Person { get; set; }

  }
}