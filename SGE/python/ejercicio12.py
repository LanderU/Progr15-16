#!/usr/bin/python
# -*- coding: utf-8 -*-

'''
	Definir una tupla que almacene 5 enteros. 
	Implementar un algoritmo que imprima la suma de todos los elementos.
'''

tupla = (4,8,10,12,0)

i = 0
res = 0
while i <len(tupla) :
	res += tupla[i]
	i+=1

print "El resultado de sumar la tupla es: %d" %res