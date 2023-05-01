namespace HomeworkTwentyOneLibrary.Models
{
    public class GuestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GreetingMessage { get; set; }

        public string Details
        {
            get
            {
                return $"{FirstName} {LastName}: {GreetingMessage}";
            }
        }
    }
}
