using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx_MVRP;
using UnityEngine.UI;
using System;
using UniRx;

public class UiView : View
{
	[SerializeField]
	private Button _homeButton;
	public Button HomeButton { get => _homeButton; }

	[SerializeField]
	private Button _testButton;
	public Button TestButton { get => _testButton; }

	[SerializeField]
	private Button _resetButton;
	public Button ResetButton { get => _resetButton; }

	[SerializeField]
	private GameObject _pingPong;
	public GameObject PingPong { get => _pingPong; }

	public override void OnAwake()
	{
		Debug.Log("Awakes");
		BindAsync();
	}

	public override void OnStart()
	{
		Debug.Log("Start");
	}

	private IObservable<Unit> BindAsync()
	{
		//_homeButton.OnSafeClickAsObservable()
		//	.Subscribe(_ => SceneUtility.Instance.OnButton("Menu"))
		//	.AddTo(this);

		//_testButton.OnSafeClickAsObservable()
		//	.Subscribe(_ => Debug.Log("test"))
		//	.AddTo(this);

		//_resetButton.OnSafeClickAsObservable()
		//	.Subscribe(_ => Debug.Log("test"))
		//	.AddTo(this);

		return Observable.Return(Unit.Default);
	}

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
}
