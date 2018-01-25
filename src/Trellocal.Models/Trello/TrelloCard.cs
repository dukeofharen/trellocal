using System;
using Newtonsoft.Json;

namespace Trellocal.Models.Trello
{
   public class TrelloCard
   {
      [JsonProperty("id")]
      public string Id { get; set; }

      [JsonProperty("dateLastActivity")]
      public DateTime DateLastActivity { get; set; }

      [JsonProperty("desc")]
      public string Desc { get; set; }

      [JsonProperty("idBoard")]
      public string IdBoard { get; set; }

      [JsonProperty("idList")]
      public string IdList { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("pos")]
      public double Pos { get; set; }
   }
}
