using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.Mocking
{
    public interface IVideoRepository
    {
        IEnumerable<Video> GetUnProcessedVideos();
    }

    // This video repository encapsulates the code that touches on external resources in VideoService
    public class VideoRepository : IVideoRepository
    {
        // IEnumerable enables iteration
        public IEnumerable<Video> GetUnProcessedVideos()
        {
            using (var context = new VideoContext())
            {
                // Touching external resource, so must be isolated
                var videos =
                (from video in context.Videos
                 where !video.IsProcessed
                 select video).ToList();

                return videos;
            }
        }
    }
}
