using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx_MVRP;
using System;
using UniRx;

public class UiModel : Model
{
	private ReactiveProperty<Unit> _confirm
		= new ReactiveProperty<Unit>();
	public IObservable<Unit> OnConfirm
	{
		get { return _confirm; }
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
