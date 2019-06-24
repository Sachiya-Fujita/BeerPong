using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThorwBall : MonoBehaviour
{
	private Vector3 moveTo;

	private bool beRay = false;

	private Camera _camera;

	[SerializeField]
	private GameObject _pingPong;

	private Vector3 initialPos;

	// Use this for initialization
	void Start()
	{
		_camera = Camera.main;

		initialPos = _pingPong.transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			RayCheck();
		}

		if (beRay)
		{
			MovePoisition();
		}

		if (Input.GetMouseButtonUp(0))
		{
			beRay = false;
		}
	}

	private void RayCheck()
	{
		Ray ray = new Ray();
		RaycastHit hit = new RaycastHit();
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity) && hit.collider == gameObject.GetComponent<Collider>())
		{
			beRay = true;
		}
		else
		{
			beRay = false;
		}

	}

	private void MovePoisition()
	{
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = -(_camera.transform.position.z - initialPos.z);

		moveTo = Camera.main.ScreenToWorldPoint(mousePos);
		Debug.Log(moveTo);
		transform.position = moveTo;
	}
}
