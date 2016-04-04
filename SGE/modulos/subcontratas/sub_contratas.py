# -*- encoding: utf-8 -*-
##############################################################################
#
#    OpenERP, Open Source Management Solution	
#  
#   
#
#    This program is free software: you can redistribute it and/or modify
#    it under the terms of the GNU General Public License as published by
#    the Free Software Foundation, either version 3 of the License, or
#    (at your option) any later version.
#
#    This program is distributed in the hope that it will be useful,
#    but WITHOUT ANY WARRANTY; without even the implied warranty of
#    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
#    GNU General Public License for more details.
#
#    You should have received a copy of the GNU General Public License
#    along with this program.  If not, see <http://www.gnu.org/licenses/>.
#
##############################################################################

''' Imports '''

from osv import fields, osv

class sub_contratas(osv.osv):
	_name = "hr_subcontratas"
	_description = "Subcontratados"
	_columns = {
		'x_nombre' : fields.text('Nombre', size=64, required=True)
		'x_apellido' : fields.text('Apellido', size=64, required=True)
		'x_dni' : fields.char('DNI', size=64, required=True)
		'x_empresa_origen' : fields.text('Empresa Origen', size=64, required=True)
		'x_puesto' : fields.text('Puesto', size=64, required=True) 
		'x_observaciones' : fields.text('Observaciones', size=64)

	}

sub_contratas()