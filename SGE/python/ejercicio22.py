#!/usr/bin/python
# -*- coding: utf-8 -*-

import os

'''
Confeccionar una clase Empleado, definir como atributos su nombre y sueldo.
Definir un método inicializar que lleguen como dato el nombre y sueldo. 
Plantear un segundo método que imprima el nombre, sueldo y un mensaje si debe o no pagar impuestos (si el sueldo supera a 3000 paga impuestos)
'''

class Empleado:

	def constructor(self, nom,s):
		self.nombre = nom
		self.sueldo = s

	def hacienda(self):

		if self.sueldo > 3000:
			print ' El señor %s, deberá pagar impuestos dado que su sueldo es %d y supera los 3000' %(self.nombre,self.sueldo)

if __name__ == "__main__":

	
	emp1 = Empleado() #instanciamos un objeto de la clase Empleado

	n = raw_input('Introduzca el nombre del empleado: ')
	while True:
		try:
			salario = int(raw_input('Sueldo para el empleado: '))
			os.system('clear')
			break
		except ValueError:
			print 'El salario ha de ser un número entero, vuelva a intentarlo'
			os.system('sleep 2')

	emp1.constructor(n,salario)
	emp1.hacienda()
