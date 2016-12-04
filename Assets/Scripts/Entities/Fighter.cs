using UnityEngine;
using System.Collections;

public class Fighter : MonoBehaviour {
	public enum PlayerType{HUMAN, AI};

	public static float MAX_HEALTH = 100f;

	public float health = MAX_HEALTH;
	public string fighterName;

	public PlayerType player;

	private Rigidbody myBody;

	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody> ();
	}

	void UpdateHumanInput() {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			Debug.Log( "Right Arrow key was pressed." );
		} else {
		
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			Debug.Log( "Left Arrow key was pressed." );
		} else {

		}
	}

	// Update is called once per frame
	void Update () {
		UpdateHumanInput();
	}

	public float healthPercent {
		get {
			return health / MAX_HEALTH;
		}
	}

	public Rigidbody body {
		get {
			return this.myBody;
		}
	}
}
