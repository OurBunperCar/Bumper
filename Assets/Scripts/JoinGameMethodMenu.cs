using UnityEngine;
using System.Collections;

public class JoinGameMethodMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI ()
	{
		if(GUI.Button(new Rect(10,10,50,50),"创建房间")){
			Debug.Log("creat");
			Application.LoadLevel("RoomSettings");
		}
	}

}
