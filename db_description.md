A description of your database, including tables, attributes, primary keys,
foreign keys, foreign key constraints, FDs, whether in 3NF, and one or two rows of sample data for
each table.

The relational database we created is a Store inventory database. The database holds details and quantities of the 
products you stock, together with information on product suppliers. As well as the Order and Payment details.

The four relation tables are Product, Manufacturer, Order, & Payment.

below are the tables, with its attributes.

Relation 1 - Product
prodID	prodType	prodModel	prodPrice	mID
112233	Laptop	L359	799.99	1
112234	Laptop	L293	659.99	1
112235	TV	T923	1209.99	2
112236	Shirt	S425	19.99	3
112237	Shampoo	S108	8.99	4

Relation 2 - Manufacturer
mID	mName	mState	mCategory
1	Dell	TX	Electronics
2	Samsung	NJ	Electronics
3	Hanes	NC	Clothing
4	Dove	FL	Toiletries
5	ExxonMobil	TX	Oil

Relation 3 - Order
oID	oDate	oFirstName	oLastName	oAddress	prodID
294781	2022-01-02	Rick	Smith	293 S Owl	112237
314878	2022-01-04	Katie	Rogers	4874 N Washington	112233
982363	2022-01-04	John	Hasher	654 N Leaf	112236
315568	2022-01-05	Nate	Pass	9999 W Base	112235
128415	2022-01-06	Susan	Tatum	472 E Lincoln	112234

Relation 4 - Payment
payCardHolder	payCardNo	payCardCVV	oID
MasterCard	9782437737462847	988	294781
Discover	1284755717531765	475	314878
Visa	3814781357611651	234	982363
Amex	3136318613849028	381	315568
Visa	0938222456376535	667	128415

primary keys : prodID  mID ordID

foreign keys  : mID  ordID prodID

FDs :
prodType	->	mID
mID	->	prodType
 
All the relations are in 3NF

Sample Data 

SELECT prodModel FROM PRODUCTS 
WHERE prodType = 'Laptop'
prodModel
L359
L293


SELECT mName, mState FROM MANUFACTURER 
WHERE mCategory = 'Electronics'
mName	mState
Dell	TX
Samsung	NJ

SELECT oLastName, oAddress FROM ORDERS 
WHERE oDate = 2022-01-04
oLastName	oAddress
Rogers	4874 N Washington
Hasher	654 N Leaf

SELECT payCardHolder payCardNo, payCardCVV FROM PAYMENT 
WHERE payCardHolder = 'Visa'
payCardHolder	payCardNo	payCardCVV
Visa	938222456376535	667
Visa	3814781357611651	234
