using UnityEngine;
using System.Collections;

public class HpDisplay : MonoBehaviour 
{
	public WobbleStatScript health;
	public GUIText hpText;
	int hp;
	public int maxHP;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		hp = health.health;
		UpdateHealth();
	}
	
	void UpdateHealth()
	{
		if (hp > maxHP)
		{
		 maxHP = hp;
		}
		hpText.text = hp + "/" + maxHP;
	}
}
