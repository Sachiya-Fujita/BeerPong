using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx_MVRP;
using UnityEngine.UI;
using System;
using UniRx;

public class MenuView : View
{
	[SerializeField]
	private Button _easyButton;
	public Button EasyButton { get => _easyButton; }

	[SerializeField]
	private Button _normalButton;
	public Button NormalButton { get => _normalButton; }

	[SerializeField]
	private Button _hardButton;
	public Button HardButton { get => _hardButton; }

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

