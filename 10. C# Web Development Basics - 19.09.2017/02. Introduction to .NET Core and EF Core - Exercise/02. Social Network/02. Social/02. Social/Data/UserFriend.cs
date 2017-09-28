namespace _02._Social.Data
{
    public class UserFriend
    {
        public int UserId { get; set; }

        public Users User { get; set; }

        public int FriendId { get; set; }

        public Users Friend { get; set; }

    }
}
