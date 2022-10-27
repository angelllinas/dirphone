use directorio;

create table datos_empleado (
    documento_identidad varchar(50) not null primary key,
    nombre varchar(50),
    apellido varchar(50),
    telefono_empresarial varchar(45),
    cargo varchar(50),
    numero_oficina varchar(50),
    fotografia varchar(60)
);