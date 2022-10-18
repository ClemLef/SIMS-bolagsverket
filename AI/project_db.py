
#from django.shortcuts import redirect
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

app = Flask(__name__)
cors=CORS(app)

def hello_vall():
    sum = 5
    sum_str = str(sum)
    return sum_str

@app.route('/post', methods=['POST'])
def result():
    print(request.json)
    return hello_valll()

if __name__ == "__main__":
    app.run()
 

def get_source(url):

    try:
        session = HTMLSession()
        response = session.get(url)
        return response

    except requests.exceptions.RequestException as e:
        print(e)

def scrape_google(query):  

    query = urllib.parse.quote_plus(query)  # str("environment sustainability") 
    response = get_source("https://www.google.com/search?q=" + query)      #"https://www.google.co.uk/search?q="


    links = list(response.html.absolute_links)
	
    google_domains = ('https://www.google.', 
                      'https://google.', 
                      'https://webcache.googleusercontent.', 
                      'http://webcache.googleusercontent.', 
                      'https://policies.google.',
                      'https://support.google.',
					  'https://translate.google.',
                      'https://maps.google.',
					  'https://www.com',
					  'https://scholar.google.')

    for url in links[:]:
        if url.startswith(google_domains):
            links.remove(url)
	
				
    return links	


###############
##############################################
def get_source(url):
    try:
        session = HTMLSession()
        response = session.get(url)
        return response
    except requests.exceptions.RequestException as e:
        print(e)
def get_results(query): 
    query = urllib.parse.quote_plus(query)
    response = get_source("https://www.google.co.uk/search?q=" + query)
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
            'text': result.find(css_identifier_text, first=True).text
        }
        output.append(item)
    return output
def google_search(query):
    response = get_results(query)
    return parse_results(response)
#################################################
#############################################


# Load a CSV file         
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
		##########print(row)
 



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
 


################################

# Split a dataset into k folds
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
		#print(len(train_set))    ############################
		#print(len(test_set))     ############################
		scores.append(accuracy)
	return scores

################################


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
		#print(summaries)                      ######################################
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
	#####################3##########################print(summarize)
	predictions = list()
	for row in test:
		output = predict(summarize, row)
		predictions.append(output)
		#print(predictions)
	return(predictions)


# Make a prediction with Naive Bayes on ???????? Dataset
seed(1)
filename = 'testdata.csv'
dataset = load_csv(filename)
for i in range(len(dataset[0])-1):
	str_column_to_float(dataset, i)
# convert class column to integers
str_column_to_int(dataset, len(dataset[0])-1)
#print(dataset)
#print(dataset[0])

model = summarize_by_class(dataset)
#print(model , "mmmmmmmmmmm")
# evaluate algorithm
n_folds = 5
scores = evaluate_algorithm(dataset, naive_bayes, n_folds)
print('Scores: %s' % scores)
print('Mean Accuracy: %.3f%%' % (sum(scores)/float(len(scores))))




"""
#to communicate with database

# Get connection
db = _connect()
 # Get cursor
cursor = db._cursor()
 # Select query to fetch information
query = "SELECT  social,economical,envirment,influence FROM result_question WHERE urc=457826;"
cursor.execute(query)
#cursor.execute("INSERT INTO ai (%s)", prediction)
records = cursor.fetchall()
 # save to array list

for record in records:
    row= list(record)
    print(row)
    #row.append(record)

#print(row_list)
db._close()

"""

##------------ put here the data from the form---------------##
row = []
print("Initial blank List: ")
row = [1,2,2,2]
print(row)
 
# Addition of Elements
#print("\nList after Addition of Three elements: ")

