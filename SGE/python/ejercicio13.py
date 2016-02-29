#!/usr/bin/python
# -*- coding: utf-8 -*-

'''
	Almacenar en una tupla 5 nombres. Luego generar un valor aleatorio entre 2 y 4. 
	Copiar a una tupla el nombre de la posición indicada por el valor aleatorio y los nombres que se encuentran en la posición anterior y posterior.
'''

import random

tNombres = ('Juan','Pepito','Fermin','Mispe','Misco')

nAleatorio = random.randint(1,3)

nuevaTupla = tNombres[nAleatorio-1:nAleatorio+2]

print nuevaTupla