CREATE DATABASE BBDB; -- Creacion de la base de datos

USE BBDB; -- Usar la base de datos

-- Tabla UserLogin
CREATE TABLE UserLogin (
    User_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    User_rol VARCHAR(10) NOT NULL,
    User_firstname VARCHAR(50) NOT NULL,
    User_lastname VARCHAR(50) NOT NULL,
    User_email VARCHAR(50) UNIQUE NOT NULL,
    User_password VARCHAR(50) NOT NULL
);
GO

-- Tabla Orders
CREATE TABLE Orders (
    Order_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Order_date DATETIME NOT NULL,
    Employee_name VARCHAR(50) NOT NULL
);
GO

-- Tabla Products
CREATE TABLE Products (
    Product_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Product_name VARCHAR(50) NOT NULL,
    Unit_price MONEY NOT NULL,
    Unit_in_stock SMALLINT NOT NULL
);
GO

-- Tabla Order_Details (relación entre Orders y Products)
CREATE TABLE Order_Details (
    Order_id INT NOT NULL,
    Product_id INT NOT NULL,
    Unit_price MONEY NOT NULL,
    Quantity SMALLINT NOT NULL,
	TotalAmount AS (Quantity * Unit_price) PERSISTED,
    PRIMARY KEY (Order_id, Product_id),
    FOREIGN KEY (Order_id) REFERENCES Orders(Order_id),
    FOREIGN KEY (Product_id) REFERENCES Products(Product_id)
);
GO

-- Procedimiento para insertar un nuevo usuario
ALTER PROCEDURE AddUserLogin
    @User_rol VARCHAR(10),
    @User_firstname VARCHAR(50),
    @User_lastname VARCHAR(50),
    @User_email VARCHAR(50),
    @User_password VARCHAR(50)
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM UserLogin
		WHERE User_email = @User_email)

    INSERT INTO UserLogin (User_rol, User_firstname, User_lastname, User_email, User_password)
    VALUES (@User_rol, @User_firstname, @User_lastname, @User_email, @User_password);
END;
GO

-- Procedimiento para consultar un usuario por su gmail y contraseña
ALTER PROCEDURE GetUserLogin
    @User_email VARCHAR(50),
    @User_password VARCHAR(50)
AS
BEGIN
    SELECT * FROM UserLogin WHERE User_email = @User_email AND User_password = @User_password;
END;
GO

-- Procedimiento para obtener el rol de un usuario
ALTER PROCEDURE Login
    @User_email VARCHAR(50),
    @User_password VARCHAR(50)
AS
BEGIN
    SELECT User_rol FROM UserLogin WHERE User_email = @User_email AND User_password = @User_password;
END;
GO

-- Procedimiento para actualizar un usuario
ALTER PROCEDURE UpdateUserLogin
    @User_id INT,
    @User_rol VARCHAR(10),
    @User_firstname VARCHAR(50),
    @User_lastname VARCHAR(50),
    @User_email VARCHAR(50),
    @User_password VARCHAR(50)
AS
BEGIN
    UPDATE UserLogin
    SET User_rol = @User_rol,
        User_firstname = @User_firstname,
        User_lastname = @User_lastname,
        User_email = @User_email,
        User_password = @User_password
    WHERE User_id = @User_id;
END;
GO

-- Procedimiento para eliminar un usuario por su ID
ALTER PROCEDURE DeleteUserLogin
    @User_id INT
AS
BEGIN
    DELETE FROM UserLogin WHERE User_id = @User_id;
END;
GO

-- Procedimiento para insertar un nuevo producto
ALTER PROCEDURE AddProduct
    @Product_name VARCHAR(50),
    @Unit_price MONEY,
    @Unit_in_stock SMALLINT
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM Products
		WHERE Product_name = @Product_name)

    INSERT INTO Products (Product_name, Unit_price, Unit_in_stock)
	VALUES (@Product_name ,@Unit_price ,@Unit_in_stock)
END;
GO

-- Procedimiento para actualizar un producto
ALTER PROCEDURE UpdateProduct
	@Product_id INT,
    @Product_name VARCHAR(50),
    @Unit_price MONEY,
    @Unit_in_stock SMALLINT
AS
BEGIN
    UPDATE Products
    SET Product_name =  @Product_name,
        Unit_price = @Unit_price ,
        Unit_in_stock = @Unit_in_stock
    WHERE Product_id = @Product_id;
END;
GO

-- Procedimiento para eliminar un producto por su ID
ALTER PROCEDURE DeleteProducts
    @Product_id INT
AS
BEGIN
    DELETE FROM Products WHERE Product_id = @Product_id;
END;
GO

-- Eliminar los registros de todas las tablas
DELETE FROM UserLogin;
DELETE FROM Products;
DELETE FROM Orders;
DELETE FROM Order_Details;

-- Se reinicia el identity de todas las tablas
DBCC CHECKIDENT ('UserLogin', RESEED, 0);
DBCC CHECKIDENT ('Products', RESEED, 0);
DBCC CHECKIDENT ('Orders', RESEED, 0);

-- Se inserta dos usuarios a UserLogin
EXEC AddUserLogin 'Admin', '', '', 'Admin', '123';
EXEC AddUserLogin 'Empleado', 'Juan', 'Pérez', 'juan@gmail.com', 'clave123';
EXEC AddUserLogin 'Empleado', 'Pepe', 'Mella', 'Pepito@gmail.com', '1234';

-- Se obtiene toda la informacion de un cliente 
--EXEC GetUserLogin 'juan@gmail.com', 'clave123';

-- Se obtiene el rol de un cliente con su gmail y contraseña 
--EXEC Login 'juan@gmail.com', 'clave123';

-- Se actualiza la informacion de un usuario 
--EXEC UpdateUserLogin 1,'Admin', 'Julio', 'Peña', 'JulioPñ@gmail.com', '4321';

-- Se elimina el usuario con el id 1
--EXEC DeleteUserLogin 1;

-- Se inserta varios productos a la tabla Products
EXEC AddProduct 'Brichas', 150, 100;
EXEC AddProduct 'Clavos 1inch',	3.00, 1000
EXEC AddProduct 'Martillos', 150.00, 200
EXEC AddProduct 'Zocalo Plastico', 100.00, 100
EXEC AddProduct 'Grinpadora', 10.00, 1000
EXEC AddProduct 'Brocha Pequeña', 15.00, 50
EXEC AddProduct 'Brochas Medianas', 150.00, 100
EXEC AddProduct 'Brochas Grandes', 150.00, 100

-- Se actualiza un producto por su ID
--EXEC UpdateProduct 1,'Clavitos', 100 ,1020;

-- Se elimina un producto por su ID
--EXEC DeleteProducts 1;

-- Se consulta todos los datos de todas las tablas
SELECT * FROM UserLogin;
SELECT * FROM Products;
SELECT * FROM Orders;
SELECT * FROM Order_Details;
