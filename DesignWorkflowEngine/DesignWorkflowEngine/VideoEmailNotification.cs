using System;

namespace DesignWorkflowEngine
{
    public class VideoEmailNotification : IActivity
    {
        private readonly string _video;

        public VideoEmailNotification(string video)
        {
            _video = video;
        }

        public void Execute()
        {
            Console.WriteLine("Sending email to owner of video " + _video);
        }
    }
}