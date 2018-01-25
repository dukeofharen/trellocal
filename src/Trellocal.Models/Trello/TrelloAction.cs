using System;
using Newtonsoft.Json;

namespace Trellocal.Models.Trello
{
   public class TrelloAction
   {
      [JsonProperty("id")]
      public string Id { get; set; }

      [JsonProperty("idMemberCreator")]
      public string IdMemberCreator { get; set; }

      [JsonProperty("data")]
      public TrelloActionData Data { get; set; }

      [JsonProperty("type")]
      public string Type { get; set; }

      [JsonProperty("date")]
      public DateTime Date { get; set; }

      [JsonProperty("memberCreator")]
      public TrelloMember Creator { get; set; }

      public class TrelloActionData
      {
         [JsonProperty("card")]
         public TrelloCard Card { get; set; }
      }
   }
}
