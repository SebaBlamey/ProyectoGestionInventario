BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Producto" (
	"ID"	VARCHAR(50),
	"Nombre"	VARCHAR(100),
	"Stock"	INT,
	"Imagen"	VARCHAR(100),
	PRIMARY KEY("ID")
);
CREATE TABLE IF NOT EXISTS "Produccion" (
	"Codigo"	VARCHAR(50),
	"Costo_produccion"	INT,
	"ID_producto"	VARCHAR(50),
	FOREIGN KEY("ID_producto") REFERENCES "Producto"("ID"),
	PRIMARY KEY("Codigo")
);
CREATE TABLE IF NOT EXISTS "Material" (
	"ID"	VARCHAR(50),
	"Nombre"	VARCHAR(100),
	"Cant"	INT,
	"Precio"	INT,
	"Imagen"	VARCHAR(100),
	PRIMARY KEY("ID")
);
CREATE TABLE IF NOT EXISTS "Historial_Produccion" (
	"ID"	VARCHAR(50),
	"ID_producto"	VARCHAR(100),
	"Fecha_inicio"	DATE,
	"Cant"	INT,
	"Fecha_Termino"	DATE,
	FOREIGN KEY("ID_producto") REFERENCES "Produccion"("Codigo"),
	PRIMARY KEY("ID")
);
CREATE TABLE IF NOT EXISTS "Material_Producto" (
	"ID_material"	VARCHAR(50),
	"ID_producto"	VARCHAR(50),
	"Cantidad"	INT,
	FOREIGN KEY("ID_producto") REFERENCES "Producto"("ID"),
	FOREIGN KEY("ID_material") REFERENCES "Material"("ID"),
	PRIMARY KEY("ID_material")
);
CREATE TABLE IF NOT EXISTS "Trabajadores" (
	"Rut"	VARCHAR(50),
	"Nombre"	VARCHAR(50),
	"Apellido_paterno"	VARCHAR(50),
	"Apeliido_materno"	VARCHAR(50),
	"Numero_telefonico"	VARCHAR(50),
	PRIMARY KEY("Rut")
);
CREATE TABLE IF NOT EXISTS "Registro_Asistencia" (
	"ID"	VARCHAR(50),
	"Rut"	VARCHAR(50),
	"Fecha"	DATE,
	"Hora_inicio"	TIME,
	"Hora_termino"	TIME,
	"Horas_trabajadas"	TIME,
	FOREIGN KEY("Rut") REFERENCES "Trabajadores"("Rut"),
	PRIMARY KEY("ID")
);
INSERT INTO "Producto" VALUES ('1','Mermelada de frambuesa',10,NULL);
COMMIT;
