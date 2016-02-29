#!/usr/bin/python
# -*- coding: utf-8 -*-

'''
	Definir una tupla con 10 edades de personas. 
	Imprimir la cantidad de personas con edades superiores a 20.
'''

edades = (18,20,35,42,53,12,90,45,21,19)

cant = 0

for x in edades:
	if x > 20:
		cant += 1

print 'El número de personas que superan la veintena de años son: %d' %cant

