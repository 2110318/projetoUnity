using UnityEngine;
using System.Collections;

public class txtTempo_Script : MonoBehaviour {
    public int tempoContagem;
    private int tempoParaDesativar;
    private TextMesh txtTempo;
	private int contador;

	public int Contador{
		get {
			return contador;
		}
	}

	// Use this for initialization
	void Start () {
        txtTempo = gameObject.transform.parent.GetComponent<TextMesh>();
		contador=0;
	}
	
	// Update is called once per frame
    void Update()
    {
        tempoParaDesativar = (int)(tempoContagem - Time.timeSinceLevelLoad);        
        txtTempo.text = tempoParaDesativar.ToString();


		if (tempoParaDesativar == 0) {
						gameObject.SetActive (false);
						
						GameObject item = gameObject.transform.parent.gameObject.transform.parent.gameObject;
					//	item.collider.isTrigger = true;
			gameObject.transform.parent.transform.parent.tag= "ItemBom";

						char[] chars = new char[] 
            { 
             '\u263B'
             };

						txtTempo.text = new string (chars);
						txtTempo.color = Color.green;
		
    }
	}
}