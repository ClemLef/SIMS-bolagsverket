# Imports
from flask import Flask, request
from flask_cors import CORS
import json
import time

# Init the app and CORS
app = Flask(__name__)
cors=CORS(app)

#@app.route('/')
#def index():
#    return "<p>Hello, World!</p>"

# Define the /post URL route, only allows POST
@app.route('/post', methods=['POST'])
def result():
    # Prints the request contents (JSON) in the console
    print(request.json)
    # Put this info in a variable
    result = json.dumps(request.json)
    # Use return to return the result of the AI processing to the front end
    time.sleep(10);    
    return "sustainable"

# Main function run indefinitely
if __name__ == "__main__":
    app.run()
