using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;
using UnityEngine.UI;

namespace UniRx
{
	public static partial class UnityEventExtensions
	{
		private static TimeSpan Timedue = TimeSpan.FromMilliseconds(500);
		/// <summary>Observe onClick event.</summary>
		public static IObservable<Unit> OnSafeClickAsObservable(this Button button)
		{
			return button.onClick.AsObservable().ThrottleFirst(Timedue);
		}
	}
}

namespace UniRx_MVRP
{
    public abstract class Presenter : MonoBehaviour
    {
        protected AsyncSubject<Unit> _ready
            = new AsyncSubject<Unit>();

        protected IObserver<Unit> ReadyAsync
        {
            get { return _ready; }
        }

		protected AsyncSubject<Unit> _doneSetup
			= new AsyncSubject<Unit>();

		protected IObserver<Unit> DoneSetup
		{
			get { return _doneSetup; }
		}

		List<Model> models = new List<Model>();

		protected CompositeDisposable disposables = new CompositeDisposable();

		public abstract IObservable<Unit> BindAsync();

		protected IObservable<Unit> InitializeAsync()
		{
			if (disposables.Count > 0)
			{
				return Observable
					.WhenAll();
			}
			else
			{
				return Observable.Return(Unit.Default);
			}
		}

		protected void Add(Model model)
		{
			models.Add(model);
		}

		protected void Dispose()
		{
		}
    }
}

