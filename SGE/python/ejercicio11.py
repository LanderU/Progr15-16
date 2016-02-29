#!/usr/bin/python
# -*- coding: utf-8 -*-

'''
Desarrollar una función que reciba tres enteros y nos retorne la suma de los dos más grandes.
'''

def mostrarSuma(n1,n2,n3):
	if n1 > n2 and n1 > n3:
		if n2 > n3:
			print n1+n2
		else:
			return n1+n3
	elif n2 > n3:
		if n3 > n1:
			return n2+n3
		else:
			return n2+n1
	else:
		if n2 > n1:
			return n3+n2
		else:
			return n3+n1

x = int(raw_input('Escriba el primer número: '))
y = int(raw_input('Escriba el segundo número: '))
z = int(raw_input('Escriba el tercer número: '))


print mostrarSuma(x,y,z)