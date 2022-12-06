INSERT INTO PRODUCTS(prodID, prodType, prodModel, prodPrice, manID) VALUES (@prodID, @prodType, @prodModel, @prodPrice, @manID)

UPDATE PRODUCTS Set prodType=@ProductType, prodModel=@ProductModel, prodPrice=@ProductPrice, manID=@ManufacturerID WHERE prodID=@ProductID

DELETE FROM PRODUCTS WHERE prodID=@ProductID
