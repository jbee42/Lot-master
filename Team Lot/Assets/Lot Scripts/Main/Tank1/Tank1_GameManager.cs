using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tank1_GameManager : MonoBehaviour {

	public static int money = 0;

	public Text moneyText;

	void Update()
	{
		moneyText.text = "MONEY : " + money.ToString ("000000");
	}

}
