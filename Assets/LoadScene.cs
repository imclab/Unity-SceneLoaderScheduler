using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public string scenename1 = "";
	public string scenename2 = "";
	public string scenename3 = "";
	public string scenename4 = "";
	public string scenename5 = "";

	public float timer1 = 3.5f;
	public float timer2 = 4.5f;
	public float timer3 = 5.5f;
	public float timer4 = 6.5f;
	public float timer5 = 7.5f;



	void Start () {
		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
		StartCoroutine(RunScheduler());

	}


	public void Update() {

		//MANUAL SCENE LOADING
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			//SceneManagement.SceneManager.LoadScene("moon");
			SceneManager.LoadScene (scenename1, LoadSceneMode.Single);
			print ("Scene 1 loaded");
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			SceneManager.LoadScene (scenename2, LoadSceneMode.Single);
			print ("Scene 2 loaded");
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			SceneManager.LoadScene (scenename3, LoadSceneMode.Single);
			print ("Scene 3 loaded");
		}
		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			SceneManager.LoadScene (scenename4, LoadSceneMode.Single);
			print ("Scene 4 loaded");
		}
		if (Input.GetKeyDown (KeyCode.Alpha5)) {
			SceneManager.LoadScene (scenename5, LoadSceneMode.Single);
			print ("Scene 5 loaded");
		}


		//SCHEDULED SCENE LOADING
		if (Input.GetKeyDown (KeyCode.Space)) {
			StartCoroutine(RunScheduler());
		}

	}

	 IEnumerator RunScheduler() {
		if(SceneManager.GetActiveScene().name==scenename5){
			yield return new WaitForSeconds(timer1);		// wait for x seconds
		SceneManager.LoadScene (scenename1, LoadSceneMode.Single);
		print ("Scene 1 loaded");
		}
	
		if (SceneManager.GetActiveScene ().name == scenename1) {
			yield return new WaitForSeconds (timer2);		// wait for x seconds
			SceneManager.LoadScene (scenename2, LoadSceneMode.Single);
			print ("Scene 2 loaded");
		}
	
		if (SceneManager.GetActiveScene ().name == scenename2) {
			yield return new WaitForSeconds(timer3);		// wait for x seconds

		SceneManager.LoadScene (scenename3, LoadSceneMode.Single);
		print ("Scene 3 loaded");
		}
			if (SceneManager.GetActiveScene ().name == scenename3) {
			yield return new WaitForSeconds(timer4);		// wait for x seconds

		SceneManager.LoadScene (scenename4, LoadSceneMode.Single);
		print ("Scene 4 loaded");
		}
				if (SceneManager.GetActiveScene ().name == scenename4) {
			yield return new WaitForSeconds(timer5);		// wait for x seconds

		SceneManager.LoadScene (scenename5, LoadSceneMode.Single);
		print ("Scene 5 loaded");
		}
		//RunScheduler();
	}

}