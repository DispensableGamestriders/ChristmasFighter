using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HudController : MonoBehaviour {
	public Fighter player1;
	public Fighter player2;

	public Text leftText;
	public Text rightText;

	// Use this for initialization
	void Start () {
		leftText.text = player1.fighterName;
		rightText.text = player2.fighterName;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
