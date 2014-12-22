using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class PerfilCsharp : MonoBehaviour {

	private string path = @"Assets\Data.csv";
	public static DateTime date = DateTime.Now;

	public DateTime Date {
		get {
			return date;
		}
	}

	public static int idade=0;

	public int Idade {
		get {
			return idade;
		}
	}

	public static String sexo= "";

	public String Sexo {
		get {
			return sexo;
		}
	}

	public static String anoEscolar="";

	public String AnoEscolar {
		get {
			return anoEscolar;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Jogar(){
	
		Application.LoadLevel ("Interface_Texto");

	}

	public void saveIdade(){
		PlayerPrefs.GetInt ("IDADE", idade);
	}

	public void SeisAnos(){
		idade=6;
		/*if (!File.Exists (path)) {
			File.WriteAllText (path, date.ToString()+ ", "+  idade.ToString()+ ", " );		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, date.ToString()+ ", "+ idade.ToString()+", " );				
		}*/

	}

	public void SeteAnos(){
		idade = 7;
		if (!File.Exists (path)) {
			File.WriteAllText (path, date.ToString()+ ", " + idade.ToString() + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, date.ToString()+ ", " + idade.ToString() + ", ");				
		}
	}
	
	public void OitoAnos(){
		idade = 8;
		if (!File.Exists (path)) {
			File.WriteAllText (path, date.ToString()+ ", " + idade.ToString() + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, date.ToString()+ ", " + idade.ToString() + ", ");				
		}
	}
	
	public void NoveAnos(){
		idade = 9;
		if (!File.Exists (path)) {
			File.WriteAllText (path,  idade.ToString() + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path,  idade.ToString() + ", ");				
		}
	}
	
	public void DezAnos(){
		idade = 10;
		if (!File.Exists (path)) {
			File.WriteAllText (path,idade.ToString() + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path,  idade.ToString() + ", ");				
		}
	}
	
	public void OnzeAnos(){
		idade = 11;
		if (!File.Exists (path)) {
			File.WriteAllText (path,  idade.ToString() + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path,  idade.ToString() + ", ");				
		}
	}
	
	public void DozeAnos(){
		idade = 12;
		if (!File.Exists (path)) {
			File.WriteAllText (path,  idade.ToString() + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, idade.ToString() + ", ");				
		}
	}
	
	public void SexoFeminino(){
		sexo = "Feminino";
		if (!File.Exists (path)) {
			File.WriteAllText (path, sexo + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, sexo + ", ");				
		}
	}
	
	public void SexoMasculino(){
		sexo = "Masculino";
		if (!File.Exists (path)) {
			File.WriteAllText (path, sexo + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, sexo + ", ");				
		}
	}
	
	public void PrePrimaria(){
		anoEscolar = "Pre-Primaria";
		if (!File.Exists (path)) {
			File.WriteAllText (path, anoEscolar + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, anoEscolar + ", ");				
		}
	}
	
	public void PrimeiroAno(){
		anoEscolar = "Primeiro Ano";
		if (!File.Exists (path)) {
			File.WriteAllText (path, anoEscolar + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, anoEscolar + ", ");				
		}
	}
	
	public void SegundoAno(){
		anoEscolar = "Segundo Ano";
		if (!File.Exists (path)) {
			File.WriteAllText (path, anoEscolar + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, anoEscolar + ", ");				
		}
	}
	
	public void TerceiroAno(){
		anoEscolar = "Terceiro Ano";
		if (!File.Exists (path)) {
			File.WriteAllText (path, anoEscolar + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, anoEscolar + ", ");				
		}
	}
	
	public void QuartoAno(){
		anoEscolar = "Quarto Ano";
		if (!File.Exists (path)) {
			File.WriteAllText (path, anoEscolar + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, anoEscolar + ", ");				
		}
	}
	
	public void QuintoAno(){
		anoEscolar = "Quinto Ano";
		if (!File.Exists (path)) {
			File.WriteAllText (path, anoEscolar + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, anoEscolar + ", ");				
		}
	}
	
	public void SextoAno(){
		anoEscolar = "Sexto Ano";
		if (!File.Exists (path)) {
			File.WriteAllText (path, anoEscolar + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, anoEscolar + ", ");				
		}
	}
	
	public void SetimoAno(){
		anoEscolar = "Setimo Ano";
		if (!File.Exists (path)) {
			File.WriteAllText (path, anoEscolar + ", ");		
		}
		else if (File.Exists (path)) {			
			File.AppendAllText (path, anoEscolar + ", ");				
		}
	}

}
