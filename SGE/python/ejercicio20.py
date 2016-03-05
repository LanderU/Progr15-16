#!/usr/bin/python
# -*- coding: utf-8 -*-

'''
	Confeccionar una función que le envíe una serie de edades y me retorne la cantidad que son mayores a 18.
'''

def mayoresEdad(*otros):
	total = 0
	for i in otros:
		if i >= 18:
			total +=1
	return total

if __name__ == "__main__":

	print 'Estos es la cantidad de mayores de edad de la lista: %d' % (mayoresEdad(18,4,5,22,21,67,9,35))