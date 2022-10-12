from flask import Flask, request
from flask_cors import CORS

app = Flask(__name__)

cors = CORS(app)

@app.route('/', methods=['POST'])
def result():
    print(request.json)  # json (if content-type of application/json is sent with the request)

if __name__ == "__main__":
    app.run()