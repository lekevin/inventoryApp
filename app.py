from flask import Flask, render_template, request
import sqlite3 as sql

app = Flask(__name__, template_folder='templates')

@app.route('/')
@app.route('/index')
def new_item():
    return render_template('index.html')

@app.route('/address', methods=['POST', 'GET'])
def address():
    if request.method == 'POST':
        try: 
            ProductID = request.form['prodid']
            ProductType = request.form['prodtype']
            ProductModel = request.form['prodmodel']
            ProductPrice = request.form['prodprice']
            ManufacturerID = request.form['manuid']

            with sql.connect("database.db") as con:
                cur = con.cursor()

                cur.execute("INSERT INTO ")