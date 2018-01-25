using Newtonsoft.Json;

namespace Trellocal.Models.Trello
{
   public class TrelloChecklist
   {
      [JsonProperty("id")]
      public string Id { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("idBoard")]
      public string IdBoard { get; set; }

      [JsonProperty("idCard")]
      public string IdCard { get; set; }

      [JsonProperty("pos")]
      public double Pos { get; set; }

      [JsonProperty("checkItems")]
      public TrelloChecklistItem[] CheckItems { get; set; }

      public class TrelloChecklistItem
      {
         [JsonProperty("state")]
         public string State { get; set; }

         [JsonProperty("idChecklist")]
         public string IdChecklist { get; set; }

         [JsonProperty("id")]
         public string Id { get; set; }

         [JsonProperty("name")]
         public string Name { get; set; }

         [JsonProperty("pos")]
         public double Pos { get; set; }
      }
   }
}
