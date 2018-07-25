using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Other
{
    public class Socialstat
    {
        [JsonProperty("Response")] public string Response { get; set; }

        [JsonProperty("Message")] public string Message { get; set; }

        [JsonProperty("Type")] public long Type { get; set; }

        [JsonProperty("Data")] public SocialstatData Data { get; set; }
    }

    public class SocialstatData
    {
        [JsonProperty("General")] public General General { get; set; }

        [JsonProperty("CryptoCompare")] public CryptoCompare CryptoCompare { get; set; }

        [JsonProperty("Twitter")] public Twitter Twitter { get; set; }

        [JsonProperty("Reddit")] public Reddit Reddit { get; set; }

        [JsonProperty("Facebook")] public Facebook Facebook { get; set; }

        [JsonProperty("CodeRepository")] public CodeRepository CodeRepository { get; set; }
    }

    public class CodeRepository
    {
        [JsonProperty("List")] public List[] List { get; set; }

        [JsonProperty("Points")] public long Points { get; set; }
    }

    public class List
    {
        [JsonProperty("open_pull_issues")] public long OpenPullIssues { get; set; }

        [JsonProperty("url")] public string Url { get; set; }

        [JsonProperty("size")] public long Size { get; set; }

        [JsonProperty("fork")] public bool Fork { get; set; }

        [JsonProperty("stars")] public long Stars { get; set; }

        [JsonProperty("closed_total_issues")] public long ClosedTotalIssues { get; set; }

        [JsonProperty("created_at")] public long CreatedAt { get; set; }

        [JsonProperty("closed_issues")] public long ClosedIssues { get; set; }

        [JsonProperty("closed_pull_issues")] public long ClosedPullIssues { get; set; }

        [JsonProperty("open_total_issues")] public long OpenTotalIssues { get; set; }

        [JsonProperty("source")] public Parent Source { get; set; }

        [JsonProperty("last_update")] public long LastUpdate { get; set; }

        [JsonProperty("subscribers")] public long Subscribers { get; set; }

        [JsonProperty("language")] public string Language { get; set; }

        [JsonProperty("forks")] public long Forks { get; set; }

        [JsonProperty("parent")] public Parent Parent { get; set; }

        [JsonProperty("last_push")] public long LastPush { get; set; }

        [JsonProperty("open_issues")] public long OpenIssues { get; set; }
    }

    public class Parent
    {
        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("Url")] public string Url { get; set; }

        [JsonProperty("InternalId")] public long InternalId { get; set; }
    }

    public class CryptoCompare
    {
        [JsonProperty("SimilarItems")] public SimilarItem[] SimilarItems { get; set; }

        [JsonProperty("CryptopianFollowers")] public CryptopianFollower[] CryptopianFollowers { get; set; }

        [JsonProperty("Posts")] public long Posts { get; set; }

        [JsonProperty("Comments")] public long Comments { get; set; }

        [JsonProperty("Points")] public long Points { get; set; }

        [JsonProperty("Followers")] public long Followers { get; set; }

        [JsonProperty("PageViewsSplit")] public PageViewsSplit PageViewsSplit { get; set; }

        [JsonProperty("PageViews")] public long PageViews { get; set; }
    }

    public class CryptopianFollower
    {
        [JsonProperty("Id")] public long Id { get; set; }

        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("ImageUrl")] public string ImageUrl { get; set; }

        [JsonProperty("Url")] public string Url { get; set; }

        [JsonProperty("Type")] public string Type { get; set; }
    }

    public class PageViewsSplit
    {
        [JsonProperty("Overview")] public long Overview { get; set; }

        [JsonProperty("Markets")] public long Markets { get; set; }

        [JsonProperty("Analysis")] public long Analysis { get; set; }

        [JsonProperty("Charts")] public long Charts { get; set; }

        [JsonProperty("Trades")] public long Trades { get; set; }

        [JsonProperty("Orderbook")] public long Orderbook { get; set; }

        [JsonProperty("Forum")] public long Forum { get; set; }

        [JsonProperty("Influence")] public long Influence { get; set; }

        [JsonProperty("News")] public long News { get; set; }
    }

    public class SimilarItem
    {
        [JsonProperty("Id")] public long Id { get; set; }

        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("FullName")] public string FullName { get; set; }

        [JsonProperty("ImageUrl")] public string ImageUrl { get; set; }

        [JsonProperty("Url")] public string Url { get; set; }

        [JsonProperty("FollowingType")] public long FollowingType { get; set; }
    }

    public class Facebook
    {
        [JsonProperty("is_closed")] public bool IsClosed { get; set; }

        [JsonProperty("link")] public string Link { get; set; }

        [JsonProperty("talking_about")] public long TalkingAbout { get; set; }

        [JsonProperty("likes")] public long Likes { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("Points")] public long Points { get; set; }
    }

    public class General
    {
        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("CoinName")] public string CoinName { get; set; }

        [JsonProperty("Type")] public string Type { get; set; }

        [JsonProperty("Points")] public long Points { get; set; }
    }

    public class Reddit
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("subscribers")] public long Subscribers { get; set; }

        [JsonProperty("community_creation")] public long CommunityCreation { get; set; }

        [JsonProperty("comments_per_day")] public double CommentsPerDay { get; set; }

        [JsonProperty("comments_per_hour")] public string CommentsPerHour { get; set; }

        [JsonProperty("active_users")] public long ActiveUsers { get; set; }

        [JsonProperty("link")] public string Link { get; set; }

        [JsonProperty("posts_per_day")] public string PostsPerDay { get; set; }

        [JsonProperty("posts_per_hour")] public string PostsPerHour { get; set; }

        [JsonProperty("Points")] public long Points { get; set; }
    }

    public class Twitter
    {
        [JsonProperty("statuses")] public long Statuses { get; set; }

        [JsonProperty("followers")] public long Followers { get; set; }

        [JsonProperty("favourites")] public long Favourites { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("lists")] public long Lists { get; set; }

        [JsonProperty("link")] public string Link { get; set; }

        [JsonProperty("account_creation")] public long AccountCreation { get; set; }

        [JsonProperty("following")] public long Following { get; set; }

        [JsonProperty("Points")] public long Points { get; set; }
    }
}