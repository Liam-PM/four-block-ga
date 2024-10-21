using System.Collections.Generic;
using game.service;

namespace game.logic.EventQueue
{
    public class EventQueue: IService
    {
        private Dictionary<EventId, Queue<IEvent>> _queues;
        
        public int QueueSize(EventId id) => _queues.ContainsKey(id) ? _queues[id].Count : 0;
        
        public EventQueue()
        {
            _queues = new Dictionary<EventId, Queue<IEvent>>();
        }
        
        public void Enqueue(IEvent e)
        {
            if(!_queues.ContainsKey(e.Id))
            {
                _queues[e.Id] = new Queue<IEvent>();
            }
            _queues[e.Id].Enqueue(e);
        }

        public bool HasEvent(EventId id) => _queues.ContainsKey(id) && _queues[id].Count > 0;

        public IEvent Dequeue(EventId id)
        {
            if (HasEvent(id))
            {
                return _queues[id].Dequeue();
            }
            return null;
        }
    }
}