# Loan-Calculator-ASP.NET-Core-Web-API-React

A sample web application to calculate the Equal Monthly Loan Installment (EMI).

•	Built a standalone React app + .Net / .Net Core Web API.

•	Factory design patter is used to extent the application in future to support other calculation types.

•	Basic input validation is done both in front-end and in back-end applications.

•	Tested the API using postman.

•	“Calculation Types” are hardcoded for the implementation, but the repository pattern is implemented to get the “Calculation Types” from persistent storage in      future.

•	Implemented unit test case for test the calculation logic


## Technologies ##
ASP.NET Core 5 Web API

React 18.2.0

## Setup and Run ##
git clone https://github.com/ano010/Loan-Calculator-ASP.NET-Core-Web-API-React.git


### Run Backend ###
cd Loan-Calculator-ASP.NET-Core-Web-API-React\loan-calculator-api\LoanCalculator

dotner restore

dotnet run

### Run Frontend ###
cd Loan-Calculator-ASP.NET-Core-Web-API-React\loan-calculator-ui

npm install

npm start
