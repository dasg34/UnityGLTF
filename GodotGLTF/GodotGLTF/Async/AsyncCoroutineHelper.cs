﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GodotGLTF
{
    //FIXME : ALL!!!
    public class AsyncCoroutineHelper //: MonoBehaviour
    {
        public float BudgetPerFrameInSeconds = 0.01f;

        //private WaitForEndOfFrame _waitForEndOfFrame = new WaitForEndOfFrame();
        private float _timeout;

        public async Task YieldOnTimeout()
        {
            /*
            if (Time.realtimeSinceStartup > _timeout)
            {
                await Task.Delay(1);
                _timeout = Time.realtimeSinceStartup + BudgetPerFrameInSeconds;
            }
            */
        }

        private void Start()
        {
            /*
            _timeout = Time.realtimeSinceStartup + BudgetPerFrameInSeconds;

            StartCoroutine(ResetFrameTimeout());
            */
        }

        private IEnumerator ResetFrameTimeout()
        {
            /*
            while (true)
            {
                yield return _waitForEndOfFrame;
                _timeout = Time.realtimeSinceStartup + BudgetPerFrameInSeconds;
            }
            */
            yield return null;
        }
    }
}
