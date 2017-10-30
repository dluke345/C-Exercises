using System;

namespace DesignWorkflowEngine
{
    public class VideoEncoding : IActivity
    {
        private readonly string _video;

        public VideoEncoding(string video)
        {
            _video = video;
        }

        public void Execute()
        {
            Console.WriteLine("Video is ready for encoding: " + _video);
        }
    }
}