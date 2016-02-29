#!/usr/bin/python
# -*- coding: utf-8 -*-

'''
	Definir una lista con un conjunto de nombres, imprimir la cantidad de comienzan con la letra a:

'''

lNombres = ['Lander','Ane','Alazne','Alberto','Ixone','andrea']

cont = 0
for i in lNombres:
	if i[0] == 'A' or i[0] == 'a':
		cont +=1

print 'De la lista el número de personas que su nombre empieza por A o a es: %d' % cont