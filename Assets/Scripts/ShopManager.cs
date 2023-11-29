using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ShopManager : MonoBehaviour
{
	
	
	[Header("R 1")]
	[SerializeField] GameObject r1Canvas;
	[SerializeField] int r1amount;
//	[SerializeField] Button Buycar1Button;
	[SerializeField] Button useR1;
	
		[Header("R 2")]
	[SerializeField] GameObject r2Canvas;
	[SerializeField] int r2amount;
	[SerializeField] Button BuyR2Button;
	[SerializeField] Button useR2;
	
	
		[Header("R 3")]
	[SerializeField] GameObject r3Canvas;
	[SerializeField] int r3amount;
	[SerializeField] Button BuyR3Button;
	[SerializeField] Button useR3;
	
	public void r1Next()
	{
		r1Canvas.SetActive(false);
		r2Canvas.SetActive(true);
	}
	
	public void r2Back()
	{
		r1Canvas.SetActive(true);
		r2Canvas.SetActive(false);
	}
	
	public void r2Next()
	{
		
		r2Canvas.SetActive(false);
		r3Canvas.SetActive(true);
	}
	
	public void r3Back()
	{
		
		r2Canvas.SetActive(true);
		r3Canvas.SetActive(false);
	}
	
	public void BackTomain()
	{
		SceneManager.LoadScene("first");
	}
	
}
