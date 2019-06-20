using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace UniRx_MVRP
{
	public abstract class View : MonoBehaviour
	{
		private void Awake()
		{
			OnAwake();
		}

		void Start()
		{
			OnStart();
		}

		public abstract void OnStart();

		public abstract void OnAwake();
	}
}