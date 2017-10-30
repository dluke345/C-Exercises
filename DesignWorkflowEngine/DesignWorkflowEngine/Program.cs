using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignWorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlowEngine();
            workflow.Add(new VideoUpload("VideoName"));
            workflow.Add(new VideoEmailNotification("VideoName"));
            workflow.Add(new VideoEncoding("VideoName"));
            workflow.Add(new VideoStatus("VideoName"));
            workflow.Run();
        }
    }
}
