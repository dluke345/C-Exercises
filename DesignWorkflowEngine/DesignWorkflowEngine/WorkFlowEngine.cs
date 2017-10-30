using System.Collections.Generic;

namespace DesignWorkflowEngine
{
    public class WorkFlowEngine
    {
        private readonly List<IActivity> _activities = new List<IActivity>();

        //public WorkFlowEngine(IActivity activity)
        //{
        //    _activity = activity;
        //}

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }
        
        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }
    }
}