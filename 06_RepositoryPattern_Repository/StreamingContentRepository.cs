using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    //Repository Pattern
    //CRUD
    //Create
    //Read
    //Update
    //Delete
    public class StreamingContentRepository
    {
        //Field
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Crerate
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        //Get By Title
        public StreamingContent GetContentByTitle(string theTitleWeAreLookingFor)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == theTitleWeAreLookingFor.ToLower())
                {
                    return content;  
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingContent(StreamingContent existingContent, StreamingContent newContent)
        {
            if (existingContent != null)
            {
                existingContent.Title = newContent.Title;
                existingContent.Description = newContent.Description;
                existingContent.ReviewRating = newContent.ReviewRating;
                existingContent.RatingMaturity = newContent.RatingMaturity;
                existingContent.RunTime = newContent.RunTime;
                existingContent.Genre = newContent.Genre;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        //Bool because I want to know whether you actually deleted it or not
        public bool DeleteContent(StreamingContent existingContent)
        {
            bool result = _contentDirectory.Remove(existingContent);
            return result;
        }
    }
}
