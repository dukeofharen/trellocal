using Newtonsoft.Json;

namespace Trellocal.Models.Trello
{
   public class TrelloBoard
   {
      [JsonProperty("id")]
      public string Id { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("desc")]
      public string Desc { get; set; }

      [JsonProperty("descData")]
      public string DescData { get; set; }

      [JsonProperty("closed")]
      public bool Closed { get; set; }

      [JsonProperty("idOrganization")]
      public string IdOrganization { get; set; }
   }
}
