using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
	Rigidbody2D corpo;

	// Use this for initialization
	void Start ()
	{
		corpo = GetComponent<Rigidbody2D> ();
		corpo.AddForce (new Vector2 (0, 200));
	}

	void Update() {
		Debug.Log (corpo.velocity.magnitude);
		if (corpo.velocity.magnitude > 15) {
			corpo.velocity *= 0.9f;
		}

		if (corpo.velocity.magnitude < 3) {
			corpo.velocity *= 2f;
		}
	}

	void OnCollisionEnter2D(Collision2D colisao)
	{
		Debug.Log ("ENTER");
	}

	void OnCollisionStay2D(Collision2D colisao)
	{
		Debug.Log ("STAY");
	}

	void OnCollisionExit2D(Collision2D colisao)
	{
		Debug.Log ("EXIT");

		if (colisao.gameObject.tag == "Quebravel") {
			Jogo.blocos -= 1;
			Destroy (colisao.gameObject);
		}
		else if (colisao.gameObject.name == "Jogador") {
			float distancia = transform.position.x - colisao.transform.position.x;
			corpo.AddForce(new Vector2(distancia * 150, 50)) ;
					

			/*
			if (transform.position.x > colisao.transform.position.x) {
				corpo.AddForce (new Vector2 (150, 50));
			}
			else if (transform.position.x < colisao.transform.position.x) {
				corpo.AddForce (new Vector2 (-150, 50));
			}
			*/
		}
	}
}
