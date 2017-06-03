using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	private Button headButton;
	private Button upperArmorButton;
	private Button lowerArmorButton;
	private Button shoesButton;
	private GameObject headArmor;
	private GameObject upperArmor;
	private GameObject lowerArmor;
	private GameObject shoes;

	// Use this for initialization
	void Start () {
		headButton = GameObject.Find("Head Button").GetComponent<Button>();
		upperArmorButton = GameObject.Find("Upper Armor Button").GetComponent<Button>();
		lowerArmorButton = GameObject.Find("Lower Armor Button").GetComponent<Button>();
		shoesButton = GameObject.Find("Shoes Button").GetComponent<Button>();

		GameObject character = GameObject.Find("knight");
		headArmor = character.transform.Find("HeadArmor").gameObject;
		upperArmor = character.transform.Find("UpperArmor").gameObject;
		lowerArmor = character.transform.Find("LowerArmor").gameObject;
		shoes = character.transform.Find("Shoes").gameObject;

		InitEvents();
	}

	void InitEvents() {
		headButton.onClick.AddListener(() => {
			print("Head Button");
			headArmor.SetActive(!headArmor.activeSelf);
		});
		upperArmorButton.onClick.AddListener(() => {
			upperArmor.SetActive(!upperArmor.activeSelf);
		});
		lowerArmorButton.onClick.AddListener(() => {
			lowerArmor.SetActive(!lowerArmor.activeSelf);
		});
		shoesButton.onClick.AddListener(() => {
			shoes.SetActive(!shoes.activeSelf);
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
