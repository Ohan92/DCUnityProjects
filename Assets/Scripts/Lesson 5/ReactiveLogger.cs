using System;
using System.Collections;
using UnityEngine;

namespace Lesson5
{
    public class ReactiveLogger : MonoBehaviour
    {
        public event Action<LogType, string> OnLog;

        private void Start()
        {
            StartCoroutine(SendLogs());
        }

        private IEnumerator SendLogs()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);

                OnLog?.Invoke(LogType.Log, "Log Message");
                yield return new WaitForSeconds(1f);
                OnLog?.Invoke(LogType.Warning, "Warning Message");
                yield return new WaitForSeconds(1f);
                OnLog?.Invoke(LogType.Error, "Error Message");
            }
        }
    }

}
