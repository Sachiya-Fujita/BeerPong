using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace UniRx_MVRP
{
	public abstract class Model : System.IDisposable
	{
		CompositeDisposable disposables = new CompositeDisposable();

		public void Dispose()
		{
			disposables.Dispose();
		}

		protected void InitializeAsync()
		{

		}
	}
}
