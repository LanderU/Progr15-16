# Instalar **OpenErp** bajo Ubuntu 15.10 file system (wily)
------------------------------------------------------------

Solucionamos las dependencias:

`sudo apt-get install bzr bzrtools graphviz postgresql postgresql-client-common python python-dateutil python-dev python-egenix-mxdatetime python-egenix-mxdatetime python-feedparser python-gdata python-hippocanvas python-imaging python-ldap python-libxml2 python-libxslt1 python-lxml python-mako python-matplotlib python-numpy python-openid python-psycopg2 python-pybabel python-pychart python-pydot python-pyparsing python-reportlab python-setuptools python-simplejson python-tz python-vatnumber python-vobject python-webdav python-werkzeug python-xlwt python-yaml python-zsi python-psutil python-docutils docutils-common docutils-doc python-jinja2 python-mock python-pygments python-roman python-unittest2 openssl xmlstarlet xsltproc python-soappy git python-decorator python-pypdf`

Comprobamos la versión de postreSqpl instalada:

'''

lander@lander:~$ sudo su postgres 
postgres@lander:/home/lander$ psql --version
psql (PostgreSQL) 9.4.5
lander@lander:/home/lander$ exit

'''
Editamos el archivo de configuración correspondiente a nuestra versión: 

`lander@lander:~$ sudo nano /etc/postgresql/9.4/main/pg_hba.conf`

Añadimos lo siguiente:

**local all openerp md5**

Reiniciamos el servicio:

`sudo service postgresql restart`

Para saber el estado en el que se encuentra el servicio:

`sudo service postgresql status`

Y la salida tendría que ser algo así (si todo va bien):
'''
● postgresql.service - PostgreSQL RDBMS
   Loaded: loaded (/lib/systemd/system/postgresql.service; enabled; vendor preset: enabled)
   Active: active (exited) since dom 2015-11-08 11:15:52 CET; 2min 40s ago
  Process: 6445 ExecStart=/bin/true (code=exited, status=0/SUCCESS)
 Main PID: 6445 (code=exited, status=0/SUCCESS)

nov 08 11:15:52 lander systemd[1]: Starting PostgreSQL RDBMS...
nov 08 11:15:52 lander systemd[1]: Started PostgreSQL RDBMS.
'''

Creamos los usuarios tanto en *postgres* como en el propio *sistema*.

Creación del usuario postgres:

`sudo su postgres`
'''
postgres@lander:/home/lander$ createuser -d -R -S -P openerp
Enter password for new role: 
Enter it again: 
'''

Creación del usuario en el sistema:
'''
lander@lander:~$ sudo adduser openerp
Añadiendo el usuario `openerp' ...
Añadiendo el nuevo grupo `openerp' (1001) ...
Añadiendo el nuevo usuario `openerp' (1001) con grupo `openerp' ...
Creando el directorio personal `/home/openerp' ...
Copiando los ficheros desde `/etc/skel' ...
Introduzca la nueva contraseña de UNIX: 
Vuelva a escribir la nueva contraseña de UNIX: 
passwd: contraseña actualizada correctamente
Cambiando la información de usuario para openerp
Introduzca el nuevo valor, o presione INTRO para el predeterminado
	Nombre completo []: 
	Número de habitación []: 
	Teléfono del trabajo []: 
	Teléfono de casa []: 
	Otro []: 
¿Es correcta la información? [S/n] S
'''


 
