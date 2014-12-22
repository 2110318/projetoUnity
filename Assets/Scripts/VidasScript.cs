using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;
using System;

public class VidasScript : MonoBehaviour {
	private string path = @"Assets\Data.csv";

    private static int numVidas = 3;

	public int NumVidas {
		get {
			return numVidas;
		}
	}
  
    public GUITexture vida_1;
    public GUITexture vida_2;
    public GUITexture vida_3;
    
   
	// Use this for initialization
	void Start () {
        if(numVidas!= 0)
            atualizarVidas();   
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void decrementarVidas()
    {
        numVidas--;

        GameObject.Find("3rd Person Controller").transform.position = new Vector3(120, 10, 130);
        atualizarVidas();
    }

    private void atualizarVidas()
    {
        if (numVidas < 3)
            vida_3.gameObject.SetActive(false);
        if (numVidas < 2)
            vida_2.gameObject.SetActive(false);
        if (numVidas < 1)
        {   
			File.AppendAllText(path, "Perdeu "+Environment.NewLine);
            Application.LoadLevel("Perdeu");
        }
        
    }

    public void reiniciar()
    {
        numVidas = 3;
        //vida_1.gameObject.SetActive(true);
        //vida_2.gameObject.SetActive(true);
        //vida_3.gameObject.SetActive(true);
        atualizarVidas();
        
    }

}
