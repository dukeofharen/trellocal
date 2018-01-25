using Newtonsoft.Json;

namespace Trellocal.Models.Trello
{
   public class TrelloList
   {
      [JsonProperty("id")]
      public string Id { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("closed")]
      public bool Closed { get; set; }

      [JsonProperty("idBoard")]
      public string IdBoard { get; set; }

      [JsonProperty("pos")]
      public double Pos { get; set; }
   }
}
