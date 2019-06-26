using System.Collections.Generic;
using UnityEngine;
using UniRx_MVRP;
using System;
using UniRx;

public class MenuManager: Presenter
{
	[SerializeField]
	private MenuView _view;

	[SerializeField]
	private MenuModel model;

	public override IObservable<Unit> BindAsync()
	{
		_view.EasyButton.OnSafeClickAsObservable()
			.Subscribe(_ => SceneUtility.Instance.OnButton("Easy"))
			.AddTo(this);

		_view.NormalButton.OnSafeClickAsObservable()
			.Subscribe(_ => SceneUtility.Instance.OnButton("Normal"))
			.AddTo(this);

		_view.HardButton.OnSafeClickAsObservable()
			.Subscribe(_ => SceneUtility.Instance.OnButton("Hard"))
			.AddTo(this);

		return Observable.Return(Unit.Default);
	}

	// Start is called before the first frame update
	void Start()
	{
		BindAsync();
	}

	// Update is called once per frame
	void Update()
	{

	}
}
