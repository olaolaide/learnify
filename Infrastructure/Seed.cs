using Entity;

namespace Infrastructure
{
    public static class Seed
    {
        public static async Task SeedData(StoreContext context)
        {
            if (context.Courses.Any()) return;

            List<Category> categories =
            [
                new Category { Id = 1, Name = "IT & Software" },
                new Category { Id = 2, Name = "Languages" },
                new Category { Id = 3, Name = "Music" },
                new Category { Id = 4, Name = "Productivity" },
                new Category { Id = 5, Name = "Marketing" },
                new Category { Id = 6, Name = "Business" }
            ];

            List<Course> courses =
            [
                new Course
                {
                    Id = Guid.Parse("C7E9B43A-DCAD-4993-BE11-3960EE7BE39D"),
                    Title = "Fullstack React with Typescript: Become a frontend Master",
                    Price = 29.99f,
                    Instructor = "Chirag Kalra",
                    Rating = 4.7m,
                    Image = "https://learnify-assets.s3.amazonaws.com/Images/react-typescript.png",
                    CategoryId = 1,
                    SubTitle = "Learn with fun",
                    Description = "This is the description placeholder",
                    Students = 20,
                    Level = "Beginner",
                    Language = "English"
                },

                new Course
                {
                    Id = Guid.Parse("2BBC0917-2BAE-4CC7-9675-95D0AAC03188"),
                    Title = "Fullstack Angular with a real world Application",
                    Price = 29.99f,
                    Instructor = "Chirag Kalra",
                    Rating = 4.5m,
                    Image = "https://learnify-assets.s3.amazonaws.com/Images/fullstack-angular.png",
                    CategoryId = 1,
                    SubTitle = "Learn with fun",
                    Description = "This is the description placeholder",
                    Students = 20,
                    Level = "Beginner",
                    Language = "English"
                },

                new Course
                {
                    Id = Guid.Parse("41E0EB01-5715-4376-912C-49FE04357CC5"),
                    Title = "Backend with Node JS: Write your own server",
                    Price = 16.99f,
                    Instructor = "Chirag Kalra",
                    Rating = 4.4m,
                    Image = "https://learnify-assets.s3.amazonaws.com/Images/backend-with-node.png",
                    CategoryId = 1,
                    SubTitle = "Learn with fun",
                    Description = "This is the description placeholder",
                    Students = 20,
                    Level = "Beginner",
                    Language = "English"
                },

                new Course
                {
                    Id = Guid.Parse("05FC1EFB-83E5-4042-B494-FD30D759AD1C"),
                    Title = "Vue JS for beginners: Start your Web dev journey",
                    Price = 11.99f,
                    Instructor = "Chirag Kalra",
                    Rating = 4.6m,
                    Image = "https://learnify-assets.s3.amazonaws.com/Images/vue-for-beginners.png",
                    CategoryId = 1,
                    SubTitle = "Learn with fun",
                    Description = "This is the description placeholder",
                    Students = 20,
                    Level = "Beginner",
                    Language = "English"
                },

                new Course
                {
                    Id = Guid.Parse("5B347C34-782B-45F9-ACCC-DDF69FEA8AF2"),
                    Title = "Docker and Kubernetes: Become a container expert",
                    Price = 29.99f,
                    Instructor = "Chirag Kalra",
                    Rating = 4.9m,
                    Image = "https://learnify-assets.s3.amazonaws.com/Images/docker-kubernetes.png",
                    CategoryId = 1,
                    SubTitle = "Learn with fun",
                    Description = "This is the description placeholder",
                    Students = 20,
                    Level = "Beginner",
                    Language = "English"
                },

                new Course
                {
                    Id = Guid.Parse("D56DE15C-3672-4849-BF0A-5D4A5F6258A5"),
                    Title = "Fullstack Python with Django: Become a Python expert",
                    Price = 34.99f,
                    Instructor = "Chirag Kalra",
                    Rating = 4.5m,
                    Image = "https://learnify-assets.s3.amazonaws.com/Images/python-django.png",
                    CategoryId = 1,
                    SubTitle = "Learn with fun",
                    Description = "This is the description placeholder",
                    Students = 20,
                    Level = "Beginner",
                    Language = "English"
                },

                new Course
                {
                    Id = Guid.Parse("A8A4121F-CA35-4B26-8599-2170731369DF"),
                    Title = "Introduction to Java servlets",
                    Price = 19.99f,
                    Instructor = "Chirag Kalra",
                    Rating = 4.5m,
                    Image = "https://learnify-assets.s3.amazonaws.com/Images/java-servlets.png",
                    CategoryId = 1,
                    SubTitle = "Learn with fun",
                    Description = "This is the description placeholder",
                    Students = 20,
                    Level = "Beginner",
                    Language = "English"
                },

                new Course
                {
                    Id = Guid.Parse("6D0D3733-9E2E-4339-B507-56673EF7D7A8"),
                    Title = "Data Structures and Algorithms: Crack SDE Interviews",
                    Price = 29.99f,
                    Instructor = "Chirag Kalra",
                    Rating = 4.9m,
                    Image = "https://learnify-assets.s3.amazonaws.com/Images/ds-algo.png",
                    CategoryId = 1,
                    SubTitle = "Learn with fun",
                    Description = "This is the description placeholder",
                    Students = 20,
                    Level = "Beginner",
                    Language = "English"
                },

                new Course
                {
                    Id = Guid.Parse("8E3E7399-D478-4A45-A2A5-B13B8C286A68"),
                    Title = "Become an AWS certified Developer",
                    Price = 24.99f,
                    Instructor = "Chirag Kalra",
                    Rating = 4.8m,
                    Image = "https://learnify-assets.s3.amazonaws.com/Images/aws-developer.png",
                    CategoryId = 1,
                    SubTitle = "Learn with fun",
                    Description = "This is the description placeholder",
                    Students = 20,
                    Level = "Beginner",
                    Language = "English"
                }
            ];

            // Seed Requirements
            var requirements = new List<Requirement>
            {
                new Requirement
                {
                    Id = 1,
                    Name = "Have a Computer",
                    CourseId = Guid.Parse("C7E9B43A-DCAD-4993-BE11-3960EE7BE39D")
                },
                new Requirement
                {
                    Id = 2,
                    Name = "Willingness to Learn",
                    CourseId = Guid.Parse("C7E9B43A-DCAD-4993-BE11-3960EE7BE39D")
                },
                new Requirement
                {
                    Id = 3,
                    Name = "Positive Attitude",
                    CourseId = Guid.Parse("C7E9B43A-DCAD-4993-BE11-3960EE7BE39D")
                },
                new Requirement
                {
                    Id = 4,
                    Name = "Have a Computer",
                    CourseId = Guid.Parse("D56DE15C-3672-4849-BF0A-5D4A5F6258A5")
                },
                new Requirement
                {
                    Id = 5,
                    Name = "Willingness to Learn",
                    CourseId = Guid.Parse("D56DE15C-3672-4849-BF0A-5D4A5F6258A5")
                },
                new Requirement
                {
                    Id = 6,
                    Name = "Positive Attitude",
                    CourseId = Guid.Parse("D56DE15C-3672-4849-BF0A-5D4A5F6258A5")
                },
                new Requirement
                {
                    Id = 7,
                    Name = "Have a Computer",
                    CourseId = Guid.Parse("5B347C34-782B-45F9-ACCC-DDF69FEA8AF2")
                },
                new Requirement
                {
                    Id = 8,
                    Name = "Willingness to Learn",
                    CourseId = Guid.Parse("5B347C34-782B-45F9-ACCC-DDF69FEA8AF2")
                },
                new Requirement
                {
                    Id = 9,
                    Name = "Positive Attitude",
                    CourseId = Guid.Parse("5B347C34-782B-45F9-ACCC-DDF69FEA8AF2")
                },
                new Requirement
                {
                    Id = 10,
                    Name = "Have a Computer",
                    CourseId = Guid.Parse("05FC1EFB-83E5-4042-B494-FD30D759AD1C")
                },
                new Requirement
                {
                    Id = 11,
                    Name = "Willingness to Learn",
                    CourseId = Guid.Parse("05FC1EFB-83E5-4042-B494-FD30D759AD1C")
                },
                new Requirement
                {
                    Id = 12,
                    Name = "Positive Attitude",
                    CourseId = Guid.Parse("05FC1EFB-83E5-4042-B494-FD30D759AD1C")
                },
                new Requirement
                {
                    Id = 13,
                    Name = "Have a Computer",
                    CourseId = Guid.Parse("41E0EB01-5715-4376-912C-49FE04357CC5")
                },
                new Requirement
                {
                    Id = 14,
                    Name = "Willingness to Learn",
                    CourseId = Guid.Parse("41E0EB01-5715-4376-912C-49FE04357CC5")
                },
                new Requirement
                {
                    Id = 15,
                    Name = "Positive Attitude",
                    CourseId = Guid.Parse("41E0EB01-5715-4376-912C-49FE04357CC5")
                },
                new Requirement
                {
                    Id = 16,
                    Name = "Have a Computer",
                    CourseId = Guid.Parse("2BBC0917-2BAE-4CC7-9675-95D0AAC03188")
                },
                new Requirement
                {
                    Id = 17,
                    Name = "Willingness to Learn",
                    CourseId = Guid.Parse("2BBC0917-2BAE-4CC7-9675-95D0AAC03188")
                },
                new Requirement
                {
                    Id = 18,
                    Name = "Positive Attitude",
                    CourseId = Guid.Parse("2BBC0917-2BAE-4CC7-9675-95D0AAC03188")
                },
                new Requirement
                {
                    Id = 19,
                    Name = "Have a Computer",
                    CourseId = Guid.Parse("A8A4121F-CA35-4B26-8599-2170731369DF")
                },
                new Requirement
                {
                    Id = 20,
                    Name = "Willingness to Learn",
                    CourseId = Guid.Parse("A8A4121F-CA35-4B26-8599-2170731369DF")
                },
                new Requirement
                {
                    Id = 21,
                    Name = "Positive Attitude",
                    CourseId = Guid.Parse("A8A4121F-CA35-4B26-8599-2170731369DF")
                },
                new Requirement
                {
                    Id = 22,
                    Name = "Have a Computer",
                    CourseId = Guid.Parse("6D0D3733-9E2E-4339-B507-56673EF7D7A8")
                },
                new Requirement
                {
                    Id = 23,
                    Name = "Willingness to Learn",
                    CourseId = Guid.Parse("6D0D3733-9E2E-4339-B507-56673EF7D7A8")
                },
                new Requirement
                {
                    Id = 24,
                    Name = "Positive Attitude",
                    CourseId = Guid.Parse("6D0D3733-9E2E-4339-B507-56673EF7D7A8")
                },
                new Requirement
                {
                    Id = 25,
                    Name = "Have a Computer",
                    CourseId = Guid.Parse("8E3E7399-D478-4A45-A2A5-B13B8C286A68")
                },
                new Requirement
                {
                    Id = 26,
                    Name = "Willingness to Learn",
                    CourseId = Guid.Parse("8E3E7399-D478-4A45-A2A5-B13B8C286A68")
                },
                new Requirement
                {
                    Id = 27,
                    Name = "Positive Attitude",
                    CourseId = Guid.Parse("8E3E7399-D478-4A45-A2A5-B13B8C286A68")
                }
            };


            var learnings = new List<Learning>
            {
                new Learning
                {
                    Id = 1, Name = "Understand the fundamentals of React",
                    CourseId = Guid.Parse("C7E9B43A-DCAD-4993-BE11-3960EE7BE39D")
                },
                new Learning
                {
                    Id = 2, Name = "Master TypeScript for React development",
                    CourseId = Guid.Parse("C7E9B43A-DCAD-4993-BE11-3960EE7BE39D")
                },
                new Learning
                {
                    Id = 3, Name = "Build full-stack applications with React",
                    CourseId = Guid.Parse("C7E9B43A-DCAD-4993-BE11-3960EE7BE39D")
                },
                new Learning
                {
                    Id = 4, Name = "Being able to speak Spanish Quickly",
                    CourseId = Guid.Parse("D56DE15C-3672-4849-BF0A-5D4A5F6258A5")
                },
                new Learning
                {
                    Id = 5, Name = "You'll be able to understand the grammar",
                    CourseId = Guid.Parse("D56DE15C-3672-4849-BF0A-5D4A5F6258A5")
                },
                new Learning
                {
                    Id = 6, Name = "You'll be able to understand Spanish music",
                    CourseId = Guid.Parse("D56DE15C-3672-4849-BF0A-5D4A5F6258A5")
                },
                new Learning
                {
                    Id = 7, Name = "Being able to speak Spanish Quickly",
                    CourseId = Guid.Parse("5B347C34-782B-45F9-ACCC-DDF69FEA8AF2")
                },
                new Learning
                {
                    Id = 8, Name = "You'll be able to understand the grammar",
                    CourseId = Guid.Parse("5B347C34-782B-45F9-ACCC-DDF69FEA8AF2")
                },
                new Learning
                {
                    Id = 9, Name = "You'll be able to understand Spanish music",
                    CourseId = Guid.Parse("5B347C34-782B-45F9-ACCC-DDF69FEA8AF2")
                },
                new Learning
                {
                    Id = 10, Name = "Being able to speak Spanish Quickly",
                    CourseId = Guid.Parse("05FC1EFB-83E5-4042-B494-FD30D759AD1C")
                },
                new Learning
                {
                    Id = 11, Name = "You'll be able to understand the grammar",
                    CourseId = Guid.Parse("05FC1EFB-83E5-4042-B494-FD30D759AD1C")
                },
                new Learning
                {
                    Id = 12, Name = "You'll be able to understand Spanish music",
                    CourseId = Guid.Parse("05FC1EFB-83E5-4042-B494-FD30D759AD1C")
                },
                new Learning
                {
                    Id = 13, Name = "Being able to speak Spanish Quickly",
                    CourseId = Guid.Parse("41E0EB01-5715-4376-912C-49FE04357CC5")
                },
                new Learning
                {
                    Id = 14, Name = "You'll be able to understand the grammar",
                    CourseId = Guid.Parse("41E0EB01-5715-4376-912C-49FE04357CC5")
                },
                new Learning
                {
                    Id = 15, Name = "You'll be able to understand Spanish music",
                    CourseId = Guid.Parse("41E0EB01-5715-4376-912C-49FE04357CC5")
                },
                new Learning
                {
                    Id = 16, Name = "Being able to speak Spanish Quickly",
                    CourseId = Guid.Parse("2BBC0917-2BAE-4CC7-9675-95D0AAC03188")
                },
                new Learning
                {
                    Id = 17, Name = "You'll be able to understand the grammar",
                    CourseId = Guid.Parse("2BBC0917-2BAE-4CC7-9675-95D0AAC03188")
                },
                new Learning
                {
                    Id = 18, Name = "You'll be able to understand Spanish music",
                    CourseId = Guid.Parse("2BBC0917-2BAE-4CC7-9675-95D0AAC03188")
                },
                new Learning
                {
                    Id = 19, Name = "Being able to speak Spanish Quickly",
                    CourseId = Guid.Parse("C7E9B43A-DCAD-4993-BE11-3960EE7BE39D")
                },
                new Learning
                {
                    Id = 20, Name = "You'll be able to understand the grammar",
                    CourseId = Guid.Parse("C7E9B43A-DCAD-4993-BE11-3960EE7BE39D")
                },
                new Learning
                {
                    Id = 21, Name = "You'll be able to understand Spanish music",
                    CourseId = Guid.Parse("C7E9B43A-DCAD-4993-BE11-3960EE7BE39D")
                },
                new Learning
                {
                    Id = 22, Name = "Being able to speak Spanish Quickly",
                    CourseId = Guid.Parse("A8A4121F-CA35-4B26-8599-2170731369DF")
                },
                new Learning
                {
                    Id = 23, Name = "You'll be able to understand the grammar",
                    CourseId = Guid.Parse("A8A4121F-CA35-4B26-8599-2170731369DF")
                },
                new Learning
                {
                    Id = 24, Name = "You'll be able to understand Spanish music",
                    CourseId = Guid.Parse("A8A4121F-CA35-4B26-8599-2170731369DF")
                },
                new Learning
                {
                    Id = 25, Name = "Being able to speak Spanish Quickly",
                    CourseId = Guid.Parse("6D0D3733-9E2E-4339-B507-56673EF7D7A8")
                },
                new Learning
                {
                    Id = 26, Name = "You'll be able to understand the grammar",
                    CourseId = Guid.Parse("6D0D3733-9E2E-4339-B507-56673EF7D7A8")
                },
                new Learning
                {
                    Id = 27, Name = "You'll be able to understand Spanish music",
                    CourseId = Guid.Parse("6D0D3733-9E2E-4339-B507-56673EF7D7A8")
                },
                new Learning
                {
                    Id = 28, Name = "Being able to speak Spanish Quickly",
                    CourseId = Guid.Parse("8E3E7399-D478-4A45-A2A5-B13B8C286A68")
                },
                new Learning
                {
                    Id = 29, Name = "You'll be able to understand the grammar",
                    CourseId = Guid.Parse("8E3E7399-D478-4A45-A2A5-B13B8C286A68")
                },
                new Learning
                {
                    Id = 30, Name = "You'll be able to understand Spanish music",
                    CourseId = Guid.Parse("8E3E7399-D478-4A45-A2A5-B13B8C286A68")
                }
            };


            // Add entities to the context
            await context.Courses.AddRangeAsync(courses);
            await context.Categories.AddRangeAsync(categories);
            await context.Requirements.AddRangeAsync(requirements);
            await context.Learnings.AddRangeAsync(learnings);

            // Save changes to the database
            await context.SaveChangesAsync();
        }
    }
}