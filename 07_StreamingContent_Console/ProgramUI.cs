using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();

        public void Run()
        {
            SeedData();
            RunMenu();
        }

        private void RunMenu()
        {
            //Create a menu with options matching up to my repository
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine
                    (
                        "Enter the number of your selection:\n" +
                        "1. Create new streaming content\n" +
                        "2. Show all streaming content\n" +
                        "3. Find streaming content by title\n" +
                        "4. Update content by title\n" +
                        "5. Remove content\n" +
                        "6. Exit"
                    );
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //Create Content
                        CreateNewContent();
                        break;
                    case "2":
                        //Get all content
                        ShowAllContent();
                        break;
                    case "3":
                        //Get specific content (by title)
                        ShowContentByTitle();
                        break;
                    case "4":
                        //Update Content
                        break;
                    case "5":
                        //Deleting Content
                        break;
                    case "6":
                        //Exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 6");
                        Console.ReadKey();
                        break;
                }
            }

        }

        //CreatingContent
        private void CreateNewContent()
        {
            Console.Clear();

            StreamingContent content = new StreamingContent();

            //Title
            Console.WriteLine("Please enter a title:");
            content.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Please enter a description:");
            content.Description = Console.ReadLine();

            //Runtime
            Console.WriteLine("Please enter the contents runtime:");
            content.RunTime = Convert.ToDouble(Console.ReadLine());

            //Review Rating
            Console.WriteLine("Please enter the contents review score? (0 - 10):");
            content.ReviewRating = double.Parse(Console.ReadLine());

            //Maturity Rating
            Console.WriteLine("Select a maturity rating:" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. NC-17\n" +
                "6. NR");

            string maturityRatingString = Console.ReadLine();

            int maturityratingID = int.Parse(maturityRatingString);
            content.RatingMaturity = (MaturityRating)maturityratingID;

            //Genre
            Console.WriteLine("Please enter the contents genre:");
            content.Genre = Console.ReadLine();

            _repo.AddContentToDirectory(content);

            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(content);

        }
        //GettingAllContent
        private void ShowAllContent()
        {
            //Clean Slate
            Console.Clear();

            List<StreamingContent> listOfContent = _repo.GetContents();

            foreach (StreamingContent content in listOfContent)
            {
                //Using helper method
                DisplayContent(content);
            }

            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
        }

        //Get Content By Title
        private void ShowContentByTitle()
        {
            Console.Clear();

            Console.WriteLine("What title are you looking for?");
            string title = Console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            //Verify that content is in our repository
            if (content != null)
            {

                DisplayContent(content);

                Console.WriteLine("Press any key to contine...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Could not find content with that title.");
                Console.ReadKey();
            }

        }
        //Update Content

        //Implement Update


        //Helper Methods
        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"" +
                    $"Title: {content.Title}\n" +
                    $"Decription: {content.Description}\n" +
                    $"Runtime: {content.RunTime}\n" +
                    $"Review Score: {content.ReviewRating}\n" +
                    $"Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Maturity Rating: {content.RatingMaturity}\n" +
                    $"Genre: {content.Genre}\n\n");
        }

        //Seed Method
        private void SeedData()
        {
            StreamingContent starWars = new StreamingContent("Star Wars", "I mean it's a lot to say here.", 2.5, 9.9, "SciFi", MaturityRating.PG);
            StreamingContent matrix = new StreamingContent("The Matrix", "Some crazy bullet dodgin shit.", 2.2, 9.0, "SciFi Drama", MaturityRating.R);
            StreamingContent stripes = new StreamingContent("Stripes", "Bill Murray joins the Army.", 1.5, 9.1, "Comedy", MaturityRating.R);

            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(matrix);
            _repo.AddContentToDirectory(stripes);

        }

    }
}
