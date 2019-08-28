using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotheAR : MonoBehaviour {
    public Button b;

	// Use this for initialization
	void Start ()
    {
        Button btn = b.GetComponent<Button>();
        btn.onClick.AddListener(TaskClick);
    }

    void TaskClick()
    {
        SceneManager.LoadScene(2);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
