using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThorwBall : MonoBehaviour
{
	private Vector3 moveTo;

	private bool beRay = false;

	private Camera _camera;

	private Vector2 movePos;

	private Vector3 initialPos;

	private Rigidbody _rigid;

	private bool isUI = false;

	// Use this for initialization
	void Start()
	{
		_camera = Camera.main;

		_rigid = this.gameObject.GetComponent<Rigidbody>();

		initialPos = this.gameObject.transform.position;
		Debug.Log(initialPos);
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

		if (Input.GetMouseButtonUp(0) && isUI == false)
		{
			Debug.Log("");
			beRay = false;
			if (Mathf.Abs(movePos.x) > 0.1 || Mathf.Abs(movePos.y) > 0.1)
			{
				_rigid.isKinematic = false;
				Vector3 _addVector = new Vector3(movePos.x, movePos.y / Mathf.Sqrt(2.0f), movePos.y / Mathf.Sqrt(2.0f));
				_rigid.AddForce(_addVector * 10.0f, ForceMode.Impulse);
			}
			else
			{
				ResetPos();
			}
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

		if(hit.collider.tag == "PingPong")
		{
			isUI = false;
		}
		else
		{
			isUI = true;
		}
	}

	private void MovePoisition()
	{
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = -(_camera.transform.position.z - initialPos.z);

		moveTo = Camera.main.ScreenToWorldPoint(mousePos);
		transform.position = moveTo;
		movePos = new Vector2(moveTo.x - initialPos.x, moveTo.y - initialPos.y);
	}

	public void ResetPos()
	{
		_rigid.velocity = Vector3.zero;
		_rigid.isKinematic = true;
		this.gameObject.transform.position = initialPos;
		this.gameObject.transform.rotation = Quaternion.identity;

	}
}
