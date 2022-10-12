from flask import Flask, request
from flask_cors import CORS

app = Flask(__name__)
cors=CORS(app)

@app.route('/')
def index():
    return "<p>Hello, World!</p>"

@app.route('/post', methods=['POST'])
def result():
    print(request.form['result'])  # json (if content-type of application/json is sent with the request)
    return request.json

if __name__ == "__main__":
    app.run()
