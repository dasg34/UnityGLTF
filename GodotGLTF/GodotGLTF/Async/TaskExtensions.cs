﻿using System.Collections;
using System.Threading.Tasks;

namespace GodotGLTF
{
	public static class TaskExtensions
	{
		public static IEnumerator AsCoroutine(this Task task)
		{
			while (!task.IsCompleted)
			{
				yield return null;
			}
		}
	}
}
