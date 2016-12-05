using UnityEngine;
using System.Collections;

public class Fighter : MonoBehaviour {
	public enum PlayerType{HUMAN, AI};

	public static float MAX_HEALTH = 100f;

	public float health = MAX_HEALTH;
	public string fighterName;
	public float movementSpeed = 5.0f;

	public PlayerType player;

	private Rigidbody myBody;

	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody> ();
	}

	void UpdateHumanInput() {
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.position += Vector3.right * Time.deltaTime * movementSpeed;
		} 

		if(Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += Vector3.left * Time.deltaTime * movementSpeed;
		}

		if(Input.GetKey(KeyCode.UpArrow)){
			transform.position += Vector3.up * Time.deltaTime * movementSpeed;
		}
	}

	// Update is called once per frame
	void Update () {
		if (player == PlayerType.HUMAN) { 
			UpdateHumanInput ();
		}
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
