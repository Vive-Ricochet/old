using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class health : MonoBehaviour {

	public Slider healthSlider;
	public int startHealth = 100;
	public int currentHealth;

	Animator anim;
	movement movement;
	bool isDead;
	bool damaged;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		//playerAudio = GetComponent <AudioSource> ();
		movement = GetComponent <movement> ();

		currentHealth = startHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (damaged) {
			//onHit effects here
		} else {
			//make sure to reset
		}
		damaged = false;
	}

	public void TakeDamage (int amount) {
		damaged = true;
		currentHealth -= amount;
		healthSlider.value = currentHealth;

		if (currentHealth <= 0 && !isDead) {
			Death ();
		}
	}

	void Death(){
		//kill player
		isDead = true;
	}
}
