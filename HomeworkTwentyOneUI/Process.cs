using HomeworkTwentyOneLibrary.Models;

namespace HomeworkTwentyOneUI
{
    public static class Process
    {
        private static List<GuestModel> _guests = new List<GuestModel>();

        public static void GetInformation()
        {
            string hasAnotherGuest = "";

            do
            {
                GuestModel guest = new GuestModel();
                guest.FirstName = GetAnswer("Enter first name: ");
                guest.LastName = GetAnswer("Enter last name: ");
                guest.GreetingMessage = GetAnswer("Enter greeting message: ");
                hasAnotherGuest = GetAnswer("Log another guest (yes/no): ");

                _guests.Add(guest);

                Section.Welcome();

            } while (hasAnotherGuest.ToLower() == "yes");
        }

        public static void PrintInformation()
        {
            foreach (GuestModel guest in _guests)
            {
                Console.WriteLine(guest.Details);
            }
        }

        private static string GetAnswer(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}
