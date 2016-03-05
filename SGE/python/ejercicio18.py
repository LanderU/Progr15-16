#!/usr/bin/python
# -*- coding: utf-8 -*-


'''
	Almacenar en una lista los nombres de personas y en otra los sueldos que cobran cada uno. 
	Hacer que para el índice cero de cada componente representen los datos de una persona y así sucesivamente.
'''


nEmpleados = ['Lander', 'Fermin', 'Alberto', 'Susana', 'Carmen', 'Felisa']
sEmpleados = [1200, 1300, 2200.46, 5000, 3000, 2100]

if __name__ == "__main__":

	for i in range(0,len(nEmpleados)):
		print '%-10s  %.2f' % (nEmpleados[i],sEmpleados[i])
		print ''