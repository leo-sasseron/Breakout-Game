using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Derrota : MonoBehaviour
{
	public GameObject bola;

	void Start() {
		Jogo.vidas = 3;
	}

	void Respawn() {
		Vector2 posicao = new Vector2(0,-2);
		Instantiate (bola, posicao, Quaternion.identity);
	}

	void OnTriggerEnter2D(Collider2D colisor)
	{
		Debug.Log ("TRIGGER ENTER");
	}

	void OnTriggerStay2D(Collider2D colisor)
	{
		Debug.Log ("TRIGGER STAY");
	}

	void OnTriggerExit2D(Collider2D colisor)
	{
		Debug.Log ("TRIGGER Saida");

		Jogo.vidas--;
		Destroy (colisor.gameObject);
		if (Jogo.vidas>0) Invoke ("Respawn", 1);

		
	}
}
