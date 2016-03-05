#!/usr/bin/python
# -*- coding: utf-8 -*-
'''
	Mostrar la tabla de multiplicar del número que se introduzca verificando que es un número válido.
'''

def tablaMultiplicar():
	while True:
		try:
			n = int(raw_input('Introduzca un número: '))
			break
		except ValueError:
			print 'Dato no válido, prueba otra vez.'
	
	for i in range(1,11):
		print '-------------'
		print n * i
		print '-------------'	

if __name__ == "__main__":
	
	tablaMultiplicar()

