# Instalar **OpenErp** bajo Ubuntu 15.10 fs (wily)
------------------------------------------------------------

Solucionamos las dependencias:

`sudo apt-get install bzr bzrtools graphviz postgresql postgresql-client-common python python-dateutil python-dev python-egenix-mxdatetime python-egenix-mxdatetime python-feedparser python-gdata python-hippocanvas python-imaging python-ldap python-libxml2 python-libxslt1 python-lxml python-mako python-matplotlib python-numpy python-openid python-psycopg2 python-pybabel python-pychart python-pydot python-pyparsing python-reportlab python-setuptools python-simplejson python-tz python-vatnumber python-vobject python-webdav python-werkzeug python-xlwt python-yaml python-zsi python-psutil python-docutils docutils-common docutils-doc python-jinja2 python-mock python-pygments python-roman python-unittest2 openssl xmlstarlet xsltproc python-soappy git python-decorator python-pypdf`

Comprobamos la versión de postresql instalada:

```
lander@lander:~$ sudo su postgres 
postgres@lander:/home/lander$ psql --version
psql (PostgreSQL) 9.4.5
lander@lander:/home/lander$ exit
```

Editamos el archivo de configuración correspondiente a nuestra versión: 

`lander@lander:~$ sudo nano /etc/postgresql/9.4/main/pg_hba.conf`

Añadimos lo siguiente:

**local all openerp md5**

Reiniciamos el servicio:

`sudo service postgresql restart`

Para saber el estado en el que se encuentra el servicio:

`sudo service postgresql status`

Y la salida tendría que ser algo así (si todo va bien):
```
● postgresql.service - PostgreSQL RDBMS
   Loaded: loaded (/lib/systemd/system/postgresql.service; enabled; vendor preset: enabled)
   Active: active (exited) since dom 2015-11-08 11:15:52 CET; 2min 40s ago
  Process: 6445 ExecStart=/bin/true (code=exited, status=0/SUCCESS)
 Main PID: 6445 (code=exited, status=0/SUCCESS)

nov 08 11:15:52 lander systemd[1]: Starting PostgreSQL RDBMS...
nov 08 11:15:52 lander systemd[1]: Started PostgreSQL RDBMS.
```

Creamos los usuarios tanto en *postgres* como en el propio *sistema*.

Creación del usuario postgres:

`sudo su postgres`
```
postgres@lander:/home/lander$ createuser -d -R -S -P openerp
Enter password for new role: 
Enter it again: 
```

Creación del usuario en el sistema:
```
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
```
Creamos una estructura de carpetas donde nos clonaremos el respistorio de GitHub de Odoo:

Cambiamos de usuario,

```
lander@lander:~$ sudo su openerp 
openerp@lander:/home/lander$
openerp@lander:/home/lander$ mkdir /home/openerp/odoo -p
openerp@lander:/home/lander$ cd /home/openerp/odoo/
openerp@lander:~/odoo$
```

Instalamos git:

`sudo apt-get install git`

Y nos clonamos el repositorio de git de Odoo en la estructura de carpetas que hemos creado:

`git clone https://github.com/odoo/odoo.git`

Una vez se ha clonado, nos movemos al branch correspondiente **7.0**:

Por defecto nos encontramos en el siguiente branch:
```
openerp@lander:~/odoo/odoo$ git branch
* 9.0
```

`git checkout 7.0`

```
openerp@lander:~/odoo/odoo$ git checkout 7.0
Branch 7.0 set up to track remote branch 7.0 from origin.
Switched to a new branch '7.0'
openerp@lander:~/odoo/odoo$ git branch
* 7.0
  9.0
```

Ejecutamos el servidor para que empieze a escuchar: 

```
openerp@lander:~/odoo/odoo$ ./openerp-server -w openerp -r openerp --addons-path=addons -s
2015-11-08 11:42:22,753 6855 INFO ? openerp: OpenERP version 7.0
2015-11-08 11:42:22,754 6855 INFO ? openerp: addons paths: /home/openerp/odoo/odoo/addons
2015-11-08 11:42:22,754 6855 INFO ? openerp: database hostname: localhost
2015-11-08 11:42:22,754 6855 INFO ? openerp: database port: 5432
2015-11-08 11:42:22,754 6855 INFO ? openerp: database user: openerp
2015-11-08 11:42:23,715 6855 INFO ? openerp.addons.google_docs.google_docs: GData lib version `%s GData-Python/2.0.18` detected
2015-11-08 11:42:24,353 6855 INFO ? openerp.service.wsgi_server: HTTP service (werkzeug) running on 0.0.0.0:8069
```

Una vez hecho esto y para empezar a configurar, nuestro erp, abrimos un navegador y escribimos 127.0.0.1:8069 en la barra de direcciones.

Para que el servicio se ejecute siempre al inicio vamos a crear el demonio, (añado el script en el repo):

`sudo mv openerp-server /etc/init.d/` 

`sudo chmod +x /etc/init.d/openerp-server`

`sudo update-rc.d openerp-server defaults`

`sudo service start|stop|restart|status opener-server` para conocer el estado del servicio.






 
