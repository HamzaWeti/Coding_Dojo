from flask import Flask  
app = Flask(__name__)   



@app.route('/')         
def hello_world():
    return 'Hello World!' 

@app.route('/dojo')
def Dojo():
    return 'DOJO   JOY BOY'


@app.route('/say/<name>')
def say(name):
    return "hello  " + name
    



@app.route('/repeat/<int:num>/<string:word>')
def repeat_word(num, word):
    output = ''

    for i in range(0,num):
        output += f"<p>{word}</p>"

    return output





if __name__=="__main__":     
    app.run(debug=True , host="localhost", port=5000)  

