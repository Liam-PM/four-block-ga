using System.Collections.Generic;
using game.service;

namespace game.logic.EventQueue
{
    /// <summary>
    /// Represents a queue system for managing game events.
    /// This class implements the IService interface and provides methods for enqueueing, 
    /// dequeueing, and checking the status of events organized by their EventId.
    /// </summary>
    public class EventQueue : IService
    {
        private Dictionary<EventId, Queue<IEvent>> _queues;
        
        /// <summary>
        /// Gets the size of the queue for a specific EventId.
        /// </summary>
        /// <param name="id">The EventId to check.</param>
        /// <returns>The number of events in the queue for the specified EventId, or 0 if the queue doesn't exist.</returns>
        public int QueueSize(EventId id) => _queues.ContainsKey(id) ? _queues[id].Count : 0;
        
        /// <summary>
        /// Checks if all event queues are empty.
        /// </summary>
        /// <returns>True if there are no event queues, false otherwise.</returns>
        public bool IsEmpty() => _queues.Count == 0;
        
        /// <summary>
        /// Initializes a new instance of the EventQueue class.
        /// </summary>
        public EventQueue()
        {
            _queues = new Dictionary<EventId, Queue<IEvent>>();
        }
        
        /// <summary>
        /// Adds an event to its corresponding queue based on its EventId.
        /// </summary>
        /// <param name="e">The event to be enqueued.</param>
        public void Enqueue(IEvent e)
        {
            // If the queue for this EventId doesn't exist, create it
            if (!_queues.ContainsKey(e.Id))
            {
                _queues[e.Id] = new Queue<IEvent>();
            }
            // Add the event to its corresponding queue
            _queues[e.Id].Enqueue(e);
        }

        /// <summary>
        /// Checks if there are any events in the queue for a specific EventId.
        /// </summary>
        /// <param name="id">The EventId to check.</param>
        /// <returns>True if there are events in the queue for the specified EventId, false otherwise.</returns>
        public bool HasEvent(EventId id) => _queues.ContainsKey(id) && _queues[id].Count > 0;

        /// <summary>
        /// Removes and returns the next event from the queue for a specific EventId.
        /// </summary>
        /// <param name="id">The EventId of the queue to dequeue from.</param>
        /// <returns>The next IEvent in the queue, or null if the queue is empty or doesn't exist.</returns>
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
