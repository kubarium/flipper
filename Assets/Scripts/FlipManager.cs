using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipManager : MonoBehaviour
{
	
	public GameObject btn;
	public LayoutGroup grid;
	public Sprite[] owls;
	// Use this for initialization
	void Start()
	{
		
		//LayoutGroup grid = GameObject.Find("Grid") as LayoutGroup;
		Debug.Log(grid);
		for (int i = 0; i < 9; i++) {
			GameObject button = Instantiate(btn);
			button.name = "owls_" + i;
			button.transform.SetParent(grid.transform);
			button.GetComponent<Image>().sprite = owls[Random.Range(0, owls.Length - 1)];
			//flips.id = i;


		}
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}


}
