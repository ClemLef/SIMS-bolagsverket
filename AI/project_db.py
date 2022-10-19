
#from django.shortcuts import redirect
from ast import If
from symbol import if_stmt
from flask import Flask, redirect, url_for, render_template
from csv import reader
from math import sqrt
from math import exp
from math import pi
from random import seed
from random import randrange
#from _connection import _connect
import requests
import urllib
import pandas as pd
from requests_html import HTML
from requests_html import HTMLSession
from bs4 import BeautifulSoup as bs
from flask import Flask, request
from flask_cors import CORS
from sklearn.metrics import classification_report
import json

app = Flask(__name__)
cors=CORS(app)

aiResultPost = {}

""" def hello_vall():
    sum = 5
    sum_str = str(sum)
    return sum_str """

#Communication
@app.route('/post', methods=['POST'])
def result():
    print(request.json)
    return hello_valll()

if __name__ == "__main__":
    app.run()
 

#Get links
def get_source(url):
    try:
        session = HTMLSession()
        response = session.get(url)
        return response
    except requests.exceptions.RequestException as e:
        print(e)
def get_results(query): 
    query = urllib.parse.quote_plus(query)
    response = get_source("https://www.google.com/search?q=" + query)
    return response

def parse_results(response):
    
    css_identifier_result = ".tF2Cxc"
    css_identifier_title = "h3"
    css_identifier_link = ".yuRUbf a"
    css_identifier_text = ".VwiC3b"
    results = response.html.find(css_identifier_result)
    output = []
    for result in results:
        item = {
            'title': result.find(css_identifier_title, first=True).text,
            'link': result.find(css_identifier_link, first=True).attrs['href'],
 #----------------------There's a problem here, sometimes the program crashes sayning it can't retrive text attribute------------------
            'text': result.find(css_identifier_text, first=True).text
        }
        output.append(item)
    return output
def google_search(query):
	try:
        response = get_results(query)
		return parse_results(response)
        
    except e:
        return "error getting the link"

    
 


# Load a CSV file that has the dataset        
def load_csv(filename):
	dataset = list()
	with open(filename, 'r') as file:
		csv_reader = reader(file)
		for row in csv_reader:
			if not row:
				continue
			dataset.append(row)
	return dataset
 
# Convert string column to float
def str_column_to_float(dataset, column):
	for row in dataset:
		row[column] = float(row[column].strip())
		#print(row)

global thislist_val
thislist_val = []
global thislist_i 
thislist_i = []

# Convert string column to integer
def str_column_to_int(dataset, column):
	class_values = [row[column] for row in dataset]
	unique = set(class_values)
	lookup = dict()
	for i, value in enumerate(unique):
		lookup[value] = i
		print('[%s] => %d' % (value, i))  ############################################
		#print(value, "value")
		#print(i, "i")
		global value_value
		value_value = value
		global value_i
		value_i = i
		thislist_val.append(value)
		thislist_i.append(i)
		
	for row in dataset:
		row[column] = lookup[row[column]]
		#print(lookup)
	return lookup
 


#Evaluate the models algorithm 
#Split a dataset into k folds
def cross_validation_split(dataset, n_folds):
	dataset_split = list()
	dataset_copy = list(dataset)
	fold_size = int(len(dataset) / n_folds)
	for _ in range(n_folds):
		fold = list()
		while len(fold) < fold_size:
			index = randrange(len(dataset_copy))
			fold.append(dataset_copy.pop(index))
		dataset_split.append(fold)
	return dataset_split
 
# Calculate accuracy percentage
def accuracy_metric(actual, predicted):
	correct = 0
	for i in range(len(actual)):
		if actual[i] == predicted[i]:
			correct += 1
	return correct / float(len(actual)) * 100.0
 
# Evaluate an algorithm using a cross validation split
def evaluate_algorithm(dataset, algorithm, n_folds, *args):
	folds = cross_validation_split(dataset, n_folds)
	#print(folds)
	scores = list()
	for fold in folds:
		#print(fold)
		train_set = list(folds)
		train_set.remove(fold)
		train_set = sum(train_set, [])
		#print(train_set)
		test_set = list()
		#print(train_set)
		for row in fold:
			row_copy = list(row)
			test_set.append(row_copy)
			row_copy[-1] = None
		predicted = algorithm(train_set, test_set, *args)
		actual = [row[-1] for row in fold]
		accuracy = accuracy_metric(actual, predicted)
		#print(accuracy)
		scores.append(accuracy)
	return scores
#

# Split the dataset by class values, returns a dictionary
def separate_by_class(dataset):
	separated = dict()
	for i in range(len(dataset)):
		vector = dataset[i]
		class_value = vector[-1]
		if (class_value not in separated):
			separated[class_value] = list()
		separated[class_value].append(vector)
	return separated
 
# Calculate the mean of a list of numbers
def mean(numbers):
	return sum(numbers)/float(len(numbers))
 
# Calculate the standard deviation of a list of numbers
def stdev(numbers):
	avg = mean(numbers)
	variance = sum([(x-avg)**2 for x in numbers]) / float(len(numbers)-1)
	return sqrt(variance)
 
# Calculate the mean, stdev and count for each column in a dataset
def summarize_dataset(dataset):
	summaries = [(mean(column), stdev(column), len(column)) for column in zip(*dataset)]
	del(summaries[-1])
	return summaries
 
# Split dataset by class then calculate statistics for each row
def summarize_by_class(dataset):
	separated = separate_by_class(dataset)
	summaries = dict()
	for class_value, rows in separated.items():
		summaries[class_value] = summarize_dataset(rows)
		#print(summaries)                    
	return summaries
 
