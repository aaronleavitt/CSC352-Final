using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    [SerializeField] public Button Restart;

	private void Update() {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
       	SceneManager.LoadScene(0);
        }
	}
    

}
