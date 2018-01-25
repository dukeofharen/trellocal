using Newtonsoft.Json;

namespace Trellocal.Models.Trello
{
   public class TrelloMember
   {
      [JsonProperty("id")]
      public string Id { get; set; }

      [JsonProperty("avatarHash")]
      public string AvatarHash { get; set; }

      [JsonProperty("fullName")]
      public string FullName { get; set; }

      [JsonProperty("initials")]
      public string Initials { get; set; }

      [JsonProperty("username")]
      public string Username { get; set; }
   }
}
