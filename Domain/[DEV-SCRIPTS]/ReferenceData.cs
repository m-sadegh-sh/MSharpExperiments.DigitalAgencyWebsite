using Olive.Entities;
using Olive.Entities.Data;
using Olive.Security;

using System.Threading.Tasks;

namespace Domain
{
    public class ReferenceData : IReferenceData
    {
        private readonly IDatabase Database;

        public ReferenceData(IDatabase database) => Database = database;

        async Task<T> Create<T>(T item) where T : IEntity
        {
            await Database.Save(item, SaveBehaviour.BypassAll);
            return item;
        }

        public async Task Create()
        {
            await Create(new GeneralSettings
            {
                Name = "Current",
                PasswordResetTicketExpiryMinutes = 2
            });

            await CreateContentBlocks();
            await CreateClients();
            await CreateFeatures();
            await CreateSlides();
            await CreateTestimonies();
            await CreateAdmin();
        }

        async Task CreateContentBlocks()
        {
            await Create(new ContentBlock
            {
                Key = nameof(ContentBlock.LoginIntro),
                Content = "<p>Welcome to our application.<br/>Please log in using the form below.</p>"
            });

            await Create(new ContentBlock
            {
                Key = nameof(ContentBlock.PasswordSuccessfullyReset),
                Content = "Your password has been successfully reset."
            });
        }

        async Task CreateClients()
        {
            await Create(new Client
            {
                Name = "Microsoft",
                Image = new Blob("~/Mocks/iconfinder_379_Windows_logo_4375149.png")
            });

            await Create(new Client
            {
                Name = "Gitlab",
                Image = new Blob("~/Mocks/iconfinder_144_Gitlab_logo_logos_4373151.png")
            });

            await Create(new Client
            {
                Name = "Discord",
                Image = new Blob("~/Mocks/iconfinder_91_Discord_logo_logos_4373196.png")
            });

            await Create(new Client
            {
                Name = "Etsy",
                Image = new Blob("~/Mocks/iconfinder_117_Etsy_logo_logos_4373171.png")
            });
        }

        async Task CreateFeatures()
        {
            await Create(new Feature
            {
                Title = "Rapid Development",
                Description = "Duis at tellus at urna. Amet consectetur adipiscing elit ut aliquam purus sit amet luctus."
            });

            await Create(new Feature
            {
                Title = "Great Support",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cras pulvinar mattis nunc sed blandit libero volutpat sed cras. Commodo elit at imperdiet dui. In nibh mauris cursus mattis molestie a iaculis at erat. Commodo sed egestas egestas fringilla phasellus faucibus scelerisque."
            });

            await Create(new Feature
            {
                Title = "Fair Prices",
                Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            });

            await Create(new Feature
            {
                Title = "Professional Design",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
            });
        }

        async Task CreateSlides()
        {
            await Create(new Slide
            {
                Title = "Aleksey Kuprikov",
                Description = "Duis at tellus at urna. Amet consectetur adipiscing elit ut aliquam purus sit amet luctus.",
                Image = new Blob("~/Mocks/pexels-aleksey-kuprikov-3493777.jpg"),
                LinkUrl = @"https://www.pexels.com/",
                LinkText = "More shots",
                DisplayOrder = 1
            });

            await Create(new Slide
            {
                Title = "Francesco Ungaro",
                Description = "Ultrices eros in cursus turpis massa tincidunt dui ut. Odio ut sem nulla pharetra diam sit amet nisl. Pretium quam vulputate dignissim suspendisse in est ante in. Tincidunt nunc pulvinar sapien et ligula ullamcorper.",
                Image = new Blob("~/Mocks/pexels-francesco-ungaro-3854025.jpg"),
                LinkUrl = @"https://www.pexels.com/",
                LinkText = "More shots",
                DisplayOrder = 2
            });

            await Create(new Slide
            {
                Title = "Ian Beckley",
                Description = "Cursus euismod quis viverra nibh cras pulvinar mattis nunc sed.",
                Image = new Blob("~/Mocks/pexels-ian-beckley-2440024.jpg"),
                LinkUrl = @"https://www.pexels.com/",
                LinkText = "More shots",
                DisplayOrder = 3
            });

            await Create(new Slide
            {
                Title = "James Wheeler",
                Description = "Interdum velit euismod in pellentesque massa placerat duis ultricies.",
                Image = new Blob("~/Mocks/pexels-james-wheeler-417074.jpg"),
                LinkUrl = @"https://www.pexels.com/",
                LinkText = "More shots",
                DisplayOrder = 4
            });
        }

        async Task CreateTestimonies()
        {
            await Create(new Testimony
            {
                Name = "Chloe Thornhill",
                Position = "Social Media Manager",
                Content = "Leo in vitae turpis massa sed elementum tempus egestas sed. Sit amet est placerat in egestas erat. Volutpat est velit egestas dui id ornare.",
                Image = new Blob("~/Mocks/laura-chouette-nkWnc-W_GP8-unsplash.jpg"),
                DisplayOrder = 1
            });

            await Create(new Testimony
            {
                Name = "James Pitt",
                Position = "Human Resources Specialist",
                Content = "Interdum velit laoreet id donec ultrices tincidunt. Pharetra magna ac placerat vestibulum lectus mauris ultrices eros. Tortor condimentum lacinia quis vel eros donec ac.",
                Image = new Blob("~/Mocks/vince-fleming-j3lf-Jn6deo-unsplash.jpg"),
                DisplayOrder = 2
            });

            await Create(new Testimony
            {
                Name = "Molly Parker",
                Position = "CEO",
                Content = "Mauris rhoncus aenean vel elit scelerisque mauris pellentesque. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Velit laoreet id donec ultrices.",
                Image = new Blob("~/Mocks/thought-catalog-F3Y8BfZn4jo-unsplash.jpg"),
                DisplayOrder = 3
            });

            await Create(new Testimony
            {
                Name = "Rachel Barker",
                Position = "Program Manager",
                Content = "Vitae congue mauris rhoncus aenean vel elit scelerisque. Non blandit massa enim nec.",
                Image = new Blob("~/Mocks/christina-wocintechchat-com-z5SOVx-y3F4-unsplash.jpg"),
                DisplayOrder = 4
            });
        }

        Task CreateAdmin()
        {
            var pass = SecurePassword.Create("test");
            return Create(new Administrator
            {
#pragma warning disable GCop646 // Email addresses should not be hard-coded. Move this to Settings table or Config file.
                Email = "m.sadegh.sh@gmail.com",
#pragma warning restore GCop646 // Email addresses should not be hard-coded. Move this to Settings table or Config file.
                FirstName = "Mohammad Sadegh",
                LastName = "Shad",
                Password = pass.Password,
                Salt = pass.Salt
            });
        }
    }
}