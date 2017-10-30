using System;

namespace DesignWorkflowEngine
{
    public class VideoStatus : IActivity
    {
        private readonly string _video;

        public VideoStatus(string video)
        {
            _video = video;
        }
        public void Execute()
        {
            Console.WriteLine("Video status changed to processing: " + _video);
        }
    }
}