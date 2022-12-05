INSERT INTO PRODUCTS (prodID, prodType, prodModel, prodPrice, manID) 
VALUES 
    (112233, "Laptop", "L359", 799.99, 1),
    (112234, "Laptop", "L293", 659.99, 1),
    (112235, "TV", "T923", 1209.99, 2),
    (112236, "Shirt", "S425", 19.99, 3),
    (112237, "Shampoo", "S108",	8.99, 4);

INSERT INTO MANUFACTURER (mID, mName, mState, mCategory) 
VALUES 
    (1,	"Dell",	"TX", "Elecronics"),
    (2,	"Samsung", "NJ", "Electronics"),
    (3,	"Hanes", "NC", "Clothing"),
    (4,	"Dove",	"FL", "Toiletries"),
    (5,	"ExxonMobil", "TX",	"Oil");

INSERT INTO ORDERS (oID, oDate, oFirstName, oLastName, oAddress, proID) 
VALUES 
    (294781, 2022-01-02, "Rick", "Smith", "293 S Owl", 112237),
    (314878, 2022-01-04, "Katie", "Rogers", "4874 N Washington", 112233),
    (982363, 2022-01-04, "John", "Hasher", "654 N Leaf", 112236),
    (315568, 2022-01-05, "Nate", "Pass", "9999 W Base", 112235),
    (128415, 2022-01-06, "Susan", "Tatum", "472 E Lincoln", 112234);

INSERT INTO PAYMENT (payCardHolder, payCardNo, payCardCVV, ordID) 
VALUES 
    ("MasterCard", 9782437737462847, 988, 294781),
    ("Discover", 1284755717531765, 475, 314878),
    ("Visa", 3814781357611651, 234, 982363),
    ("Amex", 3136318613849028, 381, 315568),
    ("Visa", 0938222456376535, 667, 128415);
