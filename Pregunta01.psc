Algoritmo Pregunta01
	Definir comprobante Como Cadena
	
	Escribir "Ingrese el comprobante: "
	Leer comprobante
	
	Si ValidarComprobante(comprobante) Entonces
		Escribir "Comprobante valido"
	SiNo
		Escribir "Comprobante invalido"
	FinSi
FinAlgoritmo

Funcion valido <- ValidarComprobante(num)
	Definir valido Como Logico
	Definir i Como Entero
	
	valido <- Verdadero
	
	Si Longitud(num) <> 13 Entonces
		valido <- Falso
	FinSi
	
	Si valido Entonces
		Si Subcadena(num,1,1) <> "B" Y Subcadena(num,1,1) <> "F" Entonces
			valido <- Falso
		FinSi
	FinSi
	
	Si valido Entonces
		Para i <- 2 Hasta 4
			Si No (Subcadena(num,i,i) >= "0" Y Subcadena(num,i,i) <= "9") Entonces
				valido <- Falso
			FinSi
		FinPara
	FinSi
	
	Si valido Entonces
		Si Subcadena(num,5,5) <> "-" Entonces
			valido <- Falso
		FinSi
	FinSi
	
	Si valido Entonces
		Para i <- 6 Hasta 13
			Si No (Subcadena(num,i,i) >= "0" Y Subcadena(num,i,i) <= "9") Entonces
				valido <- Falso
			FinSi
		FinPara
	FinSi
FinFuncion