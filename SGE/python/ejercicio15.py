#!/usr/bin/python
# -*- coding: utf-8 -*-

'''
	Elaborar las siguientes funciones:
		- Una función que reciba un string y nos retorne el primer caracter.
		- Una función que reciba un apellido y un nombre, y nos retorne un único string con el apellido y nombre concatenados y separados por una coma.
		- Una función que reciba dos string y nos retorne el que tiene menos caracteres.
'''

def primerCaracter(cadena1):
	return cadena1[0]

def concatenar(cadena2,cadena3):
	return cadena2+', '+cadena3

def menorCadena(cadena4,cadena5):
	if len(cadena4) > len(cadena5):
		return cadena5
	else:
		return cadena4

c1 = raw_input('Escriba una cadena de texto: ')
c2 = raw_input('Escriba su nombre: ')
c3 = raw_input('Escriba su apellido: ')
c4 = raw_input('Escriba otra cadena: ')
c5 = raw_input('La última cadena: ')

print primerCaracter(c1)+' es el primer caracter de la cadena %s' % c1
print ''
print 'La concatenación de su nombre y apellido es: '+ concatenar(c2,c3)
print ''
print menorCadena(c4,c5)+' es la cadena que menos valores tiene de las introducidas %s , %s' %(c4,c5)
