using System;
using Newtonsoft.Json;

namespace Trellocal.Models.Trello
{
   public class TrelloAttachment
   {
      [JsonProperty("id")]
      public string Id { get; set; }

      [JsonProperty("bytes")]
      public int Bytes { get; set; }

      [JsonProperty("date")]
      public DateTime Date { get; set; }

      [JsonProperty("idMember")]
      public string IdMember { get; set; }

      [JsonProperty("isUpload")]
      public bool IsUpload { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("url")]
      public string Url { get; set; }

      [JsonProperty("pos")]
      public double Pos { get; set; }
   }
}
