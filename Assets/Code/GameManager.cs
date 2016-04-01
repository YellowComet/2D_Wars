using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	Map testMap;
	// Use this for initialization
	void Start () {
		testMap = new Map ();
		testMap.drawMap ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
