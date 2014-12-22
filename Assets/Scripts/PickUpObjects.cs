using UnityEngine;
using System.Collections;
using System.IO;
using System;
public class PickUpObjects : MonoBehaviour {
	
	
	public itemTextContadorScript txtGotas;
	public itemTextContadorScript txtContentores;
	public itemTextContadorScript txtArvores;
	public tempoScript tempoScript;
	public VidasScript vidas;
	public int numeroItemsBons;
	public AudioClip somItemBom;
	public AudioClip somItemMau;
	public AudioClip somAgua;

	public PerfilCsharp perfil;


	public GUIText pontuacao;
	
	private int numero;
	
	private static int pontos;
	private static int nivel;
	
	private int contarBom = 0;
	private int contarMau = 0;
	
	private string itemMau = "";
	private string itemBom = "";
	private string tempo = "";
	private string vida = "";

	//private string data = "";
	private string idade = "";
	private string anoEscolar = "";
	private string sexo = "";

	private int contagem;
	
	private string path = @"Assets\Data.csv";
	public GUIText gameOverText;
	private float time;
	
	private string appendText;
	private string createText;

	private string contarFinalBons;
	private string contarFinalMaus;

	public  DateTime data = DateTime.Now;



	
	// Use this for initialization
	void Start(){
		
		OrganizarPontuacao();
		if(nivel==0)
			File.AppendAllText(path, "Novo Jogo" + ", ");
	}
	
	void Update(){
		
		
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "ItemComTempo") {
			if (other.GetComponentInChildren<txtTempo_Script> ()!=null) {
				int tempo = other.GetComponentInChildren<txtTempo_Script> ().tempoContagem;
				if (tempo != 0) {
					contagem++;
					Debug.Log (contagem);
				}
			}
		}
		
		if (other.gameObject.tag == "ItemBom") {
			
			pontos = pontos + 10;
			numero = numero + 1;
			OrganizarPontuacao ();
			NumeroSoma ();
			
			atualizarContagens (other.name);
			
			other.gameObject.SetActive (false);
			AudioSource.PlayClipAtPoint (somItemBom, this.transform.position);
			
		} else if (other.gameObject.tag == "ItemMau") {
			other.gameObject.SetActive (false);
			pontos = pontos - 5;
			OrganizarPontuacao ();
			AudioSource.PlayClipAtPoint (somItemMau, this.transform.position);
		} else if (other.gameObject.tag.Equals ("Agua")) {
			AudioSource.PlayClipAtPoint (somAgua, new Vector3 (120, 10, 130));
			tempoScript.reiniciarNivel ();
		} 
		guardarFicheiro (other);
		
	}
	
	private void atualizarContagens(string nomeObjeto)
	{
		switch (nomeObjeto)
		{
		case "ItemBom_gota": txtGotas.incrementarContagem();
			break;
		case "ItemBom_contentor": txtContentores.incrementarContagem();
			break;
		case "ItemBom_arvore": txtArvores.incrementarContagem();
			break;
			
		}
		
	}
	
	void OrganizarPontuacao(){
		pontuacao.text = "Pontos : " + pontos;
	}
	
	void NumeroSoma() {
		if (numero == numeroItemsBons)
		{
			nivel++;
			
			if (nivel > 5){
				
				Application.LoadLevel("Fim_Jogo");
				
			}else
				Application.LoadLevel("Nivel_" + nivel);
			
		}
	}
	
	public void reiniciar()
	{
		pontos = 0;
		nivel = 0;
		vidas.reiniciar();
	}
	
	private void guardarFicheiro(Collider other) 
	{
		
		time = Mathf.Round (Time.timeSinceLevelLoad); //irá contar o tempo desde o inicio do jogo
		
		
		
		if (other.gameObject.tag == "ItemBom" || other.gameObject.tag == "ItemMau") { //a tag do objeto for "ItemBom" ou "ItemMau"
			//  other.gameObject.SetActive(false);//o objeto que o player apanha desaparece
			
			if (other.gameObject.tag == "ItemBom") { //se a tag do objeto apanhado for "ItemBom"
				contarBom++; //incrementa mais um
				//contarFinalBons = contarBom.ToString();
				
			} else if (other.gameObject.tag == "ItemMau") {//se a tag do objeto apanhado for "ItemMau"
				contarMau++;//incrementa mais um
				//contarFinalMaus = contarMau.ToString();
				
			}
			itemMau = contarMau.ToString (); //constroi a string a dando-lhe o valor "ItemMau" concatenado com o numero de contarMau 
			itemBom = contarBom.ToString ();//constroi a string b dando-lhe o valor "ItemMau" concatenado com o numero de contarBom 
			tempo = time.ToString ();//constroi a string c dando-lhe o valor "Tempo" concatenado com o tempo que demorou a apanhar o item 
			vida = vidas.NumVidas.ToString();//constrói a string d dando-lhe o valor "Vida" concatenado com o número de vidas restante


		//	idade = perfil.Idade.ToString();
			/*sexo = perfil.Sexo.ToString();
			anoEscolar = perfil.AnoEscolar.ToString();*/

			/*if (File.Exists (path)) { //se o ficheiro existir
				appendText = itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", " ;
				File.AppendAllText (path, appendText);
				
				
			}
			if (!File.Exists (path)) {
				createText = itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", ";
				File.WriteAllText (path, createText);
				
				
			111}*/
			
		}
		if (contarBom == numeroItemsBons) {
			//contagem= " Contagem="+ tempo_script.Contador;
			//contagem = insistencias

			if (File.Exists (path)) { //se o ficheiro existir
				appendText = itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", "+(nivel - 1) + ", " + pontos +", "+contagem+ Environment.NewLine ;
				File.AppendAllText (path, appendText);
				
				
			}

			if (!File.Exists (path)) {
				createText = itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", "+(nivel - 1) + ", " + pontos +", "+contagem ;
				File.WriteAllText (path, createText);
				
				
			}
		//	File.AppendAllText (path, (nivel - 1) + ", " + pontos +", "+contagem+ ", ");
			
		}
		
		if (nivel > 5) {
			File.AppendAllText (path, "Fim de Jogo " + Environment.NewLine);
		}
		
	}
	
	
}



