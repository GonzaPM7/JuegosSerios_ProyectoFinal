using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator LoadScene(string escena, int time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(escena);
    }
}