# Calculate the Gaussian probability distribution function for x
def calculate_probability(x, mean, stdev):
	exponent = exp(-((x-mean)**2 / (2 * stdev**2 )))
	return (1 / (sqrt(2 * pi) * stdev)) * exponent
 
# Calculate the probabilities of predicting each class for a given row
def calculate_class_probabilities(summaries, row):
	total_rows = sum([summaries[label][0][2] for label in summaries])
	probabilities = dict()
	for class_value, class_summaries in summaries.items():
		probabilities[class_value] = summaries[class_value][0][2]/float(total_rows)
		for i in range(len(class_summaries)):
			mean, stdev, _ = class_summaries[i]
			probabilities[class_value] *= calculate_probability(row[i], mean, stdev)
	return probabilities
 
# Predict the class for a given row
def predict(summaries, row):
	probabilities = calculate_class_probabilities(summaries, row)
	best_label, best_prob = None, -1
	for class_value, probability in probabilities.items():
		if best_label is None or probability > best_prob:
			best_prob = probability
			best_label = class_value
			#print('best_label:best_prob', best_label,best_prob)
          
	return best_label

# Naive Bayes Algorithm
def naive_bayes(train, test):
	summarize = summarize_by_class(train)
	#print(summarize)
	predictions = list()
	for row in test:
		output = predict(summarize, row)
		predictions.append(output)
		#print(predictions)
	return(predictions)

# Make a prediction with Naive Bayes on the dataset
seed(1)
filename = 'testdata.csv'
dataset = load_csv(filename)
for i in range(len(dataset[0])-1):
	str_column_to_float(dataset, i)
# convert class column to integers
str_column_to_int(dataset, len(dataset[0])-1)
model = summarize_by_class(dataset)
# evaluate algorithm
n_folds = 5
scores = evaluate_algorithm(dataset, naive_bayes, n_folds)
print('Scores: %s' % scores)
print('Mean Accuracy: %.3f%%' % (sum(scores)/float(len(scores))))

##------------ put here the data from the form---------------##
row = []
print("Initial blank List: ")
row = [1,2,2,2]
print(row)
#run the model
def hello_valll():
	#call predict Function 
    sum = predict(model, row)
	#Get the final answer from the model by looking to the predict answer  
    global ans_final
    if thislist_val[0] == "notsustainabil" and thislist_i[0]== 1 and sum== 1:
        ans_final="NOT sustainable"
    elif thislist_val[0] == "notsustainabil" and thislist_i[0]== 0 and sum== 0:
        ans_final="NOT sustainable"
    elif thislist_val[0] == "notsustainabil" and thislist_i[0]== 0 and sum== 1:
        ans_final="NOT sustainable"
    elif thislist_val[0] == "notsustainabil" and thislist_i[0]== 1 and sum== 0:
        ans_final="NOT sustainable"
    elif thislist_val[1] == "notsustainabil" and thislist_i[1]== 1 and sum== 1:
     ans_final="NOT sustainable"
    elif thislist_val[1] == "notsustainabil" and thislist_i[1]== 0 and sum== 0:
        ans_final="NOT sustainable"
    elif thislist_val[1] == "notsustainabil" and thislist_i[1]== 1 and sum== 0:
        ans_final="NOT sustainable"
    elif thislist_val[1] == "notsustainabil" and thislist_i[1]== 0 and sum== 1:
        ans_final="NOT sustainable"
    else: 
        ans_final="Sustainable"
	#print("The final answer:",ans_final )

    fin_list = []
    aiResultPost['global'] = ans_final
    #fin_list.append(ans_final_json)

    eco_ans= row[0]
    soc_ans= row[1]
    env_ans= row[2]
    inf_ans= row[3]
    print(eco_ans)
    print(soc_ans)
    print(env_ans)
    print(inf_ans)
    #'''

    # show links

	
    if 2 < eco_ans:
        aiResultPost['eco'] = 1

    if 2 >= eco_ans:
        aiResultPost['eco'] = 0

    links_ec_org =google_search("economic sustainability.org")    
    aiResultPost['eco_link_1'] = links_ec_org[0]
    links_ec_edu =google_search("economic sustainability.edu")     
    aiResultPost['eco_link_2'] = links_ec_edu[0]
    aiResultPost['eco_link_3'] = links_ec_edu[1]

    if 2 < soc_ans:
        aiResultPost['soc'] = 1

    if 2 >= soc_ans:
        aiResultPost['soc'] = 0
    
    links_ec_org =google_search("social sustainability.org")     
    aaa= links_ec_org[0]
    aiResultPost['soc_link_1'] = links_ec_org[0]
    links_ec_edu =google_search("social sustainability.edu")    
    aiResultPost['soc_link_2'] = links_ec_edu[0]
    aiResultPost['soc_link_3'] = links_ec_edu[1]
        
    if 2 < env_ans:
        aiResultPost['env'] = 1

    if 2 >= env_ans:
        aiResultPost['env'] = 0

    links_env_org =google_search("environment sustainability.org")     
    aiResultPost['env_link_1'] = links_env_org[0]
    links_env_edu =google_search("environment sustainability.edu")     
    aiResultPost['env_link_2'] = links_env_edu[0]
    aiResultPost['env_link_3'] = links_env_edu[1]
    
    if 2 < inf_ans:
        aiResultPost['inf'] = 1

    if 2 >= inf_ans:
        aiResultPost['inf'] = 0
    
    links_enf_org =google_search("environment sustainability.org")     
    aiResultPost['inf_link_1'] = links_enf_org[0]
    links_enf_edu =google_search("environment sustainability.edu")     
    aiResultPost['inf_link_2'] = links_enf_edu[0]
    aiResultPost['inf_link_3'] = links_enf_edu[1]
       
    return json.dumps(aiResultPost)

