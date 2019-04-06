using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
			transform.Translate (0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
			transform.Translate (-0.1f, 0, 0);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0.1f, 0);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, -0.1f, 0);
		}

		Vector3 posicao = transform.position;
		posicao.x = Mathf.Clamp (posicao.x, -2, 2);
		posicao.y = Mathf.Clamp (posicao.y, -4, -2);
		transform.position = posicao;
	}
}
