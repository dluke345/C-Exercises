using System;

namespace DesignWorkflowEngine
{
    public class VideoUpload : IActivity
    {
        private readonly string _video;

        public VideoUpload(string video)
        {
            _video = video;
        }

        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud storage: " + _video);
        }
    }
}