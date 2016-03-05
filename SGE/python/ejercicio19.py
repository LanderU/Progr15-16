#!/usr/bin/python
# -*- coding: utf-8 -*-

'''
	Confeccionar una función que reciba entre 2 y 5 enteros. La misma nos debe retornar la suma de dichos valores.

'''

def numeros(n1,n2,n3=0,n4=0,n5=0):
	return n1+n2+n3+n4+n5


if __name__ == "__main__":

	print 'Llamada a la funcion sólo con dos parámetros: %d' %(numeros(3,4)) 
	print '-------------------'
	print 'Llamada con tres parámetros: %d ' % (numeros(3,4,3))
