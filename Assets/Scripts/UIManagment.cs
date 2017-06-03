using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagment : MonoBehaviour {
	[HideInInspector]
	public static UIManagment instance; // static allows access from anywhere
    public int counterTimer;
    int swith;
    public Slider cuentaRegresiva;
    public bool Blancas;
    public Text text;
	// Use this for initialization
	void Awake()
	{
		instance = this;
	}
    IEnumerator Timer()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            --counterTimer;
        }
        
    }
	void Start () {
        
        StartCoroutine("Timer");
        Blancas = true;
        swith = 1;
	}
	
	// Update is called once per frame
	void Update () {
        cuentaRegresiva.value = counterTimer;
        if (counterTimer == 0)
        {
            counterTimer = 100;
            swith *= -1;
        }
        if (swith > 0)
            Blancas = true;
        else Blancas = false;

        if (Blancas)
            text.text = "Blancas";
        else text.text = "Negras";
    }
    public void ButtonClick()
    {
        counterTimer = 0;
    }
}
