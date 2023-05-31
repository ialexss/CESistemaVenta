-- Crear la base de datos
CREATE DATABASE CasoEstudioSistemaVentas;

-- Utilizar la base de datos
USE CasoEstudioSistemaVentas;

-- Crear la tabla Cliente
CREATE TABLE Cliente (
  Id INT PRIMARY KEY,
  Direccion VARCHAR(255),
  Telefono VARCHAR(20),
  Nit VARCHAR(20)
);

-- Crear la tabla Juridico
CREATE TABLE Juridico (
  Id INT PRIMARY KEY,
  RazonSocial VARCHAR(255),
  RepresentanteLegal VARCHAR(255),
  NroRegistro VARCHAR(50),
  FOREIGN KEY (Id) REFERENCES Cliente(Id)
);

-- Crear la tabla Natural
CREATE TABLE Natural (
  Id INT PRIMARY KEY,
  NombreCliente VARCHAR(255),
  ApellidoPaterno VARCHAR(255),
  ApellidoMaterno VARCHAR(255),
  FechaNacimiento DATE,
  DocumentoIdentidad VARCHAR(50),
  FOREIGN KEY (Id) REFERENCES Cliente(Id)
);

-- Crear la tabla Venta
CREATE TABLE Venta (
  Id INT PRIMARY KEY,
  FechaVenta DATE,
  EstadoVenta VARCHAR(50),
  SubTotal DECIMAL(10, 2),
  ClienteId INT,
  FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
);

-- Crear la tabla DetalleVenta
CREATE TABLE DetalleVenta (
  Id INT PRIMARY KEY,
  IdVenta INT,
  IdProducto INT,
  Cantidad INT,
  Precio DECIMAL(10, 2),
  FOREIGN KEY (IdVenta) REFERENCES Venta(Id),
  FOREIGN KEY (IdProducto) REFERENCES Producto(Id)
);

-- Crear la tabla Producto
CREATE TABLE Producto (
  Id INT PRIMARY KEY,
  NombreProducto VARCHAR(255),
  MarcaId INT,
  FOREIGN KEY (MarcaId) REFERENCES Marca(Id)
);

-- Crear la tabla Factura
CREATE TABLE Factura (
  Id INT PRIMARY KEY,
  NumeroFactura VARCHAR(50),
  FechaEmision DATE,
  MontoFactura DECIMAL(10, 2),
  VentaId INT,
  FOREIGN KEY (VentaId) REFERENCES Venta(Id)
);

-- Crear la tabla Marca
CREATE TABLE Marca (
  Id INT PRIMARY KEY,
  NombreMarca VARCHAR(255),
  PaisProcedenciaId INT,
  FOREIGN KEY (PaisProcedenciaId) REFERENCES PaisProcedencia(Id)
);

-- Crear la tabla PaisProcedencia
CREATE TABLE PaisProcedencia (
  Id INT PRIMARY KEY,
  NombrePais VARCHAR(255)
);

-- Crear la tabla AlmacenProducto
CREATE TABLE AlmacenProducto (
  Id INT PRIMARY KEY,
  IdAlmacen INT,
  IdProducto INT,
  Cantidad INT,
  Descripcion VARCHAR(255),
  FOREIGN KEY (IdAlmacen) REFERENCES Almacen(Id),
  FOREIGN KEY (IdProducto) REFERENCES Producto(Id)
);

-- Crear la tabla Almacen
CREATE TABLE Almacen (
  Id INT PRIMARY KEY,
  Almacen VARCHAR(255),
  Ubicacion VARCHAR(255)
);

-- Crear la tabla Precio
CREATE TABLE Precio (
  Id INT PRIMARY KEY,
  FechaInicial DATE,
  FechaFinal DATE,
  Precio DECIMAL(10, 2),
  ProductoId INT,
  FOREIGN KEY (ProductoId) REFERENCES Producto(Id)
);