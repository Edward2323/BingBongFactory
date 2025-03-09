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

ALTER FROM User

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
    PRIMARY KEY (Order_id, Product_id),
    FOREIGN KEY (Order_id) REFERENCES Orders(Order_id),
    FOREIGN KEY (Product_id) REFERENCES Products(Product_id)
);
GO

-- Procedimiento para insertar un nuevo usuario
CREATE PROCEDURE AddUserLogin
    @User_rol VARCHAR(5),
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
CREATE PROCEDURE GetUserLogin
    @User_email VARCHAR(50),
    @User_password VARCHAR(50)
AS
BEGIN
    SELECT * FROM UserLogin WHERE User_email = @User_email AND User_password = @User_password;
END;
GO

CREATE PROCEDURE Login
    @User_email VARCHAR(50),
    @User_password VARCHAR(50)
AS
BEGIN
    SELECT User_rol FROM UserLogin WHERE User_email = @User_email AND User_password = @User_password;
END;
GO

-- Procedimiento para actualizar un usuario
CREATE PROCEDURE UpdateUserLogin
    @User_id INT,
    @User_rol VARCHAR(5),
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
CREATE PROCEDURE DeleteUserLogin
    @User_id INT
AS
BEGIN
    DELETE FROM UserLogin WHERE User_id = @User_id;
END;
GO

INSERT INTO Products (Product_name, Unit_price, Unit_in_stock)
VALUES ('Clavos 1inch',3,1000),
('Martillos',150,200),
('Zocalo Plastico',100,100),
('Grinpadora',10,100),
('Brocha pequeña',15,50)

DBCC CHECKIDENT ('UserLogin', RESEED, 0);

EXEC AddUserLogin 'Admin', 'Juan', 'Pérez', 'juan@email.com', 'clave123';
EXEC GetUserLogin 'juan@email.com', 'clave123';
EXEC Login 'jrayberacarvajal@gmail.com', '17725';
EXEC UpdateUserLogin 1,'Admin', 'Picapollo', 'Pérez', 'juan@email.com', 'clave123';
EXEC DeleteUserLogin 1;

