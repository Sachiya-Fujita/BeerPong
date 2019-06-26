using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx_MVRP;
using System;
using UniRx;

public class UiManager : Presenter
{
	[SerializeField]
	private UiView _view;

	[SerializeField]
	private UiModel model;

	public override IObservable<Unit> BindAsync()
	{
		Debug.Log("Bind");
		_view.HomeButton.OnSafeClickAsObservable()
			.Subscribe(_ => SceneUtility.Instance.OnButton("Menu"))
			.AddTo(this);

		_view.ResetButton.OnSafeClickAsObservable()
			.Subscribe(_ => Debug.Log("reset"))//_view.PingPong.GetComponent<ThorwBall>().ResetPos())
			.AddTo(this);

		_view.TestButton.OnSafeClickAsObservable()
			.Subscribe(_ => Debug.Log("test"))
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
