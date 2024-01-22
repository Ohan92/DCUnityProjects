using UnityEngine;

namespace Lesson5
{
    public class ConsoleLogger : AbstractLogger
    {
        [SerializeField] private ReactiveLogger reactiveLogger;

        private void OnEnable()
        {
            if (reactiveLogger != null)
            {
                reactiveLogger.OnLog += Print;
            }
        }

        private void OnDisable()
        {
            if (reactiveLogger != null)
            {
                reactiveLogger.OnLog -= Print;
            }
        }

        public override void Print(LogType type, string message)
        {
            if (type == logType)
            {
                Debug.Log($"[Console] [{type}] {message}");
            }
        }
    }
}
