using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flips : MonoBehaviour
{
	public int id;
	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}

	public void Flip()
	{
		Debug.Log(this.name);
		Debug.Log(this.id);
		Debug.Log(this.GetComponent<Image>().sprite.texture);
	}
}