def hello_valll():
    sum = predict(model, row)

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

    #print("ans_final:",ans_final )


    fin_list = []

    

    fin_list.append(ans_final)

    aa= row[0]
    bb= row[1]
    cc= row[2]
    dd= row[3]
    print(aa)
    print(bb)
    print(cc)
    print(dd)
    #'''


    # show links
    if 2 >= aa:
        ecoJson = {
            # 0 = not sustainable
            'eco': 0,
        }
        fin_list.append(ecoJson)
        #links_ec_org =scrape_google("social sustainability.org")
        links_ec_org =google_search("economic sustainability.org")     # Scraping of Google SERPs isn't a violation of DMCA or CFAA. https://dataforseo.com/blog/is-scraping-google-serps-legal
        aaa= links_ec_org[0]
        fin_list.append(aaa)
        #bbb= links_ec_org[1]
        #fin_list.append(bbb)
        print(aaa)
        #print(bbb)

    if 2 >= aa:
        links_ec_edu =google_search("economic sustainability.edu")     # environment Scraping of Google SERPs isn't a violation of DMCA or CFAA. https://dataforseo.com/blog/is-scraping-google-serps-legal
        aaaa= links_ec_edu[0]
        fin_list.append(aaaa)
        bbbb= links_ec_edu[1]
        fin_list.append(bbbb)
        print(aaaa)
        print(bbbb)

    if 2 >= bb:
        soc="soc is not sus"
        fin_list.append(soc)

        links_ec_org =google_search("social sustainability.org")     # Scraping of Google SERPs isn't a violation of DMCA or CFAA. https://dataforseo.com/blog/is-scraping-google-serps-legal
        aaa= links_ec_org[0]
        fin_list.append(aaa)
        #bbb= links_ec_org[1]
        #fin_list.append(bbb)
        print(aaa)
       #print(bbb)

    if 2 >= bb:
        links_ec_edu =google_search("social sustainability.edu")     # environment Scraping of Google SERPs isn't a violation of DMCA or CFAA. https://dataforseo.com/blog/is-scraping-google-serps-legal
        aaaa= links_ec_edu[0]
        fin_list.append(aaaa)
        bbbb= links_ec_edu[1]
        fin_list.append(bbbb)
        print(aaaa)
        print(bbbb)
    
    if 2 >= cc:
        env="envi is not sus"
        fin_list.append(env)

        links_env_org =google_search("environment sustainability.org")     # Scraping of Google SERPs isn't a violation of DMCA or CFAA. https://dataforseo.com/blog/is-scraping-google-serps-legal
        aaa= links_env_org[0]
        fin_list.append(aaa)
        #bbb= links_env_org[1]
        #fin_list.append(bbb)
        print(aaa)
        #print(bbb)

    if 2 >= cc:
        links_env_edu =google_search("environment sustainability.edu")     # environment Scraping of Google SERPs isn't a violation of DMCA or CFAA. https://dataforseo.com/blog/is-scraping-google-serps-legal
        aaaa= links_env_edu[0]
        fin_list.append(aaaa)
        bbbb= links_env_edu[1]
        fin_list.append(bbbb)
        print(aaaa)
        print(bbbb)

    if 2 >= dd:
        enf="enf is not sus"
        fin_list.append(enf)

        links_enf_org =google_search("environment sustainability.org")     # Scraping of Google SERPs isn't a violation of DMCA or CFAA. https://dataforseo.com/blog/is-scraping-google-serps-legal
        aaa= links_enf_org[0]
        fin_list.append(aaa)
        #bbb= links_enf_org[1]
        #fin_list.append(bbb)
        print(aaa)
        #print(bbb)

    if 2 >= dd:
        links_enf_edu =google_search("environment sustainability.edu")     # environment Scraping of Google SERPs isn't a violation of DMCA or CFAA. https://dataforseo.com/blog/is-scraping-google-serps-legal
        aaaa= links_enf_edu[0]
        fin_list.append(aaaa)
        bbbb= links_enf_edu[1]
        fin_list.append(bbbb)
        print(aaaa)
        print(bbbb)
    return fin_list


'''
    if 2 >= aa:
        eco="eco is not sus"
        fin_list.append(eco)
    if 2 >= bb:
        soc="soc is not sus"
        fin_list.append(soc)
    if 2 >= cc:
        env="env is not sus"
        fin_list.append(env)
    if 2 >= dd:
        infl="infl is not sus"
        fin_list.append(infl)
'''

#print('Data=%s, Predicted: %s' % (row, label))

#print(label , "labelllllllllll")

#print(value_value , "value_value  laste")
#print(value_i , "value_i  laste")

#print(value_value, "value_value value_value value_value")
#value_i
'''
global ans_final
if thislist_val[0] == "notsustainabil" and thislist_i[0]== 1 and label== 1:
  ans_final="notsustainabil"
elif thislist_val[0] == "notsustainabil" and thislist_i[0]== 0 and label== 0:
  ans_final="notsustainabil"
elif thislist_val[0] == "notsustainabil" and thislist_i[0]== 0 and label== 1:
  ans_final="notsustainabil"
elif thislist_val[0] == "notsustainabil" and thislist_i[0]== 1 and label== 0:
  ans_final="notsustainabil"
elif thislist_val[1] == "notsustainabil" and thislist_i[1]== 1 and label== 1:
  ans_final="notsustainabil"
elif thislist_val[1] == "notsustainabil" and thislist_i[1]== 0 and label== 0:
  ans_final="notsustainabil"
elif thislist_val[1] == "notsustainabil" and thislist_i[1]== 1 and label== 0:
  ans_final="notsustainabil"
elif thislist_val[1] == "notsustainabil" and thislist_i[1]== 0 and label== 1:
  ans_final="notsustainabil"
else: 
	ans_final="sustainabil"

 
print("ans_final:",ans_final )

'''

#print(thislist_val)
#print(thislist_i)

'''
# show the nummber
aa= row[0]
bb= row[1]
cc= row[2]
dd= row[3]
print(aa)
print(bb)
print(cc)
print(dd)


# show links
if 4 > aa:
	links =scrape_google("environment sustainability.org")     # Scraping of Google SERPs isn't a violation of DMCA or CFAA. https://dataforseo.com/blog/is-scraping-google-serps-legal
	aaa= links[0]
	bbb= links[1]
	print(aaa)
	print(bbb)

if 4 > aa:
	linkss =scrape_google("environment sustainability.edu")     # Scraping of Google SERPs isn't a violation of DMCA or CFAA. https://dataforseo.com/blog/is-scraping-google-serps-legal
	aaaa= linkss[0]
	bbbb= linkss[1]
	print(aaaa)
	print(bbbb)

'''