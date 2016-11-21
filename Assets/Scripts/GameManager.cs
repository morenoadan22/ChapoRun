using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private static GameManager instance = null;

	public static GameManager Instance {
		get { return instance; }
	}

	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} 
		else
		{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

}

