// Used in Impaired by Lauren Stamp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Changes scene - used on multiple buttons in game
public class SceneSwap : MonoBehaviour
{
	public void NextScene(string name)
	{
		SceneManager.LoadScene (name);
	}

}