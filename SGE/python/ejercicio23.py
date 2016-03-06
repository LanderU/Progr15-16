#!/usr/bin/python
# -*- coding: utf-8 -*-

import os

'''
	Plantear una clase Rectangulo. Definir dos atributos (ladomenor y ladomayor). Redefinir el operador == de tal forma que tengan en cuenta la superficie del rectángulo.
'''

class Rectangulo:
	def __init__(self, lmenor,lmayor):
		self.ladomenor = lmenor
		self.ladomayor = lmayor

	def superficie(self):
		return self.ladomayor * self.ladomenor

	def __eq__ (self, otro):

		if self.superficie() == otro.superficie():

			return True
		
		else:

			return False

def introducirDatos():

	'''
		Función que nos ofrece la posibilidad de introducir datos además de realizar las comprobaciones para que el dato sea válido.
	'''

	while True:
		try:
			n = float(raw_input('Introduzca el valor del lado: '))
			break
			os.system('clear')
		except ValueError:
			print 'Dato no válido, intentelo de nuevo.'
			os.system('sleep 2')

	return n


if __name__ == "__main__":

	print 'Datos para el primer rectángulo.'

	r1 = Rectangulo(introducirDatos(),introducirDatos())
	
	os.system('clear')
	
	print 'Datos para el segundo rectángulo.'

	r2 = Rectangulo(introducirDatos(),introducirDatos())

	os.system('clear')

	if r1 == r2:

		print 'La superficie de ambos rectángulos son iguales = %.2f' %(r1.superficie())
	else:
		print 'La superficie de los rectángulos no son iguales, el rectángulo uno, tiene una superficie de %.2f y el segundo de %.2f.' %(r1.superficie(),r2.superficie())