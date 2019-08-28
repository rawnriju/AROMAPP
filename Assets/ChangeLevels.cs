using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevels : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("ChangeLevel", 3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   void ChangeLevel()
    {
        SceneManager.LoadScene(1);
    }


}

