namespace CustomerApp.Server.Data
{
    public class SeedData
    {
        // method ensure we have populated the data
        public static async Task EnsurePopulated(IServiceProvider serviceProvider)
        {
            // need to get a context
            CustomerContext context = serviceProvider.GetService<CustomerContext>();
            
            if (context == null)
            {
                throw new Exception("Context can not be found.");
            }


            // check if we have any data in the database
            if (!context.Customer.Any())
            {
                // seed the database
                context.Customer.Add(new Models.Customer
                {
                    FirstName = "Jesse",
                    LastName = "Harlan",
                    Birthdate = DateTime.Now,
                });

                await context.SaveChangesAsync();

            } else
            {
                throw new Exception("Database has already been seeded.");
            }
        }
    }
}
