using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour {

	public Text vidas;
	public GameObject gameover;

	// Update is called once per frame
	void Update () {
		vidas.text="Vidas:" + Jogo.vidas;
	}
}
