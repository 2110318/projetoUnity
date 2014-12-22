#pragma strict




import System.Text;
import System.IO;
import System;


var data : DateTime;
data = DateTime.Now;
function Start () {

}

function Update () {
	 

}

function Jogar(){
	Application.LoadLevel("Interface_Texto");
}

function SeisAnos(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "6" + ", " );		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "6" + ", " );				
		}
}

function SeteAnos(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "7" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "7" + ", ");				
		}
}

function OitoAnos(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "8" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "8" + ", ");				
		}
}

function NoveAnos(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "9" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "9" + ", ");				
		}
}

function DezAnos(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "10" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "10" + ", ");				
		}
}

function OnzeAnos(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "11" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "11" + ", ");				
		}
}

function DozeAnos(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "12" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", data.ToString()+ ", " + "12" + ", ");				
		}
}

function SexoFeminino(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", "Feminino" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", "Feminino" + ", ");				
		}
}

function SexoMasculino(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", "Masculino" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", "Masculino" + ", ");				
		}
}

function PrePrimaria(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", "Pre-Primaria" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", "Pre-Primaria" + ", ");				
		}
}

function PrimeiroAno(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", "Primeiro Ano" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", "Primeiro Ano" + ", ");				
		}
}

function SegundoAno(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", "Segundo Ano" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", "Segundo Ano" + ", ");				
		}
}

function TerceiroAno(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", "Terceiro Ano" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", "Terceiro Ano" + ", ");				
		}
}

function QuartoAno(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", "Quarto Ano" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", "Quarto Ano" + ", ");				
		}
}

function QuintoAno(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", "Quinto Ano" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", "Quinto Ano" + ", ");				
		}
}

function SextoAno(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", "Sexto Ano" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", "Sexto Ano" + ", ");				
		}
}

function SetimoAno(){
	if (!File.Exists (Application.dataPath + "/Data.csv")) {
			File.WriteAllText (Application.dataPath + "/Data.csv", "Setimo Ano" + ", ");		
		}
	else if (File.Exists (Application.dataPath + "/Data.csv")) {			
			File.AppendAllText (Application.dataPath + "/Data.csv", "Setimo Ano" + ", ");				
		}
}
