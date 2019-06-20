using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneUtility : SingletonMonoBehaviour<SceneUtility>
{
    // Start is called before the first frame update
    void Start()
    {
		DontDestroyOnLoad(this.gameObject);
	}

	public void OnButton(string btnName)
	{
		Debug.Log(btnName);
		if (string.IsNullOrEmpty(btnName))
		{
			btnName = EventSystem.current.currentSelectedGameObject.name;
		}
		Debug.Log("OnButton(). btnName = " + btnName);

		switch (btnName)
		{
			case "TopPage":
				SceneManager.LoadScene("Menu");
				break;
		}
	}
}
