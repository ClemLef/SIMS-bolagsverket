from flask import Flask, request

app = Flask(__name__)

@app.route('/', methods=['POST'])
def result():
    print(request.json)  # json (if content-type of application/json is sent with the request)

if __name__ == "__main__":
    app.run()
