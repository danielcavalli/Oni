using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public void LoadScene() {
        Application.LoadLevel(Application.loadedLevel + 1);
	}
}
