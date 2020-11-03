using MSharp;

namespace Security
{
    public class Administrator : SubType<User>
    {
        public Administrator()
        {
            Schema("Security");

            String("Impersonation token", 40);
        }
    }
}