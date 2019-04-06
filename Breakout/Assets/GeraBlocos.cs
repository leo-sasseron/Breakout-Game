using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraBlocos : MonoBehaviour
{
	public GameObject bloco;

	// Use this for initialization
	void Start ()
	{
		Fase1 ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Jogo.blocos == 0 && !IsInvoking()) {
			if (Jogo.fase == 1) Invoke ("Fase2", 0.5f);
			if (Jogo.fase == 2) Invoke ("Fase3", 0.5f);
			if (Jogo.fase == 3) Invoke ("Fase1", 0.5f);
		}
	}

	void Fase1()
	{
		Jogo.fase = 1;
		Jogo.blocos = 10;

		Vector2 posicao = new Vector2 (-2, 4);
		for (int l = 0; l < 2; l++) {
			for (int c = 0; c < 5; c++) {
				Instantiate (bloco, posicao, Quaternion.identity);
				posicao.x += 1;
			}
			posicao.x = -2;
			posicao.y -= 0.7f;
		}
	}

	void Fase2()
	{
		Jogo.fase = 2;
		Jogo.blocos = 15;

		Vector2 posicao = new Vector2 (-2, 4);
		for (int l = 0; l < 3; l++) {
			for (int c = 0; c < 5; c++) {
				Instantiate (bloco, posicao, Quaternion.identity);
				posicao.x += 1;
			}
			posicao.x = -2;
			posicao.y -= 0.7f;
		}
	}

	void Fase3()
	{
		Jogo.fase = 3;
		Jogo.blocos = 20;

		Vector2 posicao = new Vector2 (-2, 4);
		for (int l = 0; l < 4; l++) {
			for (int c = 0; c < 5; c++) {
				Instantiate (bloco, posicao, Quaternion.identity);
				posicao.x += 1;
			}
			posicao.x = -2;
			posicao.y -= 0.7f;
		}
	}
}
